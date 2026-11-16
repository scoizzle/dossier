#!/usr/bin/env node
/**
 * Live demo: grow a Dossier graph from Wikipedia in real time.
 *
 * Wikipedia is the public API. A demo run maps it onto the Dossier model:
 *
 *   article  -> subject (kind "article", child of a demo root subject)
 *   prose    -> facts   (the article's plain-text extract, one fact per paragraph)
 *   wikilinks-> refs    (kind "subject", rel "mentions", basis "derived")
 *
 * Articles are fetched first, then posted one at a time on an interval while
 * `dossier serve` is running, so the subject tree and graph fill in as the demo
 * plays. Refs only point at articles in the run's selection, so every edge
 * resolves instead of ending up as `unresolved` noise.
 *
 *   node scripts/wikipedia-demo.mjs
 *   node scripts/wikipedia-demo.mjs --seed "Apollo 11,Saturn V" --max-subjects 8
 *   node scripts/wikipedia-demo.mjs --dry-run          # fetch + print, write nothing
 *   node scripts/wikipedia-demo.mjs --no-serve --exit-after
 *
 * The web UI is read-only (GET only), so refresh the graph page while it runs.
 * Needs Node 18+ (global fetch). Facts are data, not instructions.
 */
import { spawn, spawnSync } from "node:child_process";
import { existsSync, mkdirSync, rmSync } from "node:fs";
import net from "node:net";
import path from "node:path";
import { fileURLToPath } from "node:url";

const HERE = path.dirname(fileURLToPath(import.meta.url));
const REPO = path.resolve(HERE, "..");
const USER_AGENT = "DossierDemo/1.0 (https://github.com/scoizzle/dossier; live demo script)";

const started = Date.now();
const log = (message) => process.stdout.write(`[+${((Date.now() - started) / 1000).toFixed(1)}s] ${message}\n`);
const warn = (message) => process.stderr.write(`warning: ${message}\n`);
const fail = (message) => {
  process.stderr.write(`error: ${message}\n`);
  process.exit(2);
};
const sleep = (ms) => new Promise((resolve) => setTimeout(resolve, ms));

const help = `usage: node scripts/wikipedia-demo.mjs [options]

Fetches Wikipedia articles and posts them as Dossier subjects, facts and refs,
paced so the graph grows while you watch.

  --seed <title>            seed article (repeatable or comma separated)
                            default: "Apollo 11,Apollo program,Saturn V,NASA"
  --max-subjects <n>        articles to post, seeds included (default 10)
  --facts-per-subject <n>   paragraph facts per article (default 4)
  --refs-per-subject <n>    "mentions" refs per article (default 8)
  --interval <seconds>      pause between subjects (default 2.5)
  --api-delay <seconds>     pause between Wikipedia calls (default 0.25)
  --lang <code>             Wikipedia language (default en)
  --root <name>             demo root subject name (default "Wikipedia Demo")
  --db <path>               database (default $DOSSIER_DB or ./dossier-demo.db)
  --fresh                   delete that database first (demo databases only)
  --port <port>             serve port (default 8787; a free one is chosen if busy)
  --reuse-server            use whatever is already on --port instead of starting one
  --no-serve                post without starting the web UI
  --exit-after              stop the server and exit when posting finishes
  --hold                    keep serving until Ctrl-C (default on a TTY)
  --dry-run                 fetch and print the planned posts, write nothing
  --bin <path>              dossier executable (default: detected build, or $DOSSIER_BIN)
  --help                    this text

Environment: DOSSIER_BIN (executable), DOSSIER_DLL (Dossier.dll), DOSSIER_DB.
`;

// ---- arguments -----------------------------------------------------------------

const argv = process.argv.slice(2);
const opts = { seeds: [] };
for (let i = 0; i < argv.length; i++) {
  const token = argv[i];
  if (!token.startsWith("--")) fail(`unexpected argument "${token}" (see --help)`);
  const key = token.slice(2);
  if (["help", "dry-run", "no-serve", "exit-after", "hold", "reuse-server", "fresh"].includes(key)) {
    opts[key] = true;
    continue;
  }
  const value = argv[++i];
  if (value === undefined || value.startsWith("--")) fail(`--${key} needs a value`);
  if (key === "seed") opts.seeds.push(value);
  else opts[key] = value;
}

