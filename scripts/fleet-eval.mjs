#!/usr/bin/env node
// Fleet evaluation: several real `dossier mcp` processes share one database, and the script
// measures what a shared store owes the agents that use it. One experiment per failure mode of
// shared agent memory (contradiction persistence, stale propagation, provenance collapse), plus
// revocation enforcement, derivation currency and idempotent convergence. Everything is
// deterministic: no model is called, so this measures the mechanism, not what an agent does
// with it. No dependencies, Node 18+.
//
//   node scripts/fleet-eval.mjs [--agents 4] [--chains 50] [--facts 100] [--probes 20]
//                               [--seed 1] [--json <path>]
//
// The binary is $DOSSIER_BIN if set, else the Release build output run through `dotnet`.
// Exit codes: 0 every expectation held, 1 an expectation failed, 2 usage or setup error.
// Like live-demo.mjs this file is self-contained, so its small MCP client is its own.

import { spawn, spawnSync } from 'node:child_process';
import { existsSync, mkdtempSync, rmSync, writeFileSync } from 'node:fs';
import { tmpdir } from 'node:os';
import path from 'node:path';
import readline from 'node:readline';
import { fileURLToPath } from 'node:url';

const repoRoot = path.resolve(path.dirname(fileURLToPath(import.meta.url)), '..');

let cleanup = () => {};

function fail(message) {
  console.error(`fleet-eval: ${message}`);
  try { cleanup(); } catch { /* best effort */ }
  process.exit(2);
}

function parseArgs(argv) {
  const options = { agents: 4, chains: 50, facts: 100, probes: 20, seed: 1, json: null };
  for (let index = 0; index < argv.length; index++) {
    const arg = argv[index];
    const next = () => {
      const value = argv[++index];
      if (value === undefined) fail(`${arg} needs a value`);
      return value;
    };
    const positive = (minimum) => {
      const value = Number(next());
      if (!Number.isInteger(value) || value < minimum) fail(`${arg} must be an integer >= ${minimum}`);
      return value;
    };
    switch (arg) {
      case '--agents': options.agents = positive(3); break;
      case '--chains': options.chains = positive(1); break;
      case '--facts': options.facts = positive(1); break;
      case '--probes': options.probes = positive(1); break;
      case '--seed': options.seed = positive(0); break;
      case '--json': options.json = path.resolve(next()); break;
      case '--help': case '-h':
        console.log('usage: node scripts/fleet-eval.mjs [--agents 4] [--chains 50] [--facts 100] [--probes 20] [--seed 1] [--json <path>]');
        process.exit(0);
        break;
      default: fail(`unknown argument: ${arg}`);
    }
  }

  return options;
}

function locateDossier() {
  const spec = (file) => (file.endsWith('.dll')
    ? { label: `dotnet ${path.relative(repoRoot, file)}`, command: 'dotnet', prefix: [file] }
    : { label: file, command: file, prefix: [] });
  if (process.env.DOSSIER_BIN) {
    const explicit = path.resolve(process.env.DOSSIER_BIN);
    if (!existsSync(explicit)) fail(`DOSSIER_BIN does not exist: ${explicit}`);
    return spec(explicit);
  }

  const release = path.join(repoRoot, 'src/Dossier/bin/Release/net10.0/Dossier.dll');
  if (!existsSync(release)) fail('no Release build; run `dotnet build -c Release` or set DOSSIER_BIN');
  return spec(release);
}

/** Deterministic PRNG (mulberry32), so a seed reproduces the plan. */
function prng(seed) {
  let state = seed >>> 0;
  return () => {
    state = (state + 0x6d2b79f5) >>> 0;
    let t = state;
    t = Math.imul(t ^ (t >>> 15), t | 1);
    t ^= t + Math.imul(t ^ (t >>> 7), t | 61);
    return ((t ^ (t >>> 14)) >>> 0) / 4294967296;
  };
}

