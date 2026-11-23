#!/usr/bin/env node
// Self-map: Dossier documenting Dossier. Reads this repository at one pinned commit, turns it into
// subjects and one-claim facts, and posts them through the real `dossier` CLI into a store.
//
//   node scripts/self-map/build.mjs [--rev <commit>] [--db <path>] [--out <bundle dir>]
//                                   [--refresh-github] [--plan] [--no-swarm]
//
// Three sources of facts:
//   - extracted: structure read straight from the files (source symbols and their doc comments, CLI
//     verbs, MCP tools, contract schemas, the SQLite schema, error codes, tests, scripts, CI, docs).
//   - written: scripts/self-map/knowledge/*.json, the claims a reader needs that no parser can find
//     (concepts, guarantees, decisions, gaps, research). Each cites a file and a phrase in it.
//   - swarm: scripts/self-map/swarm/*.json, what delegated agents submitted through agent.mjs, one
//     file per agent, replayed here in file order under that agent's name (--no-swarm leaves it out).
//
// Every fact carries a git ref pinned to the commit, with the line, a permalink and the blob hash.
// A written fact's phrase must occur in the cited file at that commit, or the build fails: nothing
// is cited that is not there. No dependencies, Node 18+.
// Exit codes: 0 built, 1 a fact or citation was rejected, 2 usage or setup error.

import { spawnSync } from 'node:child_process';
import { existsSync, mkdirSync, mkdtempSync, readFileSync, readdirSync, rmSync, writeFileSync } from 'node:fs';
import { tmpdir } from 'node:os';
import path from 'node:path';
import { REPO, die, dossierAt, here, oneLine, repoAt, repoRoot } from './lib.mjs';

/** Who posts what: the actor recorded on each fact says whether a parser or a person wrote it. */
const EXTRACTOR = 'self-map-extractor';
const AUTHOR = 'self-map-author';

function parseArgs(argv) {
  const options = { rev: null, db: null, out: null, refreshGithub: false, plan: false, swarm: true };
  for (let index = 0; index < argv.length; index++) {
    const arg = argv[index];
    const next = () => argv[++index] ?? die(`${arg} needs a value`);
    switch (arg) {
      case '--rev': options.rev = next(); break;
      case '--db': options.db = path.resolve(next()); break;
      case '--out': options.out = path.resolve(next()); break;
      case '--refresh-github': options.refreshGithub = true; break;
      case '--plan': options.plan = true; break;
      case '--no-swarm': options.swarm = false; break;
      case '--help': case '-h':
        console.log('usage: node scripts/self-map/build.mjs [--rev <commit>] [--db <path>] [--out <bundle dir>] [--refresh-github] [--plan] [--no-swarm]');
        process.exit(0);
        break;
      default: die(`unknown argument: ${arg}`);
    }
  }
  return options;
}

const options = parseArgs(process.argv.slice(2));
// Without --rev the map is built at the commit the swarm read (slices.json), so a rebuild after later commits gives the same graph.
const pinned = existsSync(path.join(here, 'slices.json')) ? JSON.parse(readFileSync(path.join(here, 'slices.json'), 'utf8')).rev : null;
const repo = repoAt(options.rev ?? pinned ?? 'HEAD');
const { rev, tracked, trackedSet, linesOf, source } = repo;

const problems = [];
/** 1-based line of the first line of `file` containing `phrase`; a missing phrase is a build failure. */
function lineOf(file, phrase, context) {
  const found = repo.findLine(file, phrase);
  if (found.error) {
    problems.push(`${context}: ${found.error}`);
    return null;
  }
  return found.line;
}

// ---- the model ---------------------------------------------------------------------------------

const subjects = new Map();
function subject(name, kind, parent = null, aliases = []) {
  const key = name.toLowerCase();
  if (subjects.has(key)) {
    const existing = subjects.get(key);
    if (existing.name !== name) problems.push(`subject "${name}" collides with "${existing.name}" (names match case-insensitively)`);
    return existing;
  }
  const created = { name, kind, parent, aliases, facts: [], keys: new Set() };
  subjects.set(key, created);
  return created;
}

/**
 * Adds one fact. `refs` may hold finished refs and symbolic ones: { rel, subject: name } for a subject
 * ref, { rel, fact: [subjectName, key] } for a fact ref that is resolved to an id when its target is posted.
 */
function fact(subjectName, entry) {
  const owner = subjects.get(subjectName.toLowerCase());
  if (!owner) {
    problems.push(`fact ${entry.key} names unknown subject "${subjectName}"`);
    return;
  }
  const text = oneLine(entry.text);
  if (!entry.key) problems.push(`a fact on "${subjectName}" has no key: ${text.slice(0, 60)}`);
  if (owner.keys.has(entry.key)) problems.push(`duplicate key "${entry.key}" on "${subjectName}"`);
  owner.keys.add(entry.key);
  if (!text) problems.push(`fact ${subjectName}#${entry.key} has no text`);
  owner.facts.push({ ...entry, text, kind: entry.kind ?? 'claim', refs: entry.refs ?? [], agent: entry.agent ?? EXTRACTOR });
}

// ---- small parsers -----------------------------------------------------------------------------

/** XML doc comment text as plain prose. */
function plainDoc(raw) {
  return oneLine(raw
    .replace(/<see cref="(?:[A-Za-z]:)?([^"]+)"\s*\/>/g, (_, name) => name.replace(/^.*\./, ''))
    .replace(/<paramref name="([^"]+)"\s*\/>/g, '$1')
    .replace(/<\/?(?:c|summary|list[^>]*|item|para|remarks|returns|term|description)>/g, ' ')
    .replace(/&lt;/g, '<').replace(/&gt;/g, '>').replace(/&amp;/g, '&').replace(/&quot;/g, '"'));
}