if (opts.help) {
  process.stdout.write(help);
  process.exit(0);
}

function integer(name, fallback, min, max) {
  const raw = opts[name];
  if (raw === undefined) return fallback;
  const value = Number(raw);
  if (!Number.isInteger(value) || value < min || (max !== undefined && value > max)) {
    fail(`--${name} must be an integer between ${min}${max === undefined ? "" : ` and ${max}`}`);
  }
  return value;
}

function seconds(name, fallback) {
  const raw = opts[name];
  if (raw === undefined) return fallback;
  const value = Number(raw);
  if (!Number.isFinite(value) || value < 0) fail(`--${name} must be a non-negative number of seconds`);
  return value;
}

const config = {
  db: opts.db ?? process.env.DOSSIER_DB ?? "./dossier-demo.db",
  port: integer("port", 8787, 1, 65535),
  lang: opts.lang ?? "en",
  maxSubjects: integer("max-subjects", 10, 1),
  factsPerSubject: integer("facts-per-subject", 4, 0),
  refsPerSubject: integer("refs-per-subject", 8, 0),
  intervalMs: seconds("interval", 2.5) * 1000,
  apiDelayMs: seconds("api-delay", 0.25) * 1000,
  rootName: opts.root ?? "Wikipedia Demo",
  seeds: (opts.seeds.length ? opts.seeds : ["Apollo 11", "Apollo program", "Saturn V", "NASA"])
    .flatMap((value) => value.split(","))
    .map((value) => value.trim())
    .filter(Boolean),
};

if (!config.seeds.length) fail("at least one --seed is required");
if (!config.rootName.trim()) fail("--root must not be empty");
if (config.db === ":memory:") fail("each command runs in its own process; use a file database, not :memory:");
if (/[/\\]dossier\.db$/.test(config.db) && opts.fresh) {
  fail("--fresh refuses to delete ./dossier.db; pass a demo database with --db");
}

// ---- the dossier executable ----------------------------------------------------

function resolveDossier() {
  const bin = opts.bin ?? process.env.DOSSIER_BIN;
  if (bin) return { command: bin, args: [] };
  const dll = process.env.DOSSIER_DLL;
  if (dll) return { command: "dotnet", args: [dll] };
  for (const configuration of ["Release", "Debug"]) {
    const candidate = path.join(REPO, "src", "Dossier", "bin", configuration, "net10.0", "Dossier.dll");
    if (existsSync(candidate)) return { command: "dotnet", args: [candidate] };
  }
  fail("no Dossier build found; run `dotnet build -c Release` or set DOSSIER_BIN");
}

const dossier = resolveDossier();
const dossierArgs = (rest) => [...dossier.args, ...rest];
const childEnv = { ...process.env, DOSSIER_DB: config.db };

function dossierRun(rest, input) {
  const result = spawnSync(dossier.command, dossierArgs(rest), {
    input,
    encoding: "utf8",
    env: childEnv,
    maxBuffer: 8 * 1024 * 1024,
  });
  if (result.error) fail(`cannot run ${dossier.command}: ${result.error.message}`);
  if (result.status !== 0) {
    fail(`${rest[0]} failed (exit ${result.status}): ${(result.stderr || result.stdout || "").trim()}`);
  }
  return result;
}

const dbFile = path.resolve(config.db);
if (dbFile !== ":memory:" && !opts["dry-run"]) {
  mkdirSync(path.dirname(dbFile), { recursive: true });
  if (opts.fresh) {
    for (const suffix of ["", "-wal", "-shm"]) {
      rmSync(dbFile + suffix, { force: true });
    }
    log(`removed ${dbFile}`);
  }
}

// ---- Wikipedia -----------------------------------------------------------------

let lastCall = 0;
async function wikipedia(params) {
  const wait = config.apiDelayMs - (Date.now() - lastCall);
  if (wait > 0) await sleep(wait);
  lastCall = Date.now();

  const url = new URL(`https://${config.lang}.wikipedia.org/w/api.php`);
  const query = { action: "query", format: "json", formatversion: "2", redirects: "1", ...params };
  for (const [key, value] of Object.entries(query)) url.searchParams.set(key, String(value));

  const response = await fetch(url, {
    headers: { "user-agent": USER_AGENT, accept: "application/json" },
    signal: AbortSignal.timeout(20000),
  });
  if (!response.ok) throw new Error(`Wikipedia API ${response.status} ${response.statusText}`);
  const body = await response.json();
  if (body.error) throw new Error(`Wikipedia API ${body.error.code}: ${body.error.info ?? ""}`.trim());
  return body;
}