class Agent {
  constructor(spec, dbPath, name) {
    this.name = name;
    this.nextId = 1;
    this.pending = new Map();
    this.stderr = '';
    this.child = spawn(spec.command, [...spec.prefix, 'mcp'], {
      env: { ...process.env, DOSSIER_DB: dbPath },
      stdio: ['pipe', 'pipe', 'pipe'],
    });
    this.child.stdin.on('error', () => {});
    this.child.stderr.setEncoding('utf8');
    this.child.stderr.on('data', (chunk) => { this.stderr = (this.stderr + chunk).slice(-2000); });
    const die = (reason) => {
      const waiters = [...this.pending.values()];
      this.pending.clear();
      this.dead = reason;
      for (const waiter of waiters) waiter.reject(new Error(reason));
    };
    this.child.on('exit', (code) => die(`${name}: mcp child exited (code=${code}) ${this.stderr.trim()}`));
    this.child.on('error', (error) => die(`${name}: mcp child error: ${error.message}`));
    readline.createInterface({ input: this.child.stdout }).on('line', (line) => {
      if (!line.trim()) return;
      let message;
      try { message = JSON.parse(line); } catch { return; }
      const waiter = this.pending.get(message.id);
      if (!waiter) return;
      this.pending.delete(message.id);
      if (message.error) waiter.reject(new Error(`${message.error.code}: ${message.error.message}`));
      else waiter.resolve(message.result);
    });
  }

  rpc(method, params) {
    if (this.dead) return Promise.reject(new Error(this.dead));
    const id = this.nextId++;
    return new Promise((resolve, reject) => {
      const timer = setTimeout(() => {
        this.pending.delete(id);
        reject(new Error(`${this.name}: ${method} timed out`));
      }, 60_000);
      this.pending.set(id, {
        resolve: (value) => { clearTimeout(timer); resolve(value); },
        reject: (error) => { clearTimeout(timer); reject(error); },
      });
      this.child.stdin.write(`${JSON.stringify({ jsonrpc: '2.0', id, method, params })}\n`);
    });
  }

  initialize() {
    // The client's own name becomes the provenance actor of every fact it posts.
    return this.rpc('initialize', { protocolVersion: '2025-06-18', capabilities: {}, clientInfo: { name: this.name, version: '1' } });
  }

  async tool(name, args) {
    const result = await this.rpc('tools/call', { name, arguments: args });
    const parsed = JSON.parse(result?.content?.[0]?.text ?? '{}');
    if (result.isError) {
      const error = new Error(`${name}: ${parsed?.error?.message ?? 'failed'}`);
      error.code = parsed?.error?.code;
      throw error;
    }
    return parsed;
  }

  /** post_facts for one fact; returns { id, status, replaced, duplicate_of }. A rejected fact throws. */
  async post(subject, fact) {
    const result = await this.tool('post_facts', { subject: { name: subject }, facts: [fact] });
    if (result.errors?.length) throw new Error(`post_facts rejected: ${JSON.stringify(result.errors[0])}`);
    return result.response.facts[0];
  }

  close() {
    try { this.child.stdin.end(); } catch { /* already closed */ }
    try { this.child.kill('SIGTERM'); } catch { /* already gone */ }
  }
}

const derivedFrom = (id) => ({ rel: 'derived_from', kind: 'fact', target: id, basis: 'derived' });

function percentile(samples, p) {
  if (samples.length === 0) return null;
  const sorted = [...samples].sort((a, b) => a - b);
  return sorted[Math.min(sorted.length - 1, Math.max(0, Math.ceil(p * sorted.length) - 1))];
}

/** 95% Wilson score interval for k successes in n trials. */
function wilson(k, n) {
  if (n === 0) return [0, 1];
  const z = 1.959964;
  const p = k / n;
  const denominator = 1 + (z * z) / n;
  const centre = (p + (z * z) / (2 * n)) / denominator;
  const margin = (z * Math.sqrt((p * (1 - p)) / n + (z * z) / (4 * n * n))) / denominator;
  return [Math.max(0, centre - margin), Math.min(1, centre + margin)];
}

async function inBatches(count, size, work) {
  for (let start = 0; start < count; start += size) {
    await Promise.all(Array.from({ length: Math.min(size, count - start) }, (_, offset) => work(start + offset)));
  }
}