/** Splits prose into sentences without breaking on "e.g." or a dotted name. */
function sentences(text) {
  const out = [];
  let current = '';
  const parts = text.split(/(?<=[.!?])\s+(?=[A-Z"`(\[])/);
  for (const part of parts) {
    current = current ? `${current} ${part}` : part;
    if (/(?:\b(?:e\.g|i\.e|etc|vs)\.)$/.test(current)) continue;
    out.push(current.trim());
    current = '';
  }
  if (current.trim()) out.push(current.trim());
  return out.filter((sentence) => sentence.length > 0);
}

/** The `/// <summary>` block that ends just above line index `at` (0-based), as { text, line }. */
function summaryAbove(lines, at) {
  let end = at - 1;
  while (end >= 0 && /^\s*\[/.test(lines[end])) end--;
  if (end < 0 || !/^\s*\/\/\//.test(lines[end])) return null;
  let start = end;
  while (start - 1 >= 0 && /^\s*\/\/\//.test(lines[start - 1])) start--;
  const raw = lines.slice(start, end + 1).map((line) => line.replace(/^\s*\/\/\/ ?/, '')).join(' ');
  const summary = /<summary>([\s\S]*?)<\/summary>/.exec(raw);
  const text = plainDoc(summary ? summary[1] : raw);
  return text ? { text, line: start + 1 } : null;
}

function humanize(identifier) {
  return identifier
    .replace(/_/g, ', ')
    .replace(/([a-z0-9])([A-Z])/g, '$1 $2')
    .replace(/([A-Z]+)([A-Z][a-z])/g, '$1 $2')
    .toLowerCase();
}

function docFacts(subjectName, doc, file, declarationLine, prefix = 'doc') {
  if (!doc) return;
  sentences(doc.text).forEach((sentence, index) => {
    fact(subjectName, { key: `${prefix}.${index + 1}`, kind: 'doc', text: sentence, tags: ['from:doc-comment'], refs: [source(file, doc.line), ...(declarationLine ? [source(file, declarationLine)] : [])] });
  });
}

// ---- extractors --------------------------------------------------------------------------------

function extractProject() {
  subject('Dossier', 'project', null, ['dossier']);
  for (const [name, kind] of [
    ['Dossier/Source', 'area'], ['Dossier/CLI', 'area'], ['Dossier/MCP', 'area'], ['Dossier/Web', 'area'], ['Dossier/Contract', 'area'],
    ['Dossier/Store', 'area'], ['Dossier/Errors', 'area'], ['Dossier/Tests', 'area'], ['Dossier/Scripts', 'area'], ['Dossier/Docs', 'area'],
    ['Dossier/CI', 'area'], ['Dossier/Dependencies', 'area'], ['Dossier/GitHub', 'area'], ['Dossier/Tools', 'area'], ['Dossier/Examples', 'area'],
    ['Dossier/Profiles', 'area'], ['Dossier/Repository', 'area'],
  ]) subject(name, kind, 'Dossier');
}

function extractSource() {
  const owns = new Map();
  const architecture = linesOf('docs/architecture.md');
  architecture.forEach((line, index) => {
    const row = /^\|\s*((?:`[^`]+`(?:,\s*)?)+)\s*\|\s*(.+?)\s*\|\s*$/.exec(line);
    if (!row) return;
    const names = row[1].match(/`([^`]+)`/g).map((token) => token.slice(1, -1));
    for (const name of names) owns.set(name, { text: row[2], line: index + 1, shared: names });
  });
  const unowned = [];

  const store = subject('DossierStore', 'type', 'Dossier/Source', ['the store']);
  for (const file of tracked.filter((name) => /^src\/Dossier\/[^/]+\.cs$/.test(name) || /^src\/Dossier\/www\//.test(name))) {
    const lines = linesOf(file);
    const base = path.posix.basename(file);
    subject(file, 'file', 'Dossier/Source', [base]);
    fact(file, { key: 'size', kind: 'measure', text: `${file} is ${lines.length - (lines[lines.length - 1] === '' ? 1 : 0)} lines long at this commit.`, data: { lines: lines.length - (lines[lines.length - 1] === '' ? 1 : 0) }, refs: [source(file, 1)] });
    const role = owns.get(base) ?? owns.get(`www/${base}`);
    if (role) fact(file, { key: 'role', text: role.shared.length > 1 ? `The architecture table lists ${role.shared.join(', ')} together as owning: ${role.text}.` : `${base} owns: ${role.text}.`, refs: [source('docs/architecture.md', role.line), source(file, 1)] });
    else if (file.endsWith('.cs')) unowned.push(base);
    if (!file.endsWith('.cs')) continue;

    lines.forEach((line, index) => {
      const type = /^(?:public|internal)\s+(?:(?:sealed|static|abstract|partial|readonly)\s+)*(class|record|struct|enum|interface)\s+(?:struct\s+)?(\w+)/.exec(line);
      if (type) {
        const [, shape, name] = type;
        if (name === 'DossierStore') {
          fact('DossierStore', { key: `part.${base}`, text: `DossierStore is a partial class and ${base} holds one part of it.`, refs: [source(file, index + 1), { rel: 'about', subject: file }] });
          docFacts('DossierStore', summaryAbove(lines, index), file, index + 1, `doc.${base}`);
          return;
        }
        const typeSubject = `${base}::${name}`;
        subject(typeSubject, 'type', file, [name]);
        fact(typeSubject, { key: 'decl', text: `${name} is a ${shape} declared in ${file}.`, refs: [source(file, index + 1)] });
        docFacts(typeSubject, summaryAbove(lines, index), file, index + 1);
        return;
      }

      const constant = /^\s{4}(?:public|internal)\s+const\s+(\w+)\s+(\w+)\s*=\s*(.+?);/.exec(line);
      if (constant) {
        const [, , name, value] = constant;
        const doc = summaryAbove(lines, index);
        const literal = value.replace(/^"|"$/g, '');
        const parsed = /^-?[\d_]+$/.test(value) ? Number(value.replace(/_/g, '')) : literal;
        fact(file, { key: `const.${name}`, kind: 'constant', text: `${name} is ${value}${doc ? `: ${doc.text}` : '.'}`, data: { [name]: parsed }, refs: [source(file, index + 1)] });
        return;
      }

      const method = /^\s{4}(?:public|internal)\s+(?:static\s+)?(?!const\b|class\b|sealed\b|record\b|readonly\b)[\w<>\[\]?,. ()]+?\s+(\w+)\(/.exec(line);
      if (method && !/\b(?:class|record|struct|new)\b/.test(line.split('(')[0]) && !line.includes(' => new ') ) {
        const name = method[1];
        const doc = summaryAbove(lines, index);
        if (!doc) return;
        const owner = /^\s{4}/.test(line) ? enclosingType(lines, index) : null;
        if (!owner) return;
        const symbol = `${owner}.${name}`;
        if (subjects.has(symbol.toLowerCase())) {
          docFacts(symbol, doc, file, index + 1, `doc.L${index + 1}`);
          return;
        }
        subject(symbol, 'method', owner === 'DossierStore' ? 'DossierStore' : file, []);
        fact(symbol, { key: 'decl', text: `${symbol} is declared in ${file}.`, refs: [source(file, index + 1), { rel: 'about', subject: file }] });
        docFacts(symbol, doc, file, index + 1);
      }
    });
  }
  void store;
  if (unowned.length > 0) {
    subject('docs/architecture.md', 'doc', 'Dossier/Docs', ['architecture.md']);
    fact('docs/architecture.md', { key: 'files-not-in-table', kind: 'finding', text: `The architecture table names no owner for ${unowned.length} source file(s): ${unowned.join(', ')}.`, data: { files: unowned }, tags: ['docs-vs-code'], refs: [source('docs/architecture.md', lineOf('docs/architecture.md', '| File | Owns |', 'architecture')), ...unowned.map((base) => ({ rel: 'about', subject: `src/Dossier/${base}` }))] });
  }
}

/** Name of the top-level type whose body contains line `at`. */
function enclosingType(lines, at) {
  for (let index = at; index >= 0; index--) {
    const type = /^(?:public|internal)\s+(?:(?:sealed|static|abstract|partial|readonly)\s+)*(?:class|record|struct|interface)\s+(?:struct\s+)?(\w+)/.exec(lines[index]);
    if (type) return type[1];
  }
  return null;
}

function extractCli() {
  const file = 'src/Dossier/Program.cs';
  const lines = linesOf(file);
  const usageLine = lines.findIndex((line) => line.includes('const string usage ='));
  const usage = /"(.*)";\s*$/.exec(lines[usageLine])[1];
  const verbs = [];
  let depth = 0;
  let token = '';
  for (const character of usage.replace(/^usage: dossier </, '').replace(/>$/, '')) {
    if (character === '[' || character === '<') depth++;
    if (character === ']' || character === '>') depth--;
    if (character === '|' && depth === 0) { verbs.push(token); token = ''; } else token += character;
  }
  verbs.push(token);

  const body = lines.join('\n');
  const specs = new Map();
  const specPattern = /"(\w+)"\s*=>\s*(?:arguments\.Length[^?]*\?\s*)?\(\[([^\]]*)\],\s*\[([^\]]*)\],\s*(\d)\)/g;
  for (let match; (match = specPattern.exec(body));) {
    const line = body.slice(0, match.index).split('\n').length;
    const list = (text) => (text.match(/"(--[\w-]+)"/g) ?? []).map((flag) => flag.slice(1, -1));
    specs.set(match[1], { values: list(match[2]), booleans: list(match[3]), line });
  }

  fact('Dossier/CLI', { key: 'usage', text: `The CLI's usage line lists ${verbs.length} verbs: ${verbs.map((verb) => verb.split(' ')[0]).join(', ')}.`, data: { verbs: verbs.length }, refs: [source(file, usageLine + 1)] });
  for (const entry of verbs) {
    const name = entry.split(' ')[0];
    const verb = name === 'dossier' ? 'dossier compile' : name;
    const verbSubject = `Dossier/CLI/${verb}`;
    subject(verbSubject, 'cli-verb', 'Dossier/CLI', [`dossier ${verb}`]);
    fact(verbSubject, { key: 'synopsis', text: `Synopsis: dossier ${entry}`, refs: [source(file, usageLine + 1)] });
    const caseLine = lines.findIndex((line) => line.trim() === `case "${name}":`);
    if (caseLine >= 0) fact(verbSubject, { key: 'dispatch', text: `The ${verb} verb is dispatched from the switch in Program.cs.`, refs: [source(file, caseLine + 1), { rel: 'about', subject: file }] });
    const spec = specs.get(name);
    if (spec) {
      fact(verbSubject, {
        key: 'options', text: spec.values.length + spec.booleans.length === 0
          ? `${verb} takes no options, only positional arguments.`
          : `${verb} accepts ${spec.values.length} value option(s) [${spec.values.join(', ') || 'none'}] and ${spec.booleans.length} switch(es) [${spec.booleans.join(', ') || 'none'}]; any other option is rejected before the store is opened.`,
        data: { value_options: spec.values, switches: spec.booleans }, refs: [source(file, spec.line)],
      });
    } else {
      fact(verbSubject, { key: 'options', text: `${verb} has no entry in the option table, so its arguments are not validated before dispatch.`, refs: [source(file, lineOf(file, 'static (string[] ValueFlags, string[] BooleanFlags, int Start)? VerbSpec', 'cli'))] });
    }
  }
}

function extractMcp() {
  const file = 'src/Dossier/Mcp.cs';
  const lines = linesOf(file);
  const body = lines.join('\n');
  subject('Dossier/MCP/server', 'component', 'Dossier/MCP', ['dossier mcp server']);
  const versions = /SupportedVersions = \[([^\]]+)\]/.exec(body);
  const versionList = versions[1].match(/"([^"]+)"/g).map((token) => token.slice(1, -1));
  fact('Dossier/MCP/server', { key: 'versions', text: `The MCP server answers protocol versions ${versionList.join(', ')} and falls back to the first when a client asks for another.`, data: { protocol_versions: versionList }, refs: [source(file, lineOf(file, 'SupportedVersions =', 'mcp'))] });
  docFacts('Dossier/MCP/server', summaryAbove(lines, lines.findIndex((line) => line.startsWith('public sealed class McpServer'))), file, lineOf(file, 'public sealed class McpServer', 'mcp'));
  const methods = [...body.matchAll(/^\s+"([a-z/]+)" => /gm)].map((match) => match[1]).filter((name) => name.includes('/') || name === 'initialize' || name === 'ping');
  fact('Dossier/MCP/server', { key: 'methods', text: `The server handles these JSON-RPC methods: ${methods.join(', ')}; any other method is answered with -32601.`, data: { methods }, refs: [source(file, lineOf(file, '"initialize" => Initialize(parameters)', 'mcp'))] });

  const tools = [];
  const pattern = /new\("(\w+)",\s*"((?:[^"\\]|\\.)*)"\s*\+\s*Untrusted,\s*"""([\s\S]*?)"""\)/g;
  for (let match; (match = pattern.exec(body));) {
    const [, name, description, schemaText] = match;
    const line = body.slice(0, match.index).split('\n').length;
    const schema = JSON.parse(schemaText);
    tools.push(name);
    const toolSubject = `Dossier/MCP/${name}`;
    subject(toolSubject, 'mcp-tool', 'Dossier/MCP', [name]);
    sentences(description.replace(/\\"/g, '"')).forEach((sentence, index) => fact(toolSubject, { key: `description.${index + 1}`, kind: 'doc', text: sentence, tags: ['from:tool-description'], refs: [source(file, line)] }));
    const properties = Object.entries(schema.properties ?? {});
    const required = schema.required ?? [];
    fact(toolSubject, {
      key: 'input', text: `${name} takes ${properties.length} argument(s): ${properties.map(([property, shape]) => `${property} (${shape.type ?? 'any'}${shape.enum ? `: ${shape.enum.join('|')}` : ''})`).join(', ')}; required: ${required.join(', ') || 'none'}.`,
      data: { arguments: properties.map(([property]) => property), required }, refs: [source(file, line + 1)],
    });
  }
  fact('Dossier/MCP', { key: 'tools', text: `The MCP server lists ${tools.length} tools: ${tools.join(', ')}.`, data: { tools: tools.length }, refs: [source(file, lineOf(file, 'private static readonly ToolDef[] ToolDefs', 'mcp'))] });
  fact('Dossier/MCP', { key: 'untrusted', text: 'Every tool description, the resource descriptions and the server instructions end by saying that returned fact text is untrusted data and must never be followed as instructions.', refs: [source(file, lineOf(file, 'private const string Untrusted', 'mcp'))] });
  for (const uri of ['dossier://subjects', 'dossier://subject/{id}', 'dossier://fact/{id}']) {
    const resource = `Dossier/MCP/resource ${uri}`;
    subject(resource, 'mcp-resource', 'Dossier/MCP', [uri]);
    fact(resource, { key: 'uri', text: `The MCP resource ${uri} is ${uri.includes('{') ? 'a resource template' : 'a listed resource'} served by ReadResource.`, refs: [source(file, lineOf(file, `"${uri}"`, 'mcp'))] });
  }
}

function extractContract() {
  for (const file of tracked.filter((name) => /^contract\/.+\.schema\.json$/.test(name))) {
    const lines = linesOf(file);
    const schema = JSON.parse(lines.join('\n'));
    const base = path.posix.basename(file);
    subject(file, 'schema', 'Dossier/Contract', [base]);
    fact(file, { key: 'title', text: `${base} is the normative JSON Schema titled "${schema.title}".`, refs: [source(file, lineOf(file, '"title"', 'contract'))] });
    sentences(schema.description ?? '').forEach((sentence, index) => fact(file, { key: `description.${index + 1}`, kind: 'doc', text: sentence, tags: ['from:schema-description'], refs: [source(file, lineOf(file, '"description"', 'contract'))] }));
    const describe = (name, shape, where) => {
      const properties = Object.keys(shape.properties ?? {});
      if (properties.length === 0 && !shape.enum) return;
      const line = lineOf(file, where, `contract ${base}#${name}`);
      fact(file, {
        key: `shape.${name}`, kind: 'shape',
        text: shape.enum
          ? `${name} is one of: ${shape.enum.join(', ')}.`
          : `${name} has ${properties.length} properties (${properties.join(', ')}); required: ${(shape.required ?? []).join(', ') || 'none'}; ${shape.additionalProperties === false ? 'no other property is allowed' : 'other properties are allowed'}.`,
        data: { shapes: { [name]: { properties, required: shape.required ?? [], ...(shape.enum ? { enum: shape.enum } : {}) } } }, refs: [source(file, line)],
      });
      for (const [property, inner] of Object.entries(shape.properties ?? {})) {
        if (inner.enum) fact(file, { key: `enum.${name}.${property}`, kind: 'shape', text: `${name}.${property} is one of: ${inner.enum.join(', ')}.`, data: { enums: { [name]: { [property]: inner.enum } } }, refs: [source(file, lineOf(file, `"${property}":`, `contract ${base}`))] });
      }
    };
    if (schema.properties && !schema.$defs?.Op_dump) describe(schema.title, schema, '"properties"');
    for (const [name, shape] of Object.entries(schema.$defs ?? {})) describe(name, shape, `"${name}": {`);
  }
}

function extractStore() {
  const file = 'src/Dossier/Store.cs';
  const lines = linesOf(file);
  const body = lines.join('\n');
  for (const match of body.matchAll(/CREATE (VIRTUAL )?TABLE IF NOT EXISTS (\w+)\s*(?:USING (\w+))?\(([\s\S]*?)\);/g)) {
    const [, virtual, name, module, columnsText] = match;
    const line = body.slice(0, match.index).split('\n').length;
    const table = `Dossier/Store/table ${name}`;
    subject(table, 'table', 'Dossier/Store', [name]);
    const columns = columnsText.split(/,\s*\n|,(?![^(]*\))/).map((column) => oneLine(column)).filter(Boolean);
    const names = columns.filter((column) => !/^PRIMARY KEY/i.test(column)).map((column) => column.split(' ')[0]);
    fact(table, {
      key: 'columns', kind: 'shape', text: virtual
        ? `${name} is a ${module} virtual table over the columns ${names.join(', ')}.`
        : `The ${name} table has ${names.length} columns: ${names.join(', ')}.`,
      data: { columns: names }, refs: [source(file, line)],
    });
    const primary = /PRIMARY KEY\s*\(([^)]+)\)/i.exec(columnsText) ?? /(\w+)\s+\w+\s+NOT NULL PRIMARY KEY/i.exec(columnsText);
    if (primary) fact(table, { key: 'primary-key', kind: 'shape', text: `The primary key of ${name} is (${oneLine(primary[1])}).`, refs: [source(file, line)] });
  }
  for (const match of body.matchAll(/CREATE INDEX IF NOT EXISTS (\w+) ON (\w+)\(([^)]+)\)(\s*WHERE ([^;]+))?;/g)) {
    const [, name, table, columns, , where] = match;
    const line = body.slice(0, match.index).split('\n').length;
    fact(`Dossier/Store/table ${table}`, { key: `index.${name}`, kind: 'shape', text: `Index ${name} covers ${table}(${oneLine(columns)})${where ? ` for rows where ${oneLine(where)}` : ''}.`, refs: [source(file, line)] });
  }
  const triggerLine = lineOf(file, 'foreach (var table in new[] { "facts", "subjects", "refs", "slots" })', 'store');
  fact('Dossier/Store', { key: 'triggers', text: 'Twelve triggers, one per insert, update and delete on facts, subjects, refs and slots, bump meta.revision and write the change journal row under that same number.', data: { triggers: 12 }, refs: [source(file, triggerLine), source(file, lineOf(file, 'CREATE TRIGGER trg_{table}_{name}', 'store'))] });
  fact('Dossier/Store', { key: 'pragmas', text: 'Every connection is opened with journal_mode=WAL, busy_timeout=5000 and foreign_keys=ON.', refs: [source(file, lineOf(file, 'PRAGMA journal_mode=WAL', 'store'))] });
  fact('Dossier/Store', { key: 'location', text: 'The database path is the constructor argument, else the DOSSIER_DB environment variable, else ./dossier.db, and attachment files live in blobs/<sha256> next to it.', refs: [source(file, lineOf(file, 'Environment.GetEnvironmentVariable("DOSSIER_DB")', 'store')), source(file, lineOf(file, 'BlobRoot = Path.Combine', 'store'))] });
}

function extractErrors() {
  const codes = new Map();
  for (const file of tracked.filter((name) => /^src\/Dossier\/[^/]+\.cs$/.test(name))) {
    const body = linesOf(file).join('\n');
    const pattern = /(?:new DossierRequestException\(|new PostError\(\s*index,|ErrorEnvelope\.Of\(|new McpException\(\s*-?\d+,)\s*"([a-z][a-z_]+)"/g;
    for (let match; (match = pattern.exec(body));) {
      const line = body.slice(0, match.index).split('\n').length;
      if (!codes.has(match[1])) codes.set(match[1], []);
      codes.get(match[1]).push({ file, line });
    }
  }
  const sorted = [...codes.keys()].sort();
  fact('Dossier/Errors', { key: 'count', text: `The source raises ${sorted.length} distinct machine-readable error codes.`, data: { codes: sorted.length }, refs: [source('src/Dossier/Models.cs', lineOf('src/Dossier/Models.cs', 'public sealed class DossierRequestException', 'errors'))] });
  for (const code of sorted) {
    const sites = codes.get(code);
    const files = [...new Set(sites.map((site) => path.posix.basename(site.file)))];
    fact('Dossier/Errors', {
      key: code, kind: 'error-code', text: `Error code ${code} is raised at ${sites.length} site(s), in ${files.join(', ')}.`, data: { sites: { [code]: sites.length } },
      refs: [...sites.slice(0, 6).map((site) => source(site.file, site.line)), ...files.map((base) => ({ rel: 'about', subject: `src/Dossier/${base}` }))],
    });
  }
}

function extractTests() {
  let total = 0;
  let cases = 0;
  const files = tracked.filter((name) => /^tests\/Dossier\.Tests\/[^/]+\.cs$/.test(name));
  for (const file of files) {
    const lines = linesOf(file);
    const base = path.posix.basename(file);
    const tests = [];
    lines.forEach((line, index) => {
      if (!/^\s*\[Test\]/.test(line)) return;
      let cursor = index + 1;
      let variants = 0;
      while (cursor < lines.length && /^\s*\[/.test(lines[cursor])) { if (/\[Arguments\(/.test(lines[cursor])) variants++; cursor++; }
      const name = /\b(\w+)\s*\(/.exec(lines[cursor] ?? '');
      if (name) tests.push({ name: name[1], line: cursor + 1, cases: Math.max(1, variants) });
    });
    if (tests.length === 0) continue;
    subject(file, 'test-file', 'Dossier/Tests', [base]);
    const classLine = lines.findIndex((line) => /^(?:public|internal)\s+(?:sealed\s+|static\s+)?class\s+\w+/.test(line));
    docFacts(file, classLine >= 0 ? summaryAbove(lines, classLine) : null, file, classLine + 1);
    const fileCases = tests.reduce((sum, test) => sum + test.cases, 0);
    total += tests.length;
    cases += fileCases;
    const target = `src/Dossier/${base.replace(/Tests\.cs$/, '.cs')}`;
    fact(file, { key: 'count', kind: 'measure', text: `${base} declares ${tests.length} test method(s) that run as ${fileCases} case(s).`, data: { tests: tests.length, cases: fileCases }, refs: [source(file, tests[0].line), ...(trackedSet.has(target) ? [{ rel: 'about', subject: target }] : [])] });
    for (const test of tests) fact(file, { key: `test.${test.name}`, kind: 'test', text: `Test ${test.name} pins: ${humanize(test.name)}.`, tags: ['test'], refs: [source(file, test.line)] });
  }
  fact('Dossier/Tests', { key: 'total', kind: 'measure', text: `The test project declares ${total} test methods in ${files.length} files, which run as ${cases} cases.`, data: { tests: total, cases, files: files.length }, refs: [source('tests/Dossier.Tests/Dossier.Tests.csproj', 1)] });
}

function extractScripts() {
  for (const file of tracked.filter((name) => /^scripts\/[^/]+\.(?:sh|mjs)$/.test(name) || /^scripts\/self-map\/build\.mjs$/.test(name))) {
    const lines = linesOf(file);
    subject(file, 'script', 'Dossier/Scripts', [path.posix.basename(file)]);
    const header = [];
    let first = 0;
    for (let index = lines[0]?.startsWith('#!') ? 1 : 0; index < lines.length; index++) {
      const comment = /^(?:#|\/\/) ?(.*)$/.exec(lines[index]);
      if (!comment) break;
      if (header.length === 0) first = index + 1;
      if (/^(?:usage:|\s{2,}\S)/i.test(comment[1])) continue;
      header.push(comment[1]);
    }
    const prose = oneLine(header.join(' '));
    if (prose) sentences(prose).forEach((sentence, index) => fact(file, { key: `header.${index + 1}`, kind: 'doc', text: sentence, tags: ['from:header-comment'], refs: [source(file, first)] }));
    else fact(file, { key: 'exists', text: `${file} is a script with no header comment.`, refs: [source(file, 1)] });
  }
}

function extractDocs() {
  const docs = tracked.filter((name) => /^docs\/[^/]+\.md$/.test(name) || ['README.md', 'CONTRIBUTING.md', 'SECURITY.md', 'skills/dossier/SKILL.md'].includes(name));
  for (const file of docs) {
    const lines = linesOf(file);
    subject(file, 'doc', 'Dossier/Docs', [path.posix.basename(file)]);
    const headings = [];
    let fence = false;
    lines.forEach((line, index) => {
      if (/^```/.test(line)) fence = !fence;
      const heading = fence ? null : /^(#{1,3})\s+(.+?)\s*$/.exec(line);
      if (heading) headings.push({ level: heading[1].length, title: heading[2], line: index + 1 });
    });
    fact(file, { key: 'outline', kind: 'measure', text: `${file} has ${headings.length} headings: ${headings.map((heading) => heading.title).join('; ')}.`, data: { headings: headings.length }, refs: [source(file, headings[0]?.line ?? 1)] });
    for (const heading of headings.filter((entry) => entry.level === 2)) {
      const slug = heading.title.toLowerCase().replace(/[^a-z0-9]+/g, '-').replace(/^-|-$/g, '');
      fact(file, { key: `section.${slug}`, kind: 'section', text: `${file} has a section "${heading.title}".`, refs: [source(file, heading.line)] });
    }
  }
}

function extractCi() {
  for (const file of tracked.filter((name) => /^\.github\/workflows\/.+\.yml$/.test(name))) {
    const lines = linesOf(file);
    subject(file, 'workflow', 'Dossier/CI', [path.posix.basename(file)]);
    let inJobs = false;
    lines.forEach((line, index) => {
      if (/^jobs:/.test(line)) { inJobs = true; return; }
      if (inJobs && /^\S/.test(line)) inJobs = false;
      const job = inJobs ? /^ {2}([\w-]+):\s*$/.exec(line) : null;
      if (!job) return;
      const steps = [];
      for (let cursor = index + 1; cursor < lines.length && !/^ {2}[\w-]+:\s*$/.test(lines[cursor]) && !/^\S/.test(lines[cursor]); cursor++) {
        const step = /^ {6}- name:\s*(.+)$/.exec(lines[cursor]);
        if (step) steps.push(step[1].trim());
      }
      fact(file, { key: `job.${job[1]}`, kind: 'ci-job', text: `Job ${job[1]} in ${path.posix.basename(file)} runs ${steps.length} named step(s): ${steps.join('; ')}.`, data: { steps: { [job[1]]: steps.length } }, refs: [source(file, index + 1)] });
    });
    const named = lines.findIndex((line) => /^name:\s*\S/.test(line));
    fact(file, { key: 'exists', text: `${file} is a GitHub Actions workflow named "${named >= 0 ? /^name:\s*(.+)$/.exec(lines[named])[1].trim() : '?'}".`, refs: [source(file, named >= 0 ? named + 1 : 1)] });
  }
}

function extractDependencies() {
  for (const file of tracked.filter((name) => name.endsWith('.csproj'))) {
    const lines = linesOf(file);
    lines.forEach((line, index) => {
      const reference = /<PackageReference Include="([^"]+)" Version="([^"]+)"/.exec(line);
      if (reference) fact('Dossier/Dependencies', { key: `package.${reference[1]}@${path.posix.basename(file)}`, kind: 'dependency', text: `${path.posix.basename(file)} references the package ${reference[1]} at version ${reference[2]}.`, data: { packages: { [reference[1]]: reference[2] } }, refs: [source(file, index + 1)] });
      const framework = /<TargetFramework>([^<]+)</.exec(line);
      if (framework) fact('Dossier/Dependencies', { key: `framework@${path.posix.basename(file)}`, kind: 'dependency', text: `${path.posix.basename(file)} targets ${framework[1]}.`, data: { target_framework: framework[1] }, refs: [source(file, index + 1)] });
      const version = /<Version>([^<]+)</.exec(line);
      if (version) fact('Dossier', { key: 'version', text: `The product version in ${path.posix.basename(file)} is ${version[1]}.`, data: { version: version[1] }, refs: [source(file, index + 1)] });
    });
  }
  const globalJson = JSON.parse(linesOf('global.json').join('\n'));
  fact('Dossier/Dependencies', { key: 'test-runner', kind: 'dependency', text: `global.json selects ${globalJson.test.runner} as the dotnet test runner.`, refs: [source('global.json', lineOf('global.json', '"runner"', 'deps'))] });
}

function extractGithub() {
  const snapshotPath = path.join(here, 'github.json');
  if (options.refreshGithub || !existsSync(snapshotPath)) {
    const gh = (...args) => {
      const run = spawnSync('gh', args, { cwd: repoRoot, encoding: 'utf8', maxBuffer: 64 * 1024 * 1024 });
      if (run.status !== 0) die(`gh ${args.join(' ')} failed: ${run.stderr.trim()}`);
      return JSON.parse(run.stdout);
    };
    const snapshot = {
      taken_at: new Date().toISOString().slice(0, 10),
      issues: gh('issue', 'list', '--state', 'all', '--limit', '200', '--json', 'number,title,state,labels,createdAt,closedAt,url').sort((a, b) => a.number - b.number),
      pulls: gh('pr', 'list', '--state', 'all', '--limit', '200', '--json', 'number,title,state,baseRefName,headRefName,createdAt,mergedAt,url').sort((a, b) => a.number - b.number),
    };
    writeFileSync(snapshotPath, `${JSON.stringify(snapshot, null, 2)}\n`);
  }
  const snapshot = JSON.parse(readFileSync(snapshotPath, 'utf8'));
  const web = (url) => ({ rel: 'derived_from', kind: 'url', target: url, basis: 'observed', snapshot: `scripts/self-map/github.json taken ${snapshot.taken_at}`, verified_at: `${snapshot.taken_at}T00:00:00Z` });
  subject('Dossier/GitHub/issues', 'tracker', 'Dossier/GitHub');
  subject('Dossier/GitHub/pull requests', 'tracker', 'Dossier/GitHub');
  const open = snapshot.issues.filter((issue) => issue.state === 'OPEN');
  fact('Dossier/GitHub/issues', { key: 'count', kind: 'measure', text: `On ${snapshot.taken_at} the tracker held ${snapshot.issues.length} issues, ${open.length} of them open.`, data: { issues: snapshot.issues.length, open: open.length }, refs: [web(`https://github.com/${REPO}/issues`)] });
  for (const issue of snapshot.issues) {
    fact('Dossier/GitHub/issues', { key: `issue.${issue.number}`, kind: 'issue', text: `Issue #${issue.number} (${issue.state.toLowerCase()}): ${issue.title}`, data: { issues: { [issue.number]: issue.state.toLowerCase() } }, tags: issue.labels.map((label) => `label:${label.name}`), refs: [web(issue.url)] });
  }
  for (const pull of snapshot.pulls) {
    fact('Dossier/GitHub/pull requests', { key: `pr.${pull.number}`, kind: 'pull-request', text: `Pull request #${pull.number} (${pull.state.toLowerCase()}): ${pull.title} [${pull.headRefName} into ${pull.baseRefName}]`, data: { pulls: { [pull.number]: { state: pull.state.toLowerCase(), base: pull.baseRefName } } }, refs: [web(pull.url)] });
  }
}

/** Every tracked file the extractors above did not claim still gets a subject, so nothing in the tree is unmapped. */
function extractRemainingFiles() {
  const areaOf = (file) => {
    if (file.startsWith('src/')) return 'Dossier/Source';
    if (file.startsWith('tests/')) return 'Dossier/Tests';
    if (file.startsWith('scripts/')) return 'Dossier/Scripts';
    if (file.startsWith('tools/')) return 'Dossier/Tools';
    if (file.startsWith('examples/')) return 'Dossier/Examples';
    if (file.startsWith('profiles/')) return 'Dossier/Profiles';
    if (file.startsWith('contract/')) return 'Dossier/Contract';
    if (file.startsWith('.github/')) return 'Dossier/CI';
    if (file.startsWith('docs/') || file.startsWith('skills/')) return 'Dossier/Docs';
    return 'Dossier/Repository';
  };
  const aliases = new Set([...subjects.values()].flatMap((owner) => owner.aliases.map((alias) => alias.toLowerCase())));
  const bundle = tracked.filter((file) => file.startsWith('examples/memos-bundle/'));
  let added = 0;
  for (const file of tracked) {
    if (subjects.has(file.toLowerCase())) continue;
    if (file.startsWith('examples/memos-bundle/subjects/')) continue;
    const base = path.posix.basename(file);
    const alias = aliases.has(base.toLowerCase()) ? [] : [base];
    aliases.add(base.toLowerCase());
    subject(file, 'file', areaOf(file), alias);
    added++;
    if (/\.(?:png|jpg|gif|ico)$/.test(file)) {
      fact(file, { key: 'size', kind: 'measure', text: `${file} is a tracked binary file.`, refs: [source(file)] });
      continue;
    }
    const lines = linesOf(file);
    const count = lines.length - (lines[lines.length - 1] === '' ? 1 : 0);
    fact(file, { key: 'size', kind: 'measure', text: `${file} is ${count} lines long at this commit.`, data: { lines: count }, refs: [source(file, 1)] });
  }
  if (bundle.length > 0) {
    subject('examples/memos-bundle', 'example', 'Dossier/Examples', ['memos-bundle']);
    const facts = bundle.filter((file) => /\/facts\/[^/]+\.md$/.test(file)).length;
    fact('examples/memos-bundle', { key: 'files', kind: 'measure', text: `The committed example bundle examples/memos-bundle holds ${bundle.length} files, ${facts} of them fact files.`, data: { files: bundle.length, fact_files: facts }, refs: [source('examples/memos-bundle/manifest.json', 1)] });
  }
  fact('Dossier', { key: 'tracked-files', kind: 'measure', text: `The repository tracks ${tracked.length} files at this commit, and every one outside the example bundle's subject folders has its own subject in this map.`, data: { tracked_files: tracked.length, file_subjects_added: added }, refs: [source('README.md', 1)] });
}

// ---- written knowledge -------------------------------------------------------------------------

/**
 * Loads written facts. scripts/self-map/knowledge/*.json is the hand-written layer; scripts/self-map/
 * swarm/*.json holds what delegated agents submitted through agent.mjs, each file under its own agent
 * name, replayed here in the order it was accepted so a rebuild gives the same graph.
 */
const swarmCounts = new Map();
let ambiguousCitations = 0;
function loadWritten(directory, defaultAgent, extraTag, swarm = false) {
  if (!existsSync(directory)) return;
  for (const name of readdirSync(directory).filter((entry) => entry.endsWith('.json')).sort()) {
    let document;
    try {
      document = JSON.parse(readFileSync(path.join(directory, name), 'utf8'));
    } catch (error) {
      problems.push(`${name}: ${error.message}`);
      continue;
    }
    const agent = document.agent ?? defaultAgent;
    for (const entry of document.subjects ?? []) {
      subject(entry.name, entry.kind ?? 'topic', entry.parent ?? null, entry.aliases ?? []);
      for (const item of entry.facts ?? []) {
        const context = `${name} ${entry.name}#${item.key}`;
        const cites = (Array.isArray(item.at?.[0]) ? item.at : item.at ? [item.at] : []);
        if (cites.length === 0 && !item.said) problems.push(`${context}: a written fact needs "at": [file, phrase]`);
        const refs = cites.map(([file, phrase]) => {
          const line = lineOf(file, phrase, context);
          return line ? source(file, line) : null;
        }).filter(Boolean);
        if (item.said) refs.push({ rel: 'derived_from', kind: 'conversation', target: item.said, basis: 'observed' });
        for (const link of item.refs ?? []) refs.push(link);
        if (swarm) {
          // A swarm fact on a symbol or a test still points at the file it was read from, so it is an edge, not an island.
          for (const [file] of cites) {
            const linked = refs.some((reference) => reference.subject?.toLowerCase() === file.toLowerCase());
            if (!linked && subjects.has(file.toLowerCase()) && file.toLowerCase() !== entry.name.toLowerCase()) refs.push({ rel: 'about', subject: file });
          }
          swarmCounts.set(agent, (swarmCounts.get(agent) ?? 0) + 1);
          if (cites.some(([file, phrase]) => trackedSet.has(file) && linesOf(file).filter((line) => line.includes(phrase)).length > 1)) ambiguousCitations++;
        }
        // Two agents share a subject when a long file is split between them; the later file's key gets its agent's name.
        const owner = subjects.get(entry.name.toLowerCase());
        const key = swarm && owner?.keys.has(item.key) ? `${item.key}.${agent.replace(/^swarm-/, '')}` : item.key;
        fact(entry.name, { key, kind: item.kind ?? 'claim', text: item.text, data: item.data, items: item.items, tags: [...(item.tags ?? []), extraTag], confidence: item.confidence ?? (swarm ? 0.8 : undefined), refs, agent });
      }
    }
  }
}

/** How this map was made, as facts in it: the layers, who wrote each, and what was checked. */
function describeSelf() {
  const tool = (file) => ({ rel: 'derived_from', kind: 'tool', target: `${REPO}/${file}`, basis: 'derived' });
  subject('Dossier/Self-map', 'topic', 'Dossier', ['self-map']);
  const layer = (agent) => [...subjects.values()].reduce((sum, owner) => sum + owner.facts.filter((entry) => entry.agent === agent).length, 0);
  const swarmTotal = [...swarmCounts.values()].reduce((sum, count) => sum + count, 0);
  fact('Dossier/Self-map', { key: 'pinned-commit', agent: AUTHOR, text: `This map describes the repository at commit ${rev}; every git ref in it is pinned to that commit with a permalink and the blob hash.`, data: { commit: rev }, refs: [tool('scripts/self-map/build.mjs')] });
  fact('Dossier/Self-map', { key: 'layers', agent: AUTHOR, text: `Outside this subject the map has three layers told apart by actor: ${layer(EXTRACTOR)} facts extracted by parsers, ${layer(AUTHOR)} written by hand, and ${swarmTotal} submitted by ${swarmCounts.size} delegated agents.`, data: { extracted: layer(EXTRACTOR), written: layer(AUTHOR), swarm: swarmTotal, swarm_agents: swarmCounts.size }, refs: [tool('scripts/self-map/build.mjs')] });
  fact('Dossier/Self-map', { key: 'citation-rule', agent: AUTHOR, text: 'A written or swarm fact is accepted only when the phrase it cites occurs in the cited file at the pinned commit, and the build fails otherwise.', refs: [tool('scripts/self-map/build.mjs')] });
  const slicesPath = path.join(here, 'slices.json');
  const slices = existsSync(slicesPath) ? JSON.parse(readFileSync(slicesPath, 'utf8')) : null;
  const auditPath = path.join(here, 'audit.json');
  const audit = existsSync(auditPath) ? JSON.parse(readFileSync(auditPath, 'utf8')) : null;
  if (swarmCounts.size === 0 || !slices) return;
  // audit.json lists the swarm facts a person read next to their cited lines, and what they found.
  const audited = new Map();
  for (const item of audit?.facts ?? []) {
    const owner = subjects.get(String(item.subject).toLowerCase());
    const suffixed = `${item.key}.${String(item.agent).replace(/^swarm-/, '')}`;
    if (!owner?.facts.some((entry) => entry.agent === item.agent && (entry.key === item.key || entry.key === suffixed))) problems.push(`audit.json names ${item.subject}#${item.key}, which ${item.agent} did not submit`);
    const seen = audited.get(item.agent) ?? { sampled: 0, wrong: 0 };
    seen.sampled++;
    if (item.verdict !== 'held') seen.wrong++;
    audited.set(item.agent, seen);
  }
  const auditTotal = [...audited.values()].reduce((sum, seen) => ({ sampled: sum.sampled + seen.sampled, wrong: sum.wrong + seen.wrong }), { sampled: 0, wrong: 0 });
  fact('Dossier/Self-map', { key: 'swarm-rule', agent: AUTHOR, text: 'A swarm fact is accepted only when its citation lies inside the agent\'s own slice, its numbers appear near the cited line, its identifiers appear in the slice, and it is not a near duplicate.', refs: [tool('scripts/self-map/agent.mjs')] });
  fact('Dossier/Self-map', { key: 'swarm-limit', agent: AUTHOR, text: 'The swarm checks are mechanical: they cannot tell a true claim from a false one that reuses the right words, so an unaudited swarm fact is a lead to confirm at its cited line, and each carries confidence 0.8.', refs: [tool('scripts/self-map/agent.mjs')] });
  fact('Dossier/Self-map', { key: 'ambiguous-citations', kind: 'measure', agent: AUTHOR, text: `${ambiguousCitations} of ${swarmTotal} swarm facts cite a phrase that occurs on more than one line of its file; their ref points at the first occurrence, which may not be the line the agent read.`, data: { ambiguous_citations: ambiguousCitations }, refs: [tool('scripts/self-map/build.mjs')] });
  for (const [agent, count] of [...swarmCounts.entries()].sort()) {
    const slice = slices.slices[agent.replace(/^swarm-/, '')];
    const checked = audited.get(agent);
    const files = (slice?.files ?? []).map((entry) => entry.split(':')[0]);
    fact('Dossier/Self-map', {
      key: `agent.${agent}`, kind: 'measure', agent: AUTHOR,
      text: `Agent ${agent} (${slices.model}, ${slices.variant}) read ${files.length} file(s) and has ${count} facts in the map${checked ? `; ${checked.sampled - checked.wrong} of ${checked.sampled} audited facts held at their cited lines` : ''}.`,
      data: { agents: { [agent]: { facts: count, files: files.length, ...(checked ? { audited: checked.sampled, audit_wrong: checked.wrong } : {}) } } },
      refs: [tool(`scripts/self-map/swarm/${agent}.json`), ...files.filter((file) => subjects.has(file.toLowerCase())).map((file) => ({ rel: 'about', subject: file }))],
    });
  }
  if (audit) fact('Dossier/Self-map', { key: 'audit', agent: AUTHOR, text: `The author read ${auditTotal.sampled} swarm facts next to their cited lines, a fixed hash-ordered sample of every agent: ${auditTotal.sampled - auditTotal.wrong} held, and ${auditTotal.wrong} did not and were corrected by superseding facts; the rest of the swarm layer is unaudited.`, data: { audited: auditTotal.sampled, audit_wrong: auditTotal.wrong }, confidence: 1, refs: [tool('scripts/self-map/audit.json')] });
}

/** Two facts on one subject that give different values for the same data path: what compile will list as a conflict. */
function plannedConflicts() {
  const flatten = (value, prefix, out) => {
    if (value !== null && typeof value === 'object') {
      for (const [key, inner] of Object.entries(value)) flatten(inner, Array.isArray(value) || prefix ? `${prefix}.${key}` : key, out);
    } else if (prefix) out.push([prefix, JSON.stringify(value)]);
    return out;
  };
  const found = [];
  for (const owner of subjects.values()) {
    const byPath = new Map();
    for (const entry of owner.facts) {
      if (entry.data === undefined || entry.data === null || typeof entry.data !== 'object' || Array.isArray(entry.data)) continue;
      for (const [field, value] of flatten(entry.data, '', [])) {
        if (!byPath.has(field)) byPath.set(field, new Map());
        byPath.get(field).set(entry.key, value);
      }
    }
    for (const [field, values] of byPath) if (new Set(values.values()).size > 1) found.push(`${owner.name} # ${field}: ${[...values.entries()].map(([key, value]) => `${key}=${value}`).join(' vs ')}`);
  }
  return found;
}

// ---- build the plan ----------------------------------------------------------------------------

extractProject();
extractSource();
extractCli();
extractMcp();
extractContract();
extractStore();
extractErrors();
extractTests();
extractScripts();
extractDocs();
extractCi();
extractDependencies();
extractGithub();
extractRemainingFiles();
loadWritten(path.join(here, 'knowledge'), AUTHOR, 'written');
if (options.swarm) loadWritten(path.join(here, 'swarm'), 'swarm', 'swarm', true);
describeSelf();

// Symbolic refs must name something that exists.
const factIndex = new Map();
for (const owner of subjects.values()) for (const entry of owner.facts) factIndex.set(`${owner.name.toLowerCase()}#${entry.key}`, { owner, entry });
for (const owner of subjects.values()) {
  if (owner.parent && !subjects.has(owner.parent.toLowerCase())) problems.push(`subject "${owner.name}" has unknown parent "${owner.parent}"`);
  for (const entry of owner.facts) {
    for (const reference of entry.refs) {
      if (reference.subject && !subjects.has(reference.subject.toLowerCase())) problems.push(`${owner.name}#${entry.key}: ref to unknown subject "${reference.subject}"`);
      if (reference.fact && !factIndex.has(`${reference.fact[0].toLowerCase()}#${reference.fact[1]}`)) problems.push(`${owner.name}#${entry.key}: ref to unknown fact ${reference.fact[0]}#${reference.fact[1]}`);
    }
  }
}

const totalFacts = [...subjects.values()].reduce((sum, owner) => sum + owner.facts.length, 0);
console.log(`self-map  commit ${rev.slice(0, 12)}  ${subjects.size} subjects, ${totalFacts} facts planned`);
if (problems.length > 0) {
  for (const problem of problems.slice(0, 60)) console.error(`REJECTED ${problem}`);
  if (problems.length > 60) console.error(`... and ${problems.length - 60} more`);
  process.exit(1);
}

if (options.plan) {
  if (process.env.SELF_MAP_PLAN_OUT) {
    writeFileSync(process.env.SELF_MAP_PLAN_OUT, JSON.stringify([...subjects.values()].map((owner) => ({ name: owner.name, kind: owner.kind, parent: owner.parent, aliases: owner.aliases, files: [...new Set(owner.facts.flatMap((entry) => entry.refs.filter((reference) => reference.kind === 'git').map((reference) => reference.target.slice(REPO.length + 1))))], facts: owner.facts.map((entry) => ({ key: entry.key, kind: entry.kind, text: entry.text })) })), null, 1));
  }
  const conflicts = plannedConflicts();
  console.log(`${conflicts.length} data conflict(s) planned`);
  for (const conflict of conflicts) console.log(`  CONFLICT ${conflict.slice(0, 220)}`);
  const byKind = new Map();
  for (const owner of subjects.values()) byKind.set(owner.kind, (byKind.get(owner.kind) ?? 0) + 1);
  console.log([...byKind.entries()].sort((a, b) => b[1] - a[1]).map(([kind, count]) => `${kind}=${count}`).join(' '));
  process.exit(0);
}

// ---- post through the CLI ----------------------------------------------------------------------

const dll = process.env.DOSSIER_BIN ? path.resolve(process.env.DOSSIER_BIN) : path.join(repoRoot, 'src/Dossier/bin/Release/net10.0/Dossier.dll');
if (!existsSync(dll)) die(`no build at ${dll}; run dotnet build -c Release or set DOSSIER_BIN`);
const scratch = mkdtempSync(path.join(tmpdir(), 'dossier-self-map-'));
const dbPath = options.db ?? path.join(scratch, 'dossier.db');
if (existsSync(dbPath)) die(`${dbPath} already exists; the self-map is built into a new database`);
mkdirSync(path.dirname(dbPath), { recursive: true });

const store = dossierAt(dll, dbPath);
const dossier = (args, input, cwd) => store.cli(args, input, cwd);

function post(request, agent = EXTRACTOR) {
  try {
    return store.post(agent, request);
  } catch (error) {
    return die(error.message, 1);
  }
}

if (dossier(['init']).status !== 0) die('dossier init failed');

// Subjects first, parents before children, so every parent id and every subject ref resolves.
const subjectIds = new Map();
const pending = [...subjects.values()];
for (let guard = 0; pending.length > 0 && guard < 50; guard++) {
  for (const owner of [...pending]) {
    if (owner.parent && !subjectIds.has(owner.parent.toLowerCase())) continue;
    const input = { name: owner.name, kind: owner.kind };
    if (owner.parent) input.parent = subjectIds.get(owner.parent.toLowerCase());
    if (owner.aliases.length > 0) input.aliases = owner.aliases;
    subjectIds.set(owner.name.toLowerCase(), post({ subject: input, facts: [] }).subject.id);
    pending.splice(pending.indexOf(owner), 1);
  }
}
if (pending.length > 0) die(`subject parents form a cycle: ${pending.map((owner) => owner.name).join(', ')}`, 1);

// Facts in waves: a fact is posted once every fact it refers to has an id.
const factIds = new Map();
const waiting = [];
for (const owner of subjects.values()) for (const entry of owner.facts) waiting.push({ owner, entry });
let posted = 0;
let waves = 0;
while (waiting.length > 0) {
  const ready = waiting.filter(({ entry }) => entry.refs.every((reference) => !reference.fact || factIds.has(`${reference.fact[0].toLowerCase()}#${reference.fact[1]}`)));
  if (ready.length === 0) die(`fact refs form a cycle, starting at ${waiting[0].owner.name}#${waiting[0].entry.key}`, 1);
  const groups = new Map();
  for (const item of ready) {
    const group = `${item.owner.name.toLowerCase()}\u0000${item.entry.agent}`;
    if (!groups.has(group)) groups.set(group, { owner: item.owner, agent: item.entry.agent, entries: [] });
    groups.get(group).entries.push(item.entry);
  }
  for (const { owner, agent, entries } of groups.values()) {
    const facts = entries.map((entry) => {
      const refs = entry.refs.map((reference) => {
        if (reference.fact) return { rel: reference.rel, kind: 'fact', target: factIds.get(`${reference.fact[0].toLowerCase()}#${reference.fact[1]}`), basis: reference.basis ?? 'derived' };
        if (reference.subject) return { rel: reference.rel, kind: 'subject', target: subjects.get(reference.subject.toLowerCase()).name, basis: reference.basis ?? 'observed' };
        return reference;
      });
      const out = { key: entry.key, kind: entry.kind, text: entry.text, refs };
      if (entry.data !== undefined) out.data = entry.data;
      if (entry.items) out.items = entry.items;
      if (entry.tags?.length) out.tags = entry.tags;
      if (entry.confidence !== undefined) out.confidence = entry.confidence;
      return out;
    });
    const response = post({ subject: { id: subjectIds.get(owner.name.toLowerCase()) }, facts }, agent);
    response.facts.forEach((result, index) => {
      if (result.status !== 'new') die(`${owner.name}#${entries[index].key} was ${result.status}, expected new`, 1);
      factIds.set(`${owner.name.toLowerCase()}#${entries[index].key}`, result.id);
    });
    posted += facts.length;
  }
  for (const item of ready) waiting.splice(waiting.indexOf(item), 1);
  waves++;
}

// The prose itself, by heading, on a separate raw subject per document so it stays searchable
// without crowding the claims. dump stores the source path as given, so each document is written
// under its repository path and dumped from there: the file ref reads docs/cli.md, not a temp path.
let dumped = 0;
const working = mkdtempSync(path.join(tmpdir(), 'dossier-self-map-docs-'));
for (const owner of [...subjects.values()].filter((entry) => entry.kind === 'doc')) {
  const copy = path.join(working, owner.name);
  mkdirSync(path.dirname(copy), { recursive: true });
  writeFileSync(copy, linesOf(owner.name).join('\n'));
  const rawName = `${owner.name}/raw`;
  post({ subject: { name: rawName, kind: 'raw', parent: subjectIds.get(owner.name.toLowerCase()) }, facts: [] });
  const run = dossier(['dump', '--source', owner.name, '--subject', rawName, '--split', 'heading', '--tag', 'raw'], undefined, working);
  if (run.status !== 0) die(`dump failed for ${owner.name}: ${run.err.trim()}`, 1);
  const manifest = JSON.parse(run.out);
  if (manifest.errors.length > 0) die(`dump of ${owner.name} reported ${manifest.errors[0]}`, 1);
  dumped += manifest.created.length;
}
rmSync(working, { recursive: true, force: true });

const summary = { commit: rev, database: dbPath, binary: dll, subjects: subjects.size, facts: posted, waves, dumped_sections: dumped };
console.log(`posted ${posted} facts on ${subjects.size} subjects in ${waves} wave(s); dumped ${dumped} document sections`);
console.log(`database ${dbPath}`);
writeFileSync(path.join(path.dirname(dbPath), 'self-map.json'), `${JSON.stringify(summary, null, 2)}\n`);

if (options.out) {
  const run = dossier(['publish', '--out', options.out, '--format', 'jsonl', '--assets', 'none']);
  if (run.status !== 0) die(`publish failed: ${run.err.trim()}`, 1);
  console.log(`published ${options.out}: ${run.out.trim()}`);
}