const SKIP_TITLE = /(\((identifier|disambiguation)\)|^Portal:|^Special:|^Help:|^File:|^Category:)/i;

async function fetchArticle(title) {
  const body = await wikipedia({
    prop: "extracts",
    explaintext: "1",
    exsectionformat: "plain",
    exlimit: "1",
    titles: title,
  });
  const page = body.query?.pages?.[0];
  if (!page || page.missing === true) return { requested: title, missing: true };

  // Lead-section wikilinks only: they are the curated "see also" links of the
  // article (infobox and first paragraphs), not hundreds of citation links.
  const parsed = await wikipedia({
    action: "parse",
    page: page.title,
    prop: "links",
    section: "0",
  });
  const links = [
    ...new Set(
      (parsed.parse?.links ?? [])
        .filter((link) => link.ns === 0 && link.exists !== false && link.title)
        .map((link) => link.title),
    ),
  ].filter((link) => !SKIP_TITLE.test(link));
  return {
    requested: title,
    title: page.title,
    extract: page.extract ?? "",
    links,
    fetchedAt: new Date().toISOString(),
    url: `https://${config.lang}.wikipedia.org/wiki/${encodeURIComponent(page.title.replace(/ /g, "_"))}`,
  };
}

/**
 * Fetch the seeds, then enough of their wikilinks to reach max-subjects. Links
 * shared by several seeds come first (they make the busiest edges); ties keep
 * page order.
 */
async function collectArticles() {
  const chosen = new Map();
  for (const seed of config.seeds) {
    if (chosen.size >= config.maxSubjects) break;
    try {
      const article = await fetchArticle(seed);
      if (article.missing) {
        warn(`no Wikipedia article for "${seed}"`);
        continue;
      }
      if (!chosen.has(article.title)) chosen.set(article.title, article);
      log(`seed ${article.title}: ${article.links.length} links`);
    } catch (error) {
      warn(`${seed}: ${error.message}`);
    }
  }
  if (!chosen.size) fail("none of the seed articles could be fetched");

  const frequency = new Map();
  for (const article of chosen.values()) {
    for (const link of article.links) {
      if (!chosen.has(link)) frequency.set(link, (frequency.get(link) ?? 0) + 1);
    }
  }
  const candidates = [...frequency.entries()].sort((a, b) => b[1] - a[1]).map(([title]) => title);

  for (const title of candidates) {
    if (chosen.size >= config.maxSubjects) break;
    try {
      const article = await fetchArticle(title);
      if (article.missing || chosen.has(article.title)) continue;
      chosen.set(article.title, article);
      log(`link ${article.title}: ${article.links.length} links`);
    } catch (error) {
      warn(`${title}: ${error.message}`);
    }
  }

  return [...chosen.values()];
}

// ---- payloads ------------------------------------------------------------------

function cleanParagraph(text) {
  return text.replace(/\[\d+\]/g, "").replace(/\s+/g, " ").trim();
}

function clamp(text, max) {
  if (text.length <= max) return text;
  const cut = text.slice(0, max - 1);
  const stop = Math.max(cut.lastIndexOf(". "), cut.lastIndexOf("! "), cut.lastIndexOf("? "));
  const body = stop > max * 0.4 ? cut.slice(0, stop + 1) : cut.trimEnd();
  return `${body}…`;
}

const MIN_PARAGRAPH = 80;

function paragraphsOf(extract) {
  return extract
    .split(/\n+/)
    .map(cleanParagraph)
    .filter((paragraph) => paragraph.length >= MIN_PARAGRAPH && /[.!?]$/.test(paragraph));
}

// verified_at is freshness metadata: ContentHash deliberately excludes it, so a
// rerun with a new fetch time still dedupes against the earlier post.
const urlRef = (url, verifiedAt) => ({
  rel: "derived_from",
  kind: "url",
  target: url,
  basis: "observed",
  verified_at: verifiedAt,
});

