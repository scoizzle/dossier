#!/usr/bin/env node
// Live multi-agent demo: N real `dossier mcp` child processes write one SQLite database at
// once while `dossier serve` streams revisions and answers graph queries next to them.
// No dependencies, Node 18+.
//
//   node scripts/live-demo.mjs [--agents 4] [--facts 100] [--db <path>] [--port 8787]
//                              [--keep] [--rate <facts/sec per agent>]
//
// The binary is $DOSSIER_BIN if set, else the Release build output
// src/Dossier/bin/Release/net10.0/Dossier.dll run through `dotnet`; a missing build is
// produced with `dotnet build src/Dossier/Dossier.csproj -c Release`. Set
// DOSSIER_NO_BUILD=1 to refuse the build and fail instead.

import { spawn, spawnSync } from 'node:child_process';
import { existsSync, mkdtempSync, rmSync } from 'node:fs';
import http from 'node:http';
import net from 'node:net';
import { tmpdir } from 'node:os';
import path from 'node:path';
import readline from 'node:readline';
import { fileURLToPath } from 'node:url';

const repoRoot = path.resolve(path.dirname(fileURLToPath(import.meta.url)), '..');

function usage(code) {
  const out = code === 0 ? console.log : console.error;
  out('usage: node scripts/live-demo.mjs [--agents 4] [--facts 100] [--db <path>] [--port 8787] [--keep] [--rate <facts/sec per agent>]');
  process.exit(code);
}

// Set once main() knows what it created, so a fail() path still removes its temp database.
let failureCleanup = null;

function fail(message) {
  console.error(`live-demo: ${message}`);
  try { failureCleanup?.(); } catch { /* best effort */ }
  process.exit(2);
}

function positiveInt(raw, flag) {
  const value = Number(raw);
  if (!Number.isInteger(value) || value < 1) fail(`${flag} must be a positive integer`);
  return value;
}

function parseArgs(argv) {
  const options = { agents: 4, facts: 100, db: null, port: 8787, keep: false, rate: 0, killAgentAfter: null };
  for (let index = 0; index < argv.length; index++) {
    const arg = argv[index];
    const next = () => {
      const value = argv[++index];
      if (value === undefined) fail(`${arg} needs a value`);
      return value;
    };
    switch (arg) {
      case '--agents': options.agents = positiveInt(next(), arg); break;
      case '--facts': options.facts = positiveInt(next(), arg); break;
      case '--db': options.db = path.resolve(next()); break;
      case '--port': options.port = positiveInt(next(), arg); break;
      case '--rate': options.rate = Number(next()); if (!(options.rate >= 0)) fail('--rate must be >= 0'); break;
      case '--keep': options.keep = true; break;
      // Hidden debug hook: kill agent-0's child mid-call to prove a dead child fails fast.
      case '--kill-agent-after': options.killAgentAfter = positiveInt(next(), arg); break;
      case '--help': case '-h': usage(0); break;
      default: fail(`unknown argument: ${arg}`);
    }
  }

  return options;
}

function launchSpec(file) {
  return file.endsWith('.dll')
    ? { label: `dotnet ${path.relative(repoRoot, file)}`, command: 'dotnet', prefix: [file] }
    : { label: file, command: file, prefix: [] };
}

function locateDossier() {
  if (process.env.DOSSIER_BIN) {
    const explicit = path.resolve(process.env.DOSSIER_BIN);
    if (!existsSync(explicit)) fail(`DOSSIER_BIN does not exist: ${explicit}`);
    return launchSpec(explicit);
  }

  const release = path.join(repoRoot, 'src/Dossier/bin/Release/net10.0/Dossier.dll');
  if (!existsSync(release) && process.env.DOSSIER_NO_BUILD !== '1') {
    console.error('live-demo: building src/Dossier -c Release ...');
    const build = spawnSync('dotnet', ['build', path.join(repoRoot, 'src/Dossier/Dossier.csproj'), '-c', 'Release'], {
      cwd: repoRoot,
      stdio: 'inherit',
    });
    if (build.status !== 0) fail('dotnet build failed');
  }

  if (existsSync(release)) return launchSpec(release);

  const debug = path.join(repoRoot, 'src/Dossier/bin/Debug/net10.0/Dossier.dll');
  if (existsSync(debug)) {
    console.error('live-demo: no Release build, using the Debug build');
    return launchSpec(debug);
  }

  return fail('no dossier build found; run `dotnet build src/Dossier/Dossier.csproj -c Release` or set DOSSIER_BIN');
}

