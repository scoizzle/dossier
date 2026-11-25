#!/usr/bin/env node
// How a delegated agent adds to the self-map. Each agent owns one slice of the repository
// (scripts/self-map/slices.json) and submits one-claim facts about it; what passes is appended to
// scripts/self-map/swarm/swarm-<slice>.json, which build.mjs replays under that agent's name.
//
//   node scripts/self-map/agent.mjs brief  --agent <slice>            what to read and what is already recorded
//   node scripts/self-map/agent.mjs submit --agent <slice> --file <drafts.json>
//   node scripts/self-map/agent.mjs status [--agent <slice>]          accepted facts per agent
//   node scripts/self-map/agent.mjs sample --per <n> [--list 1]       facts to audit, with their cited lines
//   node scripts/self-map/agent.mjs drop   --agent <slice> --subject <name> --key <key>
//
// A fact is accepted only when it can be checked mechanically against the pinned commit:
//   - its citation is a phrase that occurs in a file, and at lines, inside the agent's own slice;
//   - every number in its text occurs within 25 lines of the cited line;
//   - every identifier in its text occurs in the slice;
//   - it is one sentence of at most 240 characters, under a key not already used on its subject;
//   - it is not a near duplicate of a fact already on that subject.
// These checks cannot tell a true claim from a false one that reuses the right words, which is why
// `sample` exists: a person reads a sample of every agent's facts against the cited lines.
// No dependencies, Node 18+. Exit codes: 0 ok, 1 something was rejected, 2 usage or setup error.

import { spawnSync } from 'node:child_process';
import { createHash } from 'node:crypto';
import { existsSync, mkdirSync, readFileSync, readdirSync, renameSync, writeFileSync } from 'node:fs';
import path from 'node:path';
import { die, here, oneLine, repoAt, repoRoot } from './lib.mjs';

const MAX_TEXT = 240;
const MIN_TEXT = 30;
const MIN_PHRASE = 12;
const NUMBER_WINDOW = 25;
const NEAR = 0.8;
const BROAD_KINDS = new Set(['area', 'project', 'topic', 'concept', 'tracker', 'paper']);
const NEW_KINDS = new Set(['method', 'function', 'type', 'test', 'section', 'step', 'job', 'component', 'query', 'option', 'file-part']);
const KNOWN_WORDS = new Set(['SQLite', 'GitHub', 'JavaScript', 'TypeScript', 'DossierStore', 'NuGet', 'MSBuild', 'macOS', 'JsonRpc', 'PowerShell', 'OpenCode', 'WebKit', 'DevTools']);

const [command, ...rest] = process.argv.slice(2);
const flags = {};
for (let index = 0; index < rest.length; index++) {
  if (!rest[index].startsWith('--')) die(`unexpected argument: ${rest[index]}`);
  flags[rest[index].slice(2)] = rest[++index] ?? die(`${rest[index - 1]} needs a value`);
}

const slicesPath = path.join(here, 'slices.json');
if (!existsSync(slicesPath)) die('scripts/self-map/slices.json is missing');
const config = JSON.parse(readFileSync(slicesPath, 'utf8'));
const repo = repoAt(config.rev);
const swarmDir = path.join(here, 'swarm');
const planPath = path.join(repoRoot, 'out', 'self-map', 'plan.json');

function loadPlan() {
  if (!existsSync(planPath)) {
    mkdirSync(path.dirname(planPath), { recursive: true });
    const run = spawnSync('node', [path.join(here, 'build.mjs'), '--plan', '--no-swarm', '--rev', config.rev], { env: { ...process.env, SELF_MAP_PLAN_OUT: planPath }, encoding: 'utf8' });
    if (run.status !== 0) die(`could not plan the base map: ${run.stderr.trim()}`);
  }
  const plan = new Map();
  for (const entry of JSON.parse(readFileSync(planPath, 'utf8'))) plan.set(entry.name.toLowerCase(), entry);
  return plan;
}

function sliceOf(id) {
  const slice = config.slices[id];
  if (!slice) die(`unknown slice "${id}"; one of: ${Object.keys(config.slices).join(', ')}`);
  const parts = slice.files.map((entry) => {
    const [file, range] = entry.split(':');
    const total = repo.linesOf(file).length;
    const [start, end] = range ? range.split('-').map(Number) : [1, total];
    return { file, start, end: Math.min(end, total) };
  });
  return { id, agent: `swarm-${id}`, title: slice.title, focus: slice.focus, parts, files: new Set(parts.map((part) => part.file)) };
}