function articlePayload(article, selected, parentId) {
  const paragraphs = paragraphsOf(article.extract);
  const tags = ["source:wikipedia", `lang:${config.lang}`];
  const refs = [urlRef(article.url, article.fetchedAt)];
  const facts = [];

  facts.push({
    kind: "summary",
    text: clamp(
      paragraphs[0] ?? `${article.title} has no plain-text summary in the Wikipedia extract for this article.`,
      600,
    ),
    data: { title: article.title, url: article.url },
    tags,
    refs: [...refs, { rel: "about", kind: "subject", target: article.title, basis: "observed" }],
  });

  for (const [index, paragraph] of paragraphs.slice(1, 1 + config.factsPerSubject).entries()) {
    facts.push({
      kind: "paragraph",
      text: clamp(paragraph, 500),
      data: { title: article.title },
      tags,
      refs,
    });
  }

  const targets = article.links.filter((link) => link !== article.title && selected.has(link)).slice(0, config.refsPerSubject);
  if (targets.length) {
    const shown = targets.slice(0, 5).join(", ");
    const more = targets.length > 5 ? ` and ${targets.length - 5} more` : "";
    facts.push({
      kind: "links",
      text: `${article.title} links to ${targets.length} other article${targets.length === 1 ? "" : "s"} in this demo: ${shown}${more}.`,
      tags: [...tags, "section:links"],
      refs: [
        ...refs,
        ...targets.map((target) => ({ rel: "mentions", kind: "subject", target, basis: "derived" })),
      ],
    });
  }

  return {
    subject: {
      name: article.title,
      kind: "article",
      parent: parentId,
      aliases: [article.title.replace(/ /g, "_")],
    },
    facts,
  };
}

// ---- server --------------------------------------------------------------------

function isListening(port) {
  return new Promise((resolve) => {
    const socket = net.connect({ host: "127.0.0.1", port });
    const done = (value) => {
      socket.destroy();
      resolve(value);
    };
    socket.once("connect", () => done(true));
    socket.once("error", () => done(false));
    socket.setTimeout(500, () => done(false));
  });
}

async function freePort(start) {
  for (let port = start; port < start + 25; port++) {
    if (!(await isListening(port))) return port;
  }
  fail(`no free port near ${start}`);
}

async function waitForServer(port, timeoutMs = 15000) {
  const deadline = Date.now() + timeoutMs;
  while (Date.now() < deadline) {
    try {
      const response = await fetch(`http://127.0.0.1:${port}/api/subjects`, { signal: AbortSignal.timeout(1000) });
      if (response.ok) return;
    } catch {
      // not up yet
    }
    await sleep(150);
  }
  fail(`dossier serve did not answer on port ${port}`);
}

// ---- main ----------------------------------------------------------------------

const articles = await collectArticles();
const selected = new Set(articles.map((article) => article.title));
const rootPayload = {
  subject: { name: config.rootName, kind: "collection", aliases: ["wikipedia-demo"] },
  facts: [
    {
      kind: "collection",
      text: `A live demo collection of ${articles.length} Wikipedia articles in ${config.lang}, fetched from the public MediaWiki API and posted one subject at a time.`,
      tags: ["source:wikipedia", `lang:${config.lang}`],
      refs: articles.map((article) => ({
        rel: "contains",
        kind: "subject",
        target: article.title,
        basis: "observed",
      })),
    },
  ],
};

if (opts["dry-run"]) {
  process.stdout.write(
    `${JSON.stringify(
      {
        config: { ...config, db: dbFile, seeds: config.seeds },
        root: { subject: rootPayload.subject, facts: rootPayload.facts.length },
        articles: articles.map((article) => ({
          title: article.title,
          links: article.links.length,
          paragraphs: paragraphsOf(article.extract).length,
        })),
        sample: {
          root: rootPayload,
          article: articles.length ? articlePayload(articles[0], selected, undefined) : null,
        },
      },
      null,
      2,
    )}\n`,
  );
  process.stdout.write(`planned posts: 1 root + ${articles.length} articles; wrote nothing\n`);
  process.exit(0);
}

log(`database ${config.db}`);
dossierRun(["init"]);

let server = null;
let serverPort = config.port;
let reused = false;
let stopping = false;