const sleep = (ms) => new Promise((resolve) => setTimeout(resolve, ms));

function canBind(port) {
  return new Promise((resolve) => {
    const probe = net.createServer();
    probe.once('error', () => resolve(false));
    probe.once('listening', () => probe.close(() => resolve(true)));
    probe.listen(port, '127.0.0.1');
  });
}

/** The requested port when free, else the next free one: a stray `dossier serve` must not block a demo. */
async function pickPort(start, attempts = 50) {
  for (let port = start; port < start + attempts; port++) {
    if (await canBind(port)) return port;
  }

  return fail(`no free port in ${start}..${start + attempts - 1}`);
}

function httpRequest(port, pathname, timeout = 10_000) {
  return new Promise((resolve, reject) => {
    const started = performance.now();
    const request = http.request({ host: '127.0.0.1', port, path: pathname, method: 'GET', timeout }, (response) => {
      let body = '';
      response.setEncoding('utf8');
      response.on('data', (chunk) => { body += chunk; });
      response.on('end', () => resolve({ status: response.statusCode, body, ms: performance.now() - started }));
    });
    request.on('timeout', () => request.destroy(new Error(`timeout after ${timeout} ms`)));
    request.on('error', reject);
    request.end();
  });
}

function openRevisionStream(port) {
  const state = { events: 0, last: 0, closed: false };
  const request = http.get({ host: '127.0.0.1', port, path: '/api/events', timeout: 0 }, (response) => {
    const lines = readline.createInterface({ input: response });
    lines.on('line', (line) => {
      if (!line.startsWith('data:')) return;
      const value = Number(line.slice(5).trim());
      if (!Number.isFinite(value)) return;
      state.events++;
      state.last = value;
    });
  });
  request.on('error', () => {});
  state.close = () => {
    state.closed = true;
    request.destroy();
  };
  return state;
}

class McpAgent {
  constructor(spec, dbPath, name) {
    this.name = name;
    this.nextId = 1;
    this.pending = new Map();
    this.stderr = '';
    this.dead = null;
    this.stats = { ok: 0, busy: 0, other: 0 };
    this.child = spawn(spec.command, [...spec.prefix, 'mcp'], {
      env: { ...process.env, DOSSIER_DB: dbPath },
      stdio: ['pipe', 'pipe', 'pipe'],
    });
    this.child.stdin.on('error', () => {});
    this.child.stderr.setEncoding('utf8');
    this.child.stderr.on('data', (chunk) => { this.stderr = (this.stderr + chunk).slice(-2000); });
    // A dead child must not leave its callers waiting out the 60 s call timeout, and a spawn
    // failure must not take the process down with it: fail everything in flight instead.
    this.child.on('exit', (code, signal) => this.die(`mcp child exited (code=${code}, signal=${signal ?? 'none'})`));
    this.child.on('error', (error) => this.die(`mcp child error: ${error.message}`));
    this.lines = readline.createInterface({ input: this.child.stdout });
    this.lines.on('line', (line) => {
      if (!line.trim()) return;
      let message;
      try {
        message = JSON.parse(line);
      } catch {
        return;
      }
      const waiter = this.pending.get(message.id);
      if (!waiter) return;
      this.pending.delete(message.id);
      if (message.error) waiter.reject(new Error(`${message.error.code}: ${message.error.message}`));
      else waiter.resolve(message.result);
    });
  }