const TOPICS = [
  'checkout error rate spike', 'consumer rebalance loop', 'cache stampede', 'slow index scan', 'certificate expiry',
  'queue backlog growth', 'memory leak in the worker', 'clock skew between nodes', 'connection pool exhaustion', 'disk pressure',
  'retry storm', 'dns resolution failures', 'thundering herd on deploy', 'stale read replica', 'webhook delivery lag',
  'rate limiter misfire', 'config drift', 'session store eviction', 'batch job overrun', 'log pipeline drop',
  'feature flag mismatch', 'schema migration lock', 'cdn purge delay', 'cold start latency', 'token refresh failures',
];
const REGIONS = ['us-east-1', 'us-west-2', 'eu-west-1', 'eu-central-1', 'ap-south-1', 'ap-northeast-1'];
const STEPS = ['observation', 'hypothesis', 'mitigation', 'verification'];

async function main() {
  const options = parseArgs(process.argv.slice(2));
  const spec = locateDossier();
  const random = prng(options.seed);
  const tempRoot = mkdtempSync(path.join(tmpdir(), 'dossier-fleet-eval-'));
  const dbPath = path.join(tempRoot, 'dossier.db');
  const agents = [];
  let cleaned = false;
  cleanup = () => {
    if (cleaned) return;
    cleaned = true;
    for (const agent of agents) agent.close();
    try { rmSync(tempRoot, { recursive: true, force: true }); } catch { /* best effort */ }
  };
  process.on('SIGINT', () => { cleanup(); process.exit(130); });

  for (let index = 0; index < options.agents; index++) agents.push(new Agent(spec, dbPath, `agent-${index}`));
  const reader = new Agent(spec, dbPath, 'reader');
  agents.push(reader);
  await Promise.all(agents.map((agent) => agent.initialize()));
  const writers = agents.slice(0, options.agents);
  const writer = (index) => writers[((index % writers.length) + writers.length) % writers.length];

  /** The `dossier` CLI on the same database, for the one verb MCP does not offer (retract). */
  const cli = (...args) => {
    const run = spawnSync(spec.command, [...spec.prefix, ...args], { env: { ...process.env, DOSSIER_DB: dbPath }, encoding: 'utf8' });
    if (run.status !== 0) throw new Error(`dossier ${args.join(' ')} exited ${run.status}: ${run.stderr.trim()}`);
    return run.stdout;
  };

  const rows = [];
  const failures = [];
  /** One rate metric: k of n, with the value the mechanism is expected to give (1 or 0, or null). */
  const rate = (experiment, metric, k, n, expected) => {
    const value = n === 0 ? 0 : k / n;
    const [low, high] = wilson(k, n);
    const ok = expected === null || (n > 0 && value === expected);
    rows.push({ experiment, metric, value, k, n, ci: [low, high], expected, ok });
    if (!ok) failures.push(`${experiment}: ${metric} = ${k}/${n}, expected ${expected}`);
  };
  const latency = (experiment, metric, samples) => {
    rows.push({ experiment, metric, n: samples.length, p50: percentile(samples, 0.5), p95: percentile(samples, 0.95), max: samples.length ? Math.max(...samples) : null, expected: null, ok: true });
  };

  const startedAt = performance.now();

  // ---- 1. Provenance: depth-4 derivation chains, every step written by a different agent. ----
  const chains = [];
  await inBatches(options.chains, 8, async (index) => {
    const subject = `fleet-eval/incident-${index}`;
    const topic = TOPICS[index % TOPICS.length];
    const level = 2 + Math.floor(random() * 90);
    const chain = { subject, level, ids: [], writers: [] };
    for (let step = 0; step < STEPS.length; step++) {
      const author = writer(index + step);
      const texts = [
        `Incident ${index}: ${topic} observed at level ${level}.`,
        `Incident ${index}: the ${topic} is caused by the last deploy.`,
        `Incident ${index}: roll the last deploy back to stop the ${topic}.`,
        `Incident ${index}: the rollback cleared the ${topic}.`,
      ];
      const fact = { kind: 'finding', key: STEPS[step], text: texts[step], tags: ['fleet-eval'] };
      if (step === 0) fact.data = { level };
      else fact.refs = [derivedFrom(chain.ids[step - 1])];
      const posted = await author.post(subject, fact);
      chain.ids.push(posted.id);
      chain.writers.push(author.name);
    }
    chains[index] = chain;
  });

  let complete = 0;
  let writersRight = 0;
  let depthRight = 0;
  const hops = [];
  for (const chain of chains) {
    const walked = [];
    const actors = [];
    let cursor = chain.ids[STEPS.length - 1];
    for (let guard = 0; cursor && guard < 10; guard++) {
      const started = performance.now();
      const shown = await reader.tool('get_fact', { id: cursor });
      hops.push(performance.now() - started);
      walked.unshift(shown.fact.id);
      actors.unshift(shown.fact.provenance?.actor);
      cursor = shown.refs.find((ref) => ref.rel === 'derived_from' && ref.kind === 'fact')?.target;
    }
    if (chain.ids.every((id) => walked.includes(id))) complete++;
    if (walked.length === STEPS.length) depthRight++;
    if (walked.length === STEPS.length && actors.every((actor, step) => actor === chain.writers[step])) writersRight++;
  }
  rate('provenance', 'chain completeness (depth 4)', complete, chains.length, 1);
  rate('provenance', 'writer identity preserved at every hop', writersRight, chains.length, 1);
  rate('provenance', 'depth fidelity', depthRight, chains.length, 1);
  latency('provenance', 'per-hop get_fact latency (ms)', hops);

  // ---- 2. Contradiction: near-identical prose, different value, from two agents. ----
  const pairs = { admitted: 0, surfaced: 0, contested: 0, sequential: 0, total: 0 };
  await inBatches(options.facts * 2, 8, async (slot) => {
    const index = Math.floor(slot / 2);
    const concurrent = slot % 2 === 1;
    const subject = `fleet-eval/service-${index}-${concurrent ? 'concurrent' : 'sequential'}`;
    const first = REGIONS[index % REGIONS.length];
    // An offset of 1..length-1 never lands back on the first region.
    const second = REGIONS[(index + 1 + (Math.floor(index / REGIONS.length) % (REGIONS.length - 1))) % REGIONS.length];
    const claim = (region) => ({ kind: 'config', text: `Service ${index} is deployed in region ${region}.`, data: { region }, tags: ['fleet-eval'] });
    let one;
    let two;
    if (concurrent) {
      [one, two] = await Promise.all([writer(index).post(subject, claim(first)), writer(index + 1).post(subject, claim(second))]);
    } else {
      one = await writer(index).post(subject, claim(first));
      // The second writer knows what it disagrees with, so it says so with a ref.
      two = await writer(index + 1).post(subject, { ...claim(second), refs: [{ rel: 'contradicts', kind: 'fact', target: one.id, basis: 'observed' }] });
    }

    pairs.total++;
    if (one.status === 'new' && two.status === 'new' && one.id !== two.id) pairs.admitted++;
    const dossier = await reader.tool('compile_dossier', { subject, depth: 'index' });
    const conflict = dossier.conflicts.find((entry) => entry.field === 'region');
    if (conflict && [one.id, two.id].every((id) => conflict.values.some((value) => value.fact === id))) pairs.surfaced++;
    if (!concurrent) {
      pairs.sequential++;
      const verified = await reader.tool('verify_facts', { ids: [one.id, two.id] });
      if (verified.facts.every((fact) => fact.status === 'contested') && verified.current === false) pairs.contested++;
    }
  });
  rate('contradiction', 'both contradictory writes admitted (no dedup rejection)', pairs.admitted, pairs.total, 1);
  rate('contradiction', 'conflict surfaced in the compiled dossier, citing both facts', pairs.surfaced, pairs.total, 1);
  rate('contradiction', 'declared dispute: verify reports both facts contested', pairs.contested, pairs.sequential, 1);

  // ---- 3. Supersession: two agents write the same slot; exactly one value may be live. ----
  const slots = { total: 0, oneLive: 0, staleRead: 0, revokedReturned: 0, successorNamed: 0, surfacedAsConflict: 0 };
  await inBatches(options.facts * 2, 8, async (slot) => {
    const index = Math.floor(slot / 2);
    const concurrent = slot % 2 === 1;
    const subject = `fleet-eval/setting-${index}-${concurrent ? 'concurrent' : 'sequential'}`;
    const claim = (value) => ({ kind: 'config', key: 'timeoutSeconds', text: `Setting ${index} timeout is ${value} seconds.`, data: { timeoutSeconds: value }, tags: ['fleet-eval'] });
    const values = [10 + (index % 50), 100 + (index % 50)];
    let posted;
    if (concurrent) {
      posted = await Promise.all([writer(index).post(subject, claim(values[0])), writer(index + 1).post(subject, claim(values[1]))]);
    } else {
      posted = [await writer(index).post(subject, claim(values[0])), await writer(index + 1).post(subject, claim(values[1]))];
    }

    slots.total++;
    const verified = await reader.tool('verify_facts', { ids: posted.map((fact) => fact.id) });
    const live = verified.facts.filter((fact) => fact.status === 'live');
    const superseded = verified.facts.filter((fact) => fact.status === 'superseded');
    if (live.length === 1 && superseded.length === 1) slots.oneLive++;
    if (live.length === 1 && superseded.length === 1 && superseded[0].replaced_by === live[0].id) slots.successorNamed++;
    const hits = (await reader.tool('search', { subject, limit: 50 })).hits;
    const dossier = await reader.tool('compile_dossier', { subject, depth: 'full' });
    if (hits.length > 1) slots.staleRead++;
    if (superseded.some((old) => hits.some((hit) => hit.id === old.id) || dossier.facts.some((fact) => fact.id === old.id))) slots.revokedReturned++;
    if (dossier.conflicts.length > 0) slots.surfacedAsConflict++;
  });
  rate('supersession', 'exactly one live value per slot after two writers', slots.oneLive, slots.total, 1);
  rate('supersession', 'verify names the fact that replaced the old one', slots.successorNamed, slots.total, 1);
  rate('supersession', 'stale read: more than one live row for a slot', slots.staleRead, slots.total, 0);
  rate('supersession', 'superseded fact returned by default search or compile', slots.revokedReturned, slots.total, 0);
  // Not an expectation: a keyed overwrite is last-write-wins by design, so the loser is history, not a conflict.
  rate('supersession', 'overwritten value surfaced as a conflict (known gap)', slots.surfacedAsConflict, slots.total, null);

  // ---- 4. Derivation currency: change a chain's root; every descendant must verify stale. ----
  const currency = { descendants: 0, stale: 0, reasonRight: 0, storedLive: 0, roots: 0, rootRight: 0, controls: 0, falseStale: 0 };
  await inBatches(chains.length, 8, async (index) => {
    const chain = chains[index];
    const [root, ...descendants] = chain.ids;
    const control = index % 5 === 4;
    if (control) {
      // Control: the same claim reposted with one more tag. The row is replaced, the claim is not.
      await writer(index + 2).post(chain.subject, {
        kind: 'finding', key: STEPS[0], text: `Incident ${index}: ${TOPICS[index % TOPICS.length]} observed at level ${chain.level}.`, data: { level: chain.level }, tags: ['fleet-eval', 'reviewed'],
      });
      const verified = await reader.tool('verify_facts', { ids: descendants });
      currency.controls += descendants.length;
      currency.falseStale += verified.facts.filter((fact) => fact.status !== 'live').length;
      return;
    }

    const revised = await writer(index + 2).post(chain.subject, {
      kind: 'finding', key: STEPS[0], text: `Incident ${index}: ${TOPICS[index % TOPICS.length]} observed at level ${chain.level + 100}.`, data: { level: chain.level + 100 }, tags: ['fleet-eval'],
    });
    const verified = await reader.tool('verify_facts', { ids: [...descendants, root] });
    const byId = new Map(verified.facts.map((fact) => [fact.id, fact]));
    currency.roots++;
    if (byId.get(root)?.status === 'superseded' && byId.get(root)?.replaced_by === revised.id) currency.rootRight++;
    for (let step = 0; step < descendants.length; step++) {
      const fact = byId.get(descendants[step]);
      currency.descendants++;
      if (fact?.status === 'stale' && fact.current === false) currency.stale++;
      const reason = fact?.why?.[0];
      const input = chain.ids[step];
      if (reason?.rel === 'derived_from' && reason.fact === input && reason.state === (step === 0 ? 'superseded' : 'stale')) currency.reasonRight++;
      // What a check of the fact's own stored status says: the row was never rewritten.
      if ((await reader.tool('get_fact', { id: descendants[step] })).fact.status === 'live') currency.storedLive++;
    }
  });
  rate('derivation currency', 'descendant of a changed input verifies stale', currency.stale, currency.descendants, 1);
  rate('derivation currency', 'why names the direct input and its state', currency.reasonRight, currency.descendants, 1);
  rate('derivation currency', 'changed root verifies superseded with its replacement', currency.rootRight, currency.roots, 1);
  rate('derivation currency', 'false stale after a same-claim repost (control)', currency.falseStale, currency.controls, 0);
  // Not an expectation: this is the baseline a check of the fact's own row gives.
  rate('derivation currency', 'same descendants by stored status alone still read live', currency.storedLive, currency.descendants, null);

  // ---- 5. Revocation: a retracted fact must not come back through search or compile. ----
  const revoked = { total: 0, searchLeak: 0, compileLeak: 0, auditKept: 0, verified: 0 };
  const revocationSubject = 'fleet-eval/revocation';
  const tokens = [];
  for (let index = 0; index < options.probes; index++) {
    const token = `quartz${options.seed}x${index}zebra`;
    const posted = await writer(index).post(revocationSubject, { kind: 'note', text: `Probe ${index} carries the marker ${token}.`, tags: ['fleet-eval'] });
    tokens.push({ token, id: posted.id });
  }
  for (const { token, id } of tokens) {
    cli('retract', id);
    revoked.total++;
    const byText = (await reader.tool('search', { q: token })).hits;
    const bySubject = (await reader.tool('search', { subject: revocationSubject, limit: 100 })).hits;
    if (byText.some((hit) => hit.id === id) || bySubject.some((hit) => hit.id === id)) revoked.searchLeak++;
    const dossier = await reader.tool('compile_dossier', { subject: revocationSubject, depth: 'full' });
    if (dossier.facts.some((fact) => fact.id === id) || JSON.stringify(dossier).includes(token)) revoked.compileLeak++;
    const shown = await reader.tool('get_fact', { id });
    if (shown.fact.status === 'retracted' && shown.fact.text === undefined && shown.fact.provenance?.actor) revoked.auditKept++;
    if ((await reader.tool('verify_facts', { ids: [id] })).facts[0].status === 'retracted') revoked.verified++;
  }
  rate('revocation', 'retracted fact returned by search', revoked.searchLeak, revoked.total, 0);
  rate('revocation', 'retracted fact or its text returned by compile', revoked.compileLeak, revoked.total, 0);
  rate('revocation', 'tombstone kept for audit (id, writer, no text)', revoked.auditKept, revoked.total, 1);
  rate('revocation', 'verify reports it retracted', revoked.verified, revoked.total, 1);

  // ---- 6. Propagation: one agent writes, another reads the journal from its cursor. ----
  const propagationSubject = 'fleet-eval/propagation';
  await writer(0).post(propagationSubject, { kind: 'note', text: 'Propagation baseline.', tags: ['fleet-eval'] });
  let cursor = (await reader.tool('changes', { last: 1 })).next;
  const windows = [];
  const polls = [];
  let visible = 0;
  let firstPoll = 0;
  let actorRight = 0;
  for (let index = 0; index < options.probes; index++) {
    const author = writer(index);
    const posted = await author.post(propagationSubject, { kind: 'note', text: `Propagation probe ${index} at level ${Math.floor(random() * 1000)}.`, tags: ['fleet-eval'] });
    const written = performance.now();
    // Polled at once and without pause from write completion, one fact at a time, so the number is
    // the store's write-to-visible window and not this script's scheduling.
    for (let attempt = 1; attempt <= 200; attempt++) {
      const page = await reader.tool('changes', { since: cursor, subject: propagationSubject });
      cursor = page.next;
      const row = page.changes.find((change) => change.tbl === 'facts' && change.op === 'insert' && change.fact_id === posted.id);
      if (row) {
        visible++;
        if (attempt === 1) firstPoll++;
        if (row.actor === author.name) actorRight++;
        windows.push(performance.now() - written);
        polls.push(attempt);
        break;
      }
    }
  }
  rate('propagation', 'write visible to another agent through its cursor', visible, options.probes, 1);
  rate('propagation', 'visible on the first poll after the write returned', firstPoll, options.probes, 1);
  rate('propagation', 'journal row names the writing agent', actorRight, options.probes, 1);
  latency('propagation', 'write-to-visible window (ms, one changes round trip)', windows);

  // ---- 7. Convergence: every agent posts the same keyed fact at once. ----
  const convergence = { total: 0, oneRow: 0, quiet: 0 };
  for (let index = 0; index < options.probes; index++) {
    const subject = `fleet-eval/convergence-${index}`;
    const fact = { kind: 'config', key: 'owner', text: `Component ${index} is owned by the platform team.`, data: { owner: 'platform' }, tags: ['fleet-eval'] };
    const posted = await Promise.all(writers.map((author) => author.post(subject, fact)));
    convergence.total++;
    const ids = new Set(posted.map((result) => result.id));
    const fresh = posted.filter((result) => result.status === 'new').length;
    const deduped = posted.filter((result) => result.status === 'deduped').length;
    if (ids.size === 1 && fresh === 1 && deduped === writers.length - 1) convergence.oneRow++;
    const journal = await reader.tool('changes', { since: 0, subject, limit: 500 });
    if (journal.changes.filter((change) => change.tbl === 'facts').length === 1) convergence.quiet++;
  }
  rate('convergence', `${writers.length} agents post one keyed fact: one row, one id`, convergence.oneRow, convergence.total, 1);
  rate('convergence', 'reposts wrote nothing to the journal', convergence.quiet, convergence.total, 1);

  const seconds = (performance.now() - startedAt) / 1000;
  const revision = (await reader.tool('changes', { last: 1 })).next;
  cleanup();

  console.log(`fleet-eval  ${spec.label}`);
  console.log(`            agents=${options.agents} (+1 reader) chains=${options.chains} facts=${options.facts} probes=${options.probes} seed=${options.seed}`);
  console.log(`            ${seconds.toFixed(1)} s, final revision ${revision}`);
  console.log('');
  const pad = (text, width) => String(text).padEnd(width);
  console.log(`${pad('experiment', 20)} ${pad('metric', 66)} ${pad('value', 7)} ${pad('n', 9)} ${pad('95% CI', 16)} expect`);
  for (const row of rows) {
    if (row.p50 !== undefined) {
      const text = row.n === 0 ? 'n=0' : `p50=${row.p50.toFixed(1)} p95=${row.p95.toFixed(1)} max=${row.max.toFixed(1)}`;
      console.log(`${pad(row.experiment, 20)} ${pad(row.metric, 66)} ${pad(text, 34)} n=${row.n}`);
      continue;
    }
    const expect = row.expected === null ? 'reported' : `${row.expected === 1 ? '1.000' : '0.000'} ${row.ok ? 'ok' : 'FAIL'}`;
    console.log(`${pad(row.experiment, 20)} ${pad(row.metric, 66)} ${pad(row.value.toFixed(3), 7)} ${pad(`${row.k}/${row.n}`, 9)} ${pad(`[${row.ci[0].toFixed(3)},${row.ci[1].toFixed(3)}]`, 16)} ${expect}`);
  }
  console.log('');
  console.log('not measured: scoped access. Dossier has no scopes or authentication; every agent on a store reads all of it.');

  if (options.json) {
    writeFileSync(options.json, `${JSON.stringify({ options, binary: spec.label, seconds, revision, rows, failures }, null, 2)}\n`);
  }

  if (failures.length > 0) {
    console.error('');
    for (const failure of failures) console.error(`FAILED ${failure}`);
    process.exit(1);
  }

  console.log(`all ${rows.filter((row) => row.expected !== null && row.expected !== undefined).length} expectations held`);
}

main().catch((error) => {
  console.error(`fleet-eval: ${error.stack ?? error.message}`);
  try { cleanup(); } catch { /* best effort */ }
  process.exit(2);
});