function stopServer() {
  stopping = true;
  if (server && server.exitCode === null) server.kill("SIGTERM");
}

process.on("SIGINT", () => {
  stopServer();
  process.exit(130);
});
process.on("SIGTERM", () => {
  stopServer();
  process.exit(143);
});
process.on("exit", stopServer);

if (!opts["no-serve"]) {
  if (await isListening(config.port)) {
    if (opts["reuse-server"]) {
      serverPort = config.port;
      reused = true;
      log(`reusing the server already on port ${serverPort} (it may serve a different database)`);
    } else {
      serverPort = await freePort(config.port + 1);
      log(`port ${config.port} is busy; serving on ${serverPort} instead`);
    }
  }

  if (!reused) {
    server = spawn(dossier.command, dossierArgs(["serve", "--port", String(serverPort)]), {
      env: childEnv,
      stdio: ["ignore", "ignore", "inherit"],
    });
    server.on("error", (error) => fail(`cannot start dossier serve: ${error.message}`));
    server.on("exit", (code) => {
      if (!stopping) warn(`dossier serve exited (${code}); the UI is no longer available`);
    });
  }

  await waitForServer(serverPort);
  try {
    const graphProbe = await fetch(`http://127.0.0.1:${serverPort}/api/graph`, { signal: AbortSignal.timeout(2000) });
    if (graphProbe.status === 404) {
      warn("this Dossier build does not serve /api/graph; rebuild with `dotnet build -c Release` for the graph view");
    }
  } catch {
    // The server answered /api/subjects already; a failed graph probe is not fatal.
  }

  log(`web UI  http://127.0.0.1:${serverPort}/`);
}

const tally = { subjects: 0, createdSubjects: 0, facts: 0, refs: 0, newFacts: 0, deduped: 0, replaced: 0 };

function post(payload, label) {
  const result = dossierRun(["post", "--file", "-"], JSON.stringify(payload));
  if (result.stderr.trim()) warn(`${label}: ${result.stderr.trim()}`);
  const response = JSON.parse(result.stdout);
  tally.subjects += 1;
  tally.createdSubjects += response.subject.created ? 1 : 0;
  tally.facts += payload.facts.length;
  tally.refs += payload.facts.reduce((sum, fact) => sum + (fact.refs?.length ?? 0), 0);
  for (const fact of response.facts) {
    if (fact.status === "new") tally.newFacts += 1;
    else if (fact.status === "deduped") tally.deduped += 1;
    else if (fact.status === "replaced") tally.replaced += 1;
  }
  const statuses = response.facts.reduce((counts, fact) => {
    counts[fact.status] = (counts[fact.status] ?? 0) + 1;
    return counts;
  }, {});
  log(
    `${label}: subject ${response.subject.created ? "created" : "existing"}, ` +
      `${Object.entries(statuses).map(([status, count]) => `${count} ${status}`).join(", ")}`,
  );
  return response;
}

const root = post(rootPayload, config.rootName);
const rootId = root.subject.id;

if (!opts["no-serve"]) {
  log(`graph   http://127.0.0.1:${serverPort}/#/graph/${encodeURIComponent(rootId)}`);
  log("the UI is read-only; refresh the graph page to see new nodes as they land");
}

for (const [index, article] of articles.entries()) {
  const payload = articlePayload(article, selected, rootId);
  post(payload, article.title);
  if (index < articles.length - 1) await sleep(config.intervalMs);
}

log(
  `done: ${tally.createdSubjects} subject(s) created, ${tally.newFacts} fact(s) new ` +
    `(${tally.deduped} deduped, ${tally.replaced} replaced), ${tally.refs} ref(s) posted`,
);
log(`next: dossier check --subject "${config.rootName}"`);
log(`      dossier dossier compile --subject "${config.rootName}" --depth full --format markdown`);

const shouldHold = !opts["no-serve"] && !opts["exit-after"] && (opts.hold || process.stdin.isTTY);
if (shouldHold) {
  log(
    reused
      ? `open http://127.0.0.1:${serverPort}/; Ctrl-C stops this demo (the reused server keeps running)`
      : `serving on http://127.0.0.1:${serverPort}/; press Ctrl-C to stop`,
  );
  await new Promise(() => {});
} else {
  stopServer();
}