  /** Marks the agent dead, counts one error and rejects its in-flight calls right away. */
  die(reason) {
    if (this.dead) return;
    this.dead = reason;
    this.stats.other++;
    if (!this.failure) this.failure = reason;
    const waiters = [...this.pending.values()];
    this.pending.clear();
    for (const waiter of waiters) {
      const error = new Error(reason);
      error.fatal = true;
      waiter.reject(error);
    }
  }

  call(method, params, timeout = 60_000) {
    if (this.dead) {
      const error = new Error(this.dead);
      error.fatal = true;
      return Promise.reject(error);
    }
    const id = this.nextId++;
    return new Promise((resolve, reject) => {
      const timer = setTimeout(() => {
        this.pending.delete(id);
        reject(new Error(`mcp ${method} timed out`));
      }, timeout);
      this.pending.set(id, {
        resolve: (value) => { clearTimeout(timer); resolve(value); },
        reject: (error) => { clearTimeout(timer); reject(error); },
      });
      this.child.stdin.write(`${JSON.stringify({ jsonrpc: '2.0', id, method, params })}\n`);
    });
  }

  async initialize() {
    await this.call('initialize', {
      protocolVersion: '2025-06-18',
      capabilities: {},
      clientInfo: { name: 'live-demo', version: '1' },
    });
  }

  async postFacts(subjectName, facts) {
    const result = await this.call('tools/call', {
      name: 'post_facts',
      arguments: { subject: { name: subjectName }, facts },
    });
    const text = result?.content?.[0]?.text ?? '{}';
    const parsed = JSON.parse(text);
    if (result.isError) {
      const error = new Error(parsed?.error?.message ?? 'post_facts failed');
      error.code = parsed?.error?.code;
      throw error;
    }
    return parsed;
  }

  close() {
    try { this.child.stdin.end(); } catch { /* already closed */ }
    try { this.child.kill('SIGTERM'); } catch { /* already gone */ }
  }
}

function percentile(samples, p) {
  if (samples.length === 0) return null;
  const sorted = [...samples].sort((a, b) => a - b);
  const index = Math.min(sorted.length - 1, Math.max(0, Math.ceil(p * sorted.length) - 1));
  return sorted[index];
}

function formatLatency(samples) {
  if (samples.length === 0) return 'n=0';
  const p50 = percentile(samples, 0.5);
  const p95 = percentile(samples, 0.95);
  return `n=${samples.length} p50=${p50.toFixed(1)}ms p95=${p95.toFixed(1)}ms max=${Math.max(...samples).toFixed(1)}ms`;
}

/** Counts one failed call against its agent; a dead child already counted itself in die(). */
function recordError(agent, error) {
  const message = String(error.message ?? error);
  if (error.fatal) return;
  if (/busy|locked/i.test(message)) agent.stats.busy++;
  else agent.stats.other++;
  if (!agent.failure) agent.failure = message;
}

