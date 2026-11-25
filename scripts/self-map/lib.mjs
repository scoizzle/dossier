// Shared by build.mjs and agent.mjs: reading the repository at one pinned commit, turning a cited
// phrase into a git ref, and calling the real `dossier` binary (the CLI for reads, `dossier mcp` for
// writes, so every fact carries the identity of the agent that posted it).

import { spawnSync } from 'node:child_process';
import path from 'node:path';
import { fileURLToPath } from 'node:url';

export const here = path.dirname(fileURLToPath(import.meta.url));
export const repoRoot = path.resolve(here, '..', '..');
export const REPO = 'scoizzle/dossier';

export function die(message, code = 2) {
  console.error(`self-map: ${message}`);
  process.exit(code);
}

export function git(...args) {
  const run = spawnSync('git', args, { cwd: repoRoot, encoding: 'utf8', maxBuffer: 256 * 1024 * 1024 });
  if (run.status !== 0) die(`git ${args.join(' ')} failed: ${run.stderr.trim()}`);
  return run.stdout;
}

/** The repository as it is at one commit: file lines, blob hashes, and refs that cite them. */
export function repoAt(revision) {
  const rev = git('rev-parse', `${revision}^{commit}`).trim();
  const tracked = git('ls-tree', '-r', '--name-only', rev).split('\n').filter(Boolean);
  const trackedSet = new Set(tracked);
  const files = new Map();
  const blobs = new Map();

  function linesOf(file) {
    if (!trackedSet.has(file)) throw new Error(`${file} is not in ${rev.slice(0, 8)}`);
    if (!files.has(file)) files.set(file, git('show', `${rev}:${file}`).split('\n'));
    return files.get(file);
  }

  function blobOf(file) {
    if (!blobs.has(file)) blobs.set(file, git('rev-parse', `${rev}:${file}`).trim());
    return blobs.get(file);
  }

  /** The ref every fact carries: where in the repository, at which commit, the claim can be read. */
  function source(file, line) {
    const reference = {
      rel: 'derived_from', kind: 'git', target: `${REPO}/${file}`, basis: 'observed', rev,
      snapshot: `https://github.com/${REPO}/blob/${rev}/${file}${line ? `#L${line}` : ''}`,
      snapshot_hash: blobOf(file),
    };
    if (line) reference.locator = { line };
    return reference;
  }

  /** 1-based line of the first line of `file` containing `phrase`, or an error string. */
  function findLine(file, phrase) {
    let lines;
    try {
      lines = linesOf(file);
    } catch (error) {
      return { error: error.message };
    }
    if (typeof phrase !== 'string' || phrase.trim().length < 4) return { error: `the phrase cited in ${file} must be at least 4 characters` };
    const index = lines.findIndex((line) => line.includes(phrase));
    return index < 0 ? { error: `"${phrase}" is not in ${file} at ${rev.slice(0, 8)}` } : { line: index + 1 };
  }

  return { rev, tracked, trackedSet, linesOf, blobOf, source, findLine };
}

export function oneLine(text) {
  return String(text ?? '').replace(/\s+/g, ' ').trim();
}

/** A handle on one store through one binary. */
export function dossierAt(dll, dbPath) {
  const command = (args) => (dll.endsWith('.dll') ? ['dotnet', [dll, ...args]] : [dll, args]);

  function cli(args, input, cwd) {
    const [program, argv] = command(args);
    const run = spawnSync(program, argv, { cwd, env: { ...process.env, DOSSIER_DB: dbPath }, input, encoding: 'utf8', maxBuffer: 512 * 1024 * 1024 });
    return { status: run.status, out: run.stdout, err: run.stderr };
  }

  /** One MCP session: initialize as `agent`, then call each tool; returns the parsed tool results. */
  function mcp(agent, calls) {
    const lines = [JSON.stringify({ jsonrpc: '2.0', id: 0, method: 'initialize', params: { protocolVersion: '2025-06-18', capabilities: {}, clientInfo: { name: agent, version: '1' } } })];
    calls.forEach((call, index) => lines.push(JSON.stringify({ jsonrpc: '2.0', id: index + 1, method: 'tools/call', params: { name: call.name, arguments: call.arguments } })));
    const [program, argv] = command(['mcp']);
    const run = spawnSync(program, argv, { env: { ...process.env, DOSSIER_DB: dbPath }, input: `${lines.join('\n')}\n`, encoding: 'utf8', maxBuffer: 512 * 1024 * 1024 });
    if (run.status !== 0) throw new Error(`dossier mcp exited ${run.status}: ${run.stderr.trim()}`);
    const replies = new Map();
    for (const line of run.stdout.split('\n').filter(Boolean)) {
      const message = JSON.parse(line);
      replies.set(message.id, message);
    }
    return calls.map((call, index) => {
      const reply = replies.get(index + 1);
      if (!reply) throw new Error(`no reply to ${call.name}`);
      if (reply.error) throw new Error(`${call.name}: ${reply.error.message}`);
      const body = JSON.parse(reply.result.content[0].text);
      if (reply.result.isError) throw new Error(`${call.name}: ${body.error?.code}: ${body.error?.message}`);
      return body;
    });
  }

  /** post_facts as `agent`; a rejected item is an error, since a partial batch would hide a bad fact. */
  function post(agent, request) {
    const [result] = mcp(agent, [{ name: 'post_facts', arguments: request }]);
    if (result.errors?.length) throw new Error(`post rejected ${request.subject.name ?? request.subject.id}: ${JSON.stringify(result.errors[0])}`);
    return result.response;
  }

  return { cli, mcp, post };
}