function swarmPath(agent) {
  return path.join(swarmDir, `${agent}.json`);
}

/** Written whole and renamed into place, because other agents read these files while they submit. */
function save(agent, document) {
  const temporary = `${swarmPath(agent)}.${process.pid}.tmp`;
  writeFileSync(temporary, `${JSON.stringify(document, null, 1)}\n`);
  renameSync(temporary, swarmPath(agent));
}

function loadSwarm() {
  const documents = new Map();
  if (!existsSync(swarmDir)) return documents;
  for (const name of readdirSync(swarmDir).filter((entry) => entry.endsWith('.json')).sort()) {
    const document = JSON.parse(readFileSync(path.join(swarmDir, name), 'utf8'));
    documents.set(document.agent, document);
  }
  return documents;
}

function tokens(text) {
  return new Set(text.toLowerCase().match(/[a-z0-9_]{3,}/g) ?? []);
}

function similarity(a, b) {
  const left = tokens(a);
  const right = tokens(b);
  let shared = 0;
  for (const token of left) if (right.has(token)) shared++;
  const union = left.size + right.size - shared;
  return union === 0 ? 0 : shared / union;
}

function sentenceCount(text) {
  return text.split(/(?<=[.!?])\s+(?=[A-Z"`(\[])/).filter((part) => !/(?:\b(?:e\.g|i\.e|etc|vs)\.)$/.test(part)).length;
}

function owns(slice, entry) {
  if (slice.files.has(entry.name)) return true;
  if (BROAD_KINDS.has(entry.kind) || (entry.files ?? []).length > 3) return false;
  return (entry.files ?? []).some((file) => slice.files.has(file));
}

// ---- brief -------------------------------------------------------------------------------------

function brief() {
  const slice = sliceOf(flags.agent ?? die('brief needs --agent <slice>'));
  const plan = loadPlan();
  console.log(`# Slice ${slice.id}: ${slice.title}`);
  console.log(`Pinned commit ${repo.rev}. Your agent name is ${slice.agent}.`);
  console.log(`\n## Read these, completely (your citations must come from them)`);
  for (const part of slice.parts) console.log(`- ${part.file} lines ${part.start}-${part.end}`);
  console.log(`\n## What to capture\n${slice.focus}`);
  console.log(`\n## Subjects you may add facts to, and what is already recorded on each`);
  console.log('Do not repeat what is recorded. A near duplicate is rejected.');
  for (const entry of plan.values()) {
    if (!owns(slice, entry)) continue;
    console.log(`\n### ${entry.name}  (${entry.kind})`);
    for (const fact of entry.facts.slice(0, 80)) console.log(`  ${fact.key}: ${fact.text.slice(0, 110)}`);
    if (entry.facts.length > 80) console.log(`  ... and ${entry.facts.length - 80} more`);
  }
  const mine = loadSwarm().get(slice.agent);
  if (mine) {
    console.log('\n## Already accepted from you');
    for (const entry of mine.subjects) for (const fact of entry.facts) console.log(`  ${entry.name}#${fact.key}`);
  }
  console.log(`\n## Subjects you may point at with "about" (any existing subject name works; these are the most useful)`);
  console.log([...plan.values()].filter((entry) => ['concept', 'cli-verb', 'mcp-tool', 'component', 'table', 'schema'].includes(entry.kind)).map((entry) => entry.name).join(' | '));
  console.log(`
## Draft file format
{"subjects":[
  {"name":"<an existing subject from the list above, exactly>",
   "facts":[
     {"key":"short-stable-key","text":"One sentence, one checkable claim, at most ${MAX_TEXT} characters.",
      "at":["<file in your slice>","<a phrase of at least ${MIN_PHRASE} characters copied exactly from ONE line of that file>"],
      "data":{"optional_number_or_name":123},
      "about":["<optional: name of another existing subject this fact is about>"]}
   ]},
  {"name":"<file>::<FunctionOrTestName>","kind":"method|function|type|test|section|step|job|component|query|option",
   "parent":"<an existing subject from the list above>","facts":[ ... ]}
]}

## Rules the submit command enforces
- "at" must be [file, phrase]: the phrase occurs on one line of that file, inside your line range.
- Every number in "text" must occur within ${NUMBER_WINDOW} lines of the cited line. Write numbers as the source writes them,
  and do not state a count you tallied yourself.
- Every identifier in "text" (CamelCase, snake_case, --flag) must occur in your files, spelled the same.
- One sentence. ${MIN_TEXT} to ${MAX_TEXT} characters. No markdown, no backticks.
- Keys match [a-z0-9][a-z0-9._-]* and are unique on their subject.
- A rejected fact is fixed by re-reading the source and citing the line that proves it, or it is dropped.
  Never reword a claim just to get past a check.`);
}

// ---- submit ------------------------------------------------------------------------------------

function submit() {
  const slice = sliceOf(flags.agent ?? die('submit needs --agent <slice>'));
  const file = flags.file ?? die('submit needs --file <drafts.json>');
  let draft;
  try {
    draft = JSON.parse(readFileSync(path.resolve(file), 'utf8'));
  } catch (error) {
    die(`${file}: ${error.message}`);
  }
  if (!Array.isArray(draft.subjects)) die(`${file}: expected {"subjects":[...]}`);

  const plan = loadPlan();
  const aliases = new Set([...plan.values()].flatMap((entry) => (entry.aliases ?? []).map((alias) => alias.toLowerCase())));
  const swarm = loadSwarm();
  const mine = swarm.get(slice.agent) ?? { agent: slice.agent, slice: slice.id, subjects: [] };
  const others = new Map();
  for (const [agent, document] of swarm) {
    if (agent === slice.agent) continue;
    for (const entry of document.subjects) {
      const seen = others.get(entry.name.toLowerCase()) ?? { agent, facts: [] };
      seen.facts.push(...entry.facts);
      others.set(entry.name.toLowerCase(), seen);
    }
  }
  const mineByName = new Map(mine.subjects.map((entry) => [entry.name.toLowerCase(), entry]));
  const sliceText = slice.parts.map((part) => repo.linesOf(part.file).join('\n')).join('\n');

  const rejected = [];
  let accepted = 0;
  let repeated = 0;

  for (const entry of draft.subjects) {
    const name = typeof entry.name === 'string' ? entry.name.trim() : '';
    const lower = name.toLowerCase();
    const reject = (key, reason) => rejected.push(`${name || '(no name)'}#${key}: ${reason}`);
    if (!name) { reject('-', 'a subject needs a name'); continue; }

    const planned = plan.get(lower);
    let target = mineByName.get(lower);
    if (planned) {
      if (!owns(slice, planned)) { reject('-', `the subject "${planned.name}" is outside your slice; put the fact on one of your subjects and name this one in "about"`); continue; }
    } else if (!target) {
      if (others.has(lower)) { reject('-', `the subject already belongs to ${others.get(lower).agent}`); continue; }
      if (aliases.has(lower)) { reject('-', 'the name is an alias of an existing subject'); continue; }
      if (name.length > 140 || /[\u0000-\u001f]/.test(name)) { reject('-', 'a subject name is one line of at most 140 characters'); continue; }
      if (!NEW_KINDS.has(entry.kind)) { reject('-', `a new subject needs "kind", one of: ${[...NEW_KINDS].join(', ')}`); continue; }
      const parent = typeof entry.parent === 'string' ? entry.parent.toLowerCase() : '';
      const parentPlanned = plan.get(parent);
      if (!(parentPlanned && owns(slice, parentPlanned)) && !mineByName.has(parent)) { reject('-', 'a new subject needs "parent": one of your existing subjects'); continue; }
    }
    const canonical = planned?.name ?? target?.name ?? name;
    const existingFacts = [...(planned?.facts ?? []), ...(target?.facts ?? []), ...(others.get(lower)?.facts ?? [])];
    const usedKeys = new Set(existingFacts.map((fact) => fact.key));
    const acceptedHere = [];

    for (const item of entry.facts ?? []) {
      const key = String(item.key ?? '');
      const text = oneLine(item.text);
      if (!/^[a-z0-9][a-z0-9._-]{1,59}$/.test(key)) { reject(key || '-', 'the key must match [a-z0-9][a-z0-9._-]{1,59}'); continue; }
      const prior = target?.facts.find((fact) => fact.key === key);
      if (prior && oneLine(prior.text) === text) { repeated++; continue; }
      if (usedKeys.has(key)) { reject(key, 'the key is already used on this subject'); continue; }
      if (text.length < MIN_TEXT || text.length > MAX_TEXT) { reject(key, `the text is ${text.length} characters; it must be ${MIN_TEXT} to ${MAX_TEXT}`); continue; }
      if (/[`*]|\]\(/.test(text)) { reject(key, 'the text must be plain: no backticks or markdown'); continue; }
      if (sentenceCount(text) > 1) { reject(key, 'the text must be one sentence holding one claim; split it into separate facts'); continue; }
      if (!Array.isArray(item.at) || item.at.length !== 2 || typeof item.at[0] !== 'string') { reject(key, '"at" must be [file, phrase]'); continue; }
      const [citedFile, phrase] = item.at;
      const part = slice.parts.find((candidate) => candidate.file === citedFile);
      if (!part) { reject(key, `${citedFile} is not in your slice`); continue; }
      if (typeof phrase !== 'string' || phrase.trim().length < MIN_PHRASE) { reject(key, `the cited phrase must be at least ${MIN_PHRASE} characters`); continue; }
      const found = repo.findLine(citedFile, phrase);
      if (found.error) { reject(key, `${found.error} (copy the phrase exactly from one line)`); continue; }
      if (found.line < part.start || found.line > part.end) { reject(key, `the phrase first occurs at line ${found.line}, outside your lines ${part.start}-${part.end}; cite a phrase unique to your lines`); continue; }

      const lines = repo.linesOf(citedFile);
      const window = lines.slice(Math.max(0, found.line - 1 - NUMBER_WINDOW), found.line + NUMBER_WINDOW).join('\n').replace(/(?<=\d)[_,](?=\d)/g, '');
      const numbers = (text.replace(/(?<=\d),(?=\d{3})/g, '').match(/(?<![\w.-])\d+(?:\.\d+)?(?![\w-]|\.\d)/g) ?? []).filter((number) => !canonical.includes(number));
      const missingNumber = numbers.find((number) => !window.includes(number));
      if (missingNumber !== undefined) { reject(key, `the number ${missingNumber} does not occur within ${NUMBER_WINDOW} lines of the cited line ${found.line}`); continue; }
      const identifiers = text.match(/--[a-z][\w-]+|\b[A-Za-z][A-Za-z0-9]*_\w+\b|\b[A-Z][a-z0-9]+(?:[A-Z][a-z0-9]*)+\b|\b[a-z]+[A-Z]\w*\b/g) ?? [];
      const missingIdentifier = identifiers.find((identifier) => !sliceText.includes(identifier) && !canonical.includes(identifier) && !KNOWN_WORDS.has(identifier));
      if (missingIdentifier) { reject(key, `the identifier ${missingIdentifier} does not occur in your files`); continue; }

      const near = [...existingFacts, ...acceptedHere].find((fact) => similarity(fact.text, text) >= NEAR);
      if (near) { reject(key, `near duplicate of ${near.key}: "${near.text.slice(0, 80)}"`); continue; }

      const about = [];
      let badAbout = null;
      for (const other of item.about ?? []) {
        const resolved = plan.get(String(other).toLowerCase())?.name ?? mineByName.get(String(other).toLowerCase())?.name ?? (String(other).toLowerCase() === lower ? null : undefined);
        if (resolved === undefined) { badAbout = other; break; }
        if (resolved && resolved.toLowerCase() !== lower) about.push(resolved);
      }
      if (badAbout !== null) { reject(key, `"about" names "${badAbout}", which is not an existing subject`); continue; }
      if (item.data !== undefined && (typeof item.data !== 'object' || item.data === null || Array.isArray(item.data) || Object.values(item.data).some((value) => value !== null && typeof value === 'object' && !Array.isArray(value)))) { reject(key, '"data" must be a flat object'); continue; }
      const kind = item.kind === undefined ? undefined : String(item.kind);
      if (kind !== undefined && (!/^[a-z][a-z-]{2,19}$/.test(kind) || kind === 'dossier')) { reject(key, 'the kind must be a short lowercase word'); continue; }

      const out = { key, text, at: [citedFile, phrase] };
      if (kind) out.kind = kind;
      if (item.data !== undefined && Object.keys(item.data).length > 0) out.data = item.data;
      if (Array.isArray(item.tags) && item.tags.length > 0) out.tags = item.tags.map(String).filter((tag) => /^[\w:.-]{2,40}$/.test(tag)).slice(0, 6);
      if (about.length > 0) out.refs = [...new Set(about)].map((subject) => ({ rel: 'about', subject }));
      acceptedHere.push(out);
      usedKeys.add(key);
    }

    if (acceptedHere.length === 0) continue;
    if (!target) {
      target = planned ? { name: canonical, kind: planned.kind, parent: planned.parent ?? undefined, aliases: planned.aliases ?? [], facts: [] } : { name, kind: entry.kind, parent: plan.get(entry.parent.toLowerCase())?.name ?? mineByName.get(entry.parent.toLowerCase()).name, facts: [] };
      mine.subjects.push(target);
      mineByName.set(lower, target);
    }
    target.facts.push(...acceptedHere);
    accepted += acceptedHere.length;
  }

  if (accepted > 0) {
    mkdirSync(swarmDir, { recursive: true });
    save(slice.agent, mine);
  }
  const total = mine.subjects.reduce((sum, entry) => sum + entry.facts.length, 0);
  for (const line of rejected) console.log(`REJECTED ${line}`);
  console.log(`${slice.agent}: accepted ${accepted}, rejected ${rejected.length}${repeated ? `, already had ${repeated}` : ''}; ${total} facts accepted in total`);
  process.exit(rejected.length > 0 ? 1 : 0);
}

// ---- status, sample, drop ----------------------------------------------------------------------

function status() {
  const swarm = loadSwarm();
  let all = 0;
  for (const id of Object.keys(config.slices)) {
    if (flags.agent && flags.agent !== id) continue;
    const document = swarm.get(`swarm-${id}`);
    const facts = document ? document.subjects.reduce((sum, entry) => sum + entry.facts.length, 0) : 0;
    all += facts;
    console.log(`${`swarm-${id}`.padEnd(28)} ${String(facts).padStart(4)} facts on ${String(document?.subjects.length ?? 0).padStart(3)} subjects`);
  }
  if (!flags.agent) console.log(`${'total'.padEnd(28)} ${String(all).padStart(4)} facts`);
}

/** A fixed sample of each agent's facts with the lines they cite, for a person to check. */
function sample() {
  const per = Number(flags.per ?? 5);
  const context = Number(flags.context ?? 3);
  const swarm = loadSwarm();
  for (const [agent, document] of swarm) {
    if (flags.agent && `swarm-${flags.agent}` !== agent) continue;
    const facts = document.subjects.flatMap((entry) => entry.facts.map((fact) => ({ subject: entry.name, fact })));
    const picked = facts
      .map((item) => ({ ...item, order: createHash('sha256').update(`${flags.seed ?? '1'}|${agent}|${item.subject}|${item.fact.key}`).digest('hex') }))
      .sort((a, b) => a.order.localeCompare(b.order)).slice(0, per);
    if (flags.list) {
      for (const { subject, fact } of picked) console.log(JSON.stringify({ agent, subject, key: fact.key }));
      continue;
    }
    console.log(`\n================ ${agent}  (${facts.length} facts, ${picked.length} sampled)`);
    for (const { subject, fact } of picked) {
      const [file, phrase] = fact.at;
      const { line } = repo.findLine(file, phrase);
      const lines = repo.linesOf(file);
      console.log(`\n[${subject}#${fact.key}]\n  CLAIM: ${fact.text}${fact.data ? `\n  DATA: ${JSON.stringify(fact.data)}` : ''}\n  ${file}:${line}`);
      for (let index = Math.max(1, line - context); index <= Math.min(lines.length, line + context + 2); index++) console.log(`  ${index === line ? '>' : ' '}${String(index).padStart(5)} ${lines[index - 1].slice(0, 200)}`);
    }
  }
}

function drop() {
  const slice = sliceOf(flags.agent ?? die('drop needs --agent'));
  const document = loadSwarm().get(slice.agent) ?? die(`${slice.agent} has submitted nothing`);
  const entry = document.subjects.find((candidate) => candidate.name.toLowerCase() === String(flags.subject).toLowerCase()) ?? die(`no subject "${flags.subject}"`);
  const before = entry.facts.length;
  entry.facts = entry.facts.filter((fact) => fact.key !== flags.key);
  if (entry.facts.length === before) die(`no fact ${flags.subject}#${flags.key}`);
  save(slice.agent, document);
  console.log(`dropped ${entry.name}#${flags.key}`);
}

switch (command) {
  case 'brief': brief(); break;
  case 'submit': submit(); break;
  case 'status': status(); break;
  case 'sample': sample(); break;
  case 'drop': drop(); break;
  default: die('usage: node scripts/self-map/agent.mjs <brief|submit|status|sample|drop> [--agent <slice>] ...');
}