async function main() {
  const options = parseArgs(process.argv.slice(2));
  const spec = locateDossier();

  const tempRoot = options.db ? null : mkdtempSync(path.join(tmpdir(), 'dossier-live-demo-'));
  const dbPath = options.db ?? path.join(tempRoot, 'dossier.db');
  const port = await pickPort(options.port);

  let server = null;
  const agents = [];
  let revisions = null;
  let sampler = null;
  let cleaned = false;

  const cleanup = () => {
    if (cleaned) return;
    cleaned = true;
    if (sampler) clearInterval(sampler);
    if (revisions) revisions.close();
    for (const agent of agents) agent.close();
    if (server) server.child.kill('SIGTERM');
    if (tempRoot) {
      try { rmSync(tempRoot, { recursive: true, force: true }); } catch { /* best effort */ }
    }
  };

  failureCleanup = cleanup;

  process.on('SIGINT', () => {
    console.log('\nlive-demo: stopping');
    cleanup();
    process.exit(0);
  });

  try {
    console.log(`binary   ${spec.label}`);
    console.log(`port     ${port}${port === options.port ? '' : ` (${options.port} was busy)`}`);
    console.log(`database ${dbPath}`);

    server = { child: null, stderr: '' };
    server.child = spawn(spec.command, [...spec.prefix, 'serve', '--port', String(port)], {
      env: { ...process.env, DOSSIER_DB: dbPath },
      stdio: ['ignore', 'ignore', 'pipe'],
    });
    server.child.stderr.setEncoding('utf8');
    server.child.stderr.on('data', (chunk) => { server.stderr = (server.stderr + chunk).slice(-2000); });

    let live = false;
    for (let attempt = 0; attempt < 150; attempt++) {
      if (server.child.exitCode !== null) fail(`dossier serve exited: ${server.stderr.trim() || `code ${server.child.exitCode}`}`);
      try {
        const probe = await httpRequest(port, '/api/revision', 1000);
        if (probe.status === 200) { live = true; break; }
      } catch {
        // not listening yet
      }
      await sleep(100);
    }
    if (!live) fail(`dossier serve did not answer on port ${port}`);

    // Seed the root subject the graph view opens on, and keep its fact as the hub every
    // agent refs, so depth-1 from the root shows the whole run.
    const seeder = new McpAgent(spec, dbPath, 'seed');
    await seeder.initialize();
    const seeded = await seeder.postFacts('live-demo/root', [
      { kind: 'note', text: 'live-demo root: every agent below references this fact' },
    ]);
    seeder.close();
    const rootFact = seeded.response.facts[0].id;
    const rootSubject = seeded.response.subject.id;

    console.log(`url      http://127.0.0.1:${port}/#/graph/${rootSubject}`);
    console.log(`agents   ${options.agents} x ${options.facts} facts${options.rate > 0 ? ` at ${options.rate}/s each` : ' unthrottled'}`);
    console.log('');

    revisions = openRevisionStream(port);

    const graphUrl = `/api/graph?subject=${encodeURIComponent(rootSubject)}&depth=1&facts=true&max_nodes=500`;
    const graph = { during: [], after: [] };
    const sample = async () => {
      try {
        const reply = await httpRequest(port, graphUrl);
        graph.during.push(reply.ms);
        if (reply.status !== 200) graph.duringStatusFailures = (graph.duringStatusFailures ?? 0) + 1;
      } catch {
        graph.duringStatusFailures = (graph.duringStatusFailures ?? 0) + 1;
      }
    };
    sampler = setInterval(sample, 25);

    for (let index = 0; index < options.agents; index++) {
      agents.push(new McpAgent(spec, dbPath, `agent-${index}`));
    }

    let posted = 0;
    const startedAt = performance.now();
    await Promise.all(agents.map(async (agent, index) => {
      try {
        await agent.initialize();
      } catch (error) {
        recordError(agent, error);
        agent.failure ??= `initialize: ${error.message}`;
        return;
      }

      let previous = rootFact;
      for (let i = 0; i < options.facts; i++) {
        // A child that died stops writing at once instead of timing out call after call.
        if (agent.dead) break;

        if (options.killAgentAfter !== null && index === 0 && i === options.killAgentAfter) {
          // Debug: kill the child with a call in flight, so the run must end promptly with a
          // rejection rather than stalling on the 60 s call timeout.
          const doomed = agent.postFacts('live-demo/doomed', [{ kind: 'note', text: 'doomed' }]).then(
            () => 'call resolved before the kill',
            (error) => `call rejected: ${error.message}`);
          agent.child.kill('SIGKILL');
          console.log(`live-demo: debug --kill-agent-after ${options.killAgentAfter}: ${await doomed}`);
          break;
        }

        const shared = i % 3 === 0;
        const subject = shared ? 'live-demo/shared' : `live-demo/agent-${index}`;
        const refs = [{ rel: 'mentions', kind: 'fact', target: rootFact, basis: 'observed' }];
        if (previous !== rootFact) {
          refs.push({ rel: 'follows', kind: 'fact', target: previous, basis: 'observed' });
        }

        try {
          const result = await agent.postFacts(subject, [
            { kind: 'note', text: `agent ${index} fact ${i} (${shared ? 'shared' : 'own'})`, refs },
          ]);
          agent.stats.ok++;
          posted++;
          const fact = result.response?.facts?.[0];
          if (fact?.id) previous = fact.id;
        } catch (error) {
          recordError(agent, error);
        }

        if (options.rate > 0) await sleep(1000 / options.rate);
      }
    }));
    const wallMs = performance.now() - startedAt;

    clearInterval(sampler);
    sampler = null;

    for (let i = 0; i < 10; i++) {
      try {
        const reply = await httpRequest(port, graphUrl);
        graph.after.push(reply.ms);
        if (reply.status !== 200) graph.afterStatusFailures = (graph.afterStatusFailures ?? 0) + 1;
      } catch {
        graph.afterStatusFailures = (graph.afterStatusFailures ?? 0) + 1;
      }
    }

    // Let the server's 500 ms revision poll deliver the last write before reading it.
    await sleep(700);
    const revisionReply = await httpRequest(port, '/api/revision');
    const finalRevision = JSON.parse(revisionReply.body).revision;

    // The stream may still owe a frame for the last write: give it a short grace window.
    for (let attempt = 0; attempt < 30 && revisions.last !== finalRevision; attempt++) await sleep(100);

    const busy = agents.reduce((sum, agent) => sum + agent.stats.busy, 0);
    const other = agents.reduce((sum, agent) => sum + agent.stats.other, 0);
    const errors = busy + other;
    const graphFailures = (graph.duringStatusFailures ?? 0) + (graph.afterStatusFailures ?? 0);
    const streamBehind = revisions.last !== finalRevision;
    const seconds = wallMs / 1000;

    console.log('summary');
    console.log(`  facts posted       ${posted} (+1 seed, ${options.agents * options.facts} attempted)`);
    console.log(`  wall time          ${seconds.toFixed(2)} s`);
    console.log(`  writes/sec         ${(posted / seconds).toFixed(1)}`);
    console.log(`  errors             ${errors} total (busy=${busy} other=${other})`);
    for (const agent of agents) {
      const detail = agent.failure ? ` first: ${agent.failure}` : '';
      console.log(`    ${agent.name} ok=${agent.stats.ok} busy=${agent.stats.busy} other=${agent.stats.other}${detail}`);
    }
    console.log(`  sse revisions      ${revisions.events} events, ${(revisions.events / seconds).toFixed(1)}/s, last data=${revisions.last}`);
    console.log(`  graph during       ${formatLatency(graph.during)}${graph.duringStatusFailures ? ` status-failures=${graph.duringStatusFailures}` : ''}`);
    console.log(`  graph after        ${formatLatency(graph.after)}${graph.afterStatusFailures ? ` status-failures=${graph.afterStatusFailures}` : ''}`);
    console.log(`  final revision     ${finalRevision}`);

    const failures = [];
    if (errors > 0) failures.push(`${errors} write error(s)`);
    if (graphFailures > 0) failures.push(`${graphFailures} graph status failure(s)`);
    if (streamBehind) failures.push(`sse is behind: last data=${revisions.last}, final revision=${finalRevision}`);
    if (failures.length > 0) console.log(`  failed             ${failures.join('; ')}`);

    if (options.keep) {
      console.log('');
      console.log(`live-demo: server left running at http://127.0.0.1:${port}/#/graph/${rootSubject}`);
      console.log('live-demo: press Ctrl-C to stop');
      for (const agent of agents) agent.close();
      await new Promise(() => {});
    }

    cleanup();
    process.exit(failures.length === 0 ? 0 : 1);
  } catch (error) {
    console.error(`live-demo: ${error.message}`);
    cleanup();
    process.exit(1);
  }
}

await main();
