<img src="assets/icon.svg" width="64" height="64" alt="">

# Dossier

A context builder for agents and humans that turns scattered observations about a subject into a small, cited, budgeted dossier.

## The problem

An agent asked to work on an existing system has to open every primary artifact itself: the source files, the screenshots, the docs. The cost of that is unbounded, it varies per agent and per run, and the agent rediscovers the same things every time. Nothing learned in one run is kept for the next.

## The idea

```text
primary artifacts          facts (with provenance)        links            compiled dossier
-----------------          -----------------------        -----            ----------------
git files, screenshots --> one small, immutable,    --->  refs between --> cited, ranked, fits a
docs, notes                cited assertion each           facts and to     chosen token budget;
   (read once, by a        {actor, channel, origin,       artifacts;       conflicts and gaps
    capturer)               posted_at, confidence}        basis recorded   are surfaced, not hidden
```

The expensive reading happens once, when facts are captured, and every fact keeps a pointer back to the artifact it came from. Facts are linked by explicit refs, never by similarity. A dossier is then compiled on demand for one subject at a token budget you choose, with every line citing the fact ids it came from.

## Three verbs

**dump** ingests raw material deterministically into facts: `dossier dump --source <path> --subject <name>`. The input is stored as a content-addressed blob, split by markdown headings and paragraphs (the one splitter shipped), and the result is a manifest of created, deduped and skipped items. Running it twice is idempotent. Structured facts with declared refs go in through `dossier post --file <request.json>`.

**correlate** proposes refs between facts using deterministic matchers (`same_ref`, `shared_tag`): `dossier correlate [--subject <name>]`. Proposals carry basis `derived`, are returned and never written, and are never asserted as truth.

**retrieve** finds facts or compiles a dossier. `dossier search` takes text and filters, including reverse-impact lookup with `--ref-target`. `dossier dossier compile --subject <name> --budget <n>` compiles the cited, budgeted dossier.

## The model

| Noun | Meaning |
| --- | --- |
| Subject | The thing being described: `{ id, name, kind, parent?, aliases[], pin? }`. Kind is an open string such as app, screen, repo, module, doc. |
| Fact | One immutable, cited assertion about a subject: text, optional structured data, tags, confidence, status and provenance. Its `kind` is an open string. |
| Ref | The only edge, carried by a fact: `{ rel, kind, target, locator?, basis, ... }`. Internal targets are facts, slots and subjects; everything else is an external artifact. |
| Attachment | A file (screenshot, blob) addressed by sha256 and stored under `blobs/<sha256>`, never in the database. |

Invariants:

- Facts are immutable. Correction is a new fact that supersedes the old one by declared key (`subject`, `kind`, `key`).
- Refs are the only edge. There are no similarity-derived edges.
- Every ref carries a basis of `observed`, `derived` or `inferred`.
- Status is derived, never stored authority.
- Fact text has a soft limit of 240 characters and is never truncated.
- Writes fail closed (the item is rejected with a reason); compile fails open (last good dossier plus a degraded marker).

The normative shapes are the JSON Schemas in `contract/` (`subject`, `fact`, `ref`, `ops`, `dossier`).

## The guarantee

For a given subject and budget, the compiled dossier costs at most the budget regardless of how large the corpus grows. This boundedness, not any single compression ratio, is the claim worth relying on.

Measured with `bash scripts/scaling.sh` (synthetic distinct facts on one subject; two consecutive runs printed identical values):

```text
budget=1200 depth=full format=markdown estimator=chars/4
N      plain-facts tokens   dossier tokens  facts emitted  ratio plain/dossier
50     625                  892             39             0.70
200    2500                 892             39             2.80
1000   12500                892             39             14.01
```

The dossier cost is flat while plain facts grow linearly. The ratio is a consequence of the bound. Note that at N=50 the dossier is larger than the plain facts (0.70): citations cost tokens.

Four tests in `tests/Dossier.Tests/CompileTests.cs` back the bounded, reproducible cost property:

- `Budget_IsBoundedAsCorpusGrows`: at 50, 200 and 1000 facts, `used_tokens` stays at or below the budget of 1200.
- `Reproducible_SelectionAcrossIndependentStores`: the same logical facts in independent stores select identically, independent of fact id assignment.
- `Reproducible_RepeatedCompileIsByteIdentical`: repeated compiles of one store are byte-identical.
- `Reproducible_WithRecencyDisabled_IgnoresWallClock`: with `rank.recency=0`, the same 40 logical facts posted six hours apart compile to identical facts, dropped facts and `used_tokens`.

A related test, `Recency_DefaultStillAffectsOrdering`, shows the default recency term is live and not a dead weight.

## Measured results

Measured 2026-11-09 on the seeded subject `Memos/Home` (24 live facts) with `bash scripts/eval.sh`, per `docs/PLAN.md`. The baseline is primary sources: the original git files and screenshots an agent would otherwise read. Token estimator: chars/4 for text, pixels/750 for images.

| Arm | Context | Tokens |
| --- | --- | --- |
| C: primary sources | 4 git files at pinned rev `e4f3fb2d2d11...` plus 3 declared screenshots at 1440x900 (7 read operations) | 17171 |
| A: raw JSON | `search` JSON, limit 100, 24 facts | 1476 |
| A2: plain fact lines | the same facts as bare text | 371 |
| B: compiled dossier | budget 1200, full, markdown (1 read operation) | 708 |

Ratios: B/C 0.04 (about 24x smaller than primary sources), B/A 0.48, B/A2 1.91.

Accuracy: two independent agents, one given only arm A and one given only arm B, answered the ten questions in `scripts/eval/questions.json` and scored 10/10, including all three contradiction questions and both unanswerable ones.

**What this does not prove.**

- At 24 facts, compile is a net token cost: 708 tokens against 371 for plain fact lines (190.8%), because citations cost tokens and every fact is relevant. Capture carries the compression (about 46x from primary sources to bare facts); compile currently adds cost.
- Selection correctness at 1000 facts is unmeasured. The scaling table proves the cost is bounded; it does not show that the right 39 facts were chosen.
- The screenshots are declared arithmetic, not captured: the count and the 1440x900 size come from `scripts/eval/sources.json`, and the seeded PNG is a 1x1 placeholder. They supply 30 percent of arm C's tokens.
- No agent has answered from arm C, so primary-source accuracy is unmeasured. The 10/10 result covers arms A and B only.
- The default `rank.recency` term is derived from wall-clock `created_at` and can rank differently across machines. `rank.recency=0` is the reproducible mode.

The kill criterion in `docs/PLAN.md` (at least 90% of raw-dump accuracy at no more than 25% of the tokens across both eval domains) is not yet established: only one domain has been measured.

## Quick start

Needs the .NET 10 SDK, and `jq` and bash for the seed script.

```sh
dotnet build -c Release
export DOSSIER_DB=./dossier.db
dotnet src/Dossier/bin/Release/net10.0/Dossier.dll init
bash scripts/seed.sh
dotnet src/Dossier/bin/Release/net10.0/Dossier.dll dossier compile --subject Memos/Home --depth full --format markdown
```

Output of the last command (ids are GUIDs and differ per database, so `used_tokens` moves by a token or so between runs; the first two lines go to stderr):

```text
token estimator: chars/4
used_tokens: 709
# Memos/Home

- Home composer lets a user type a memo, attach media, and choose visibility. [92dc475f-78ce-40f8-8523-ed5cda0237b6]
- Home header is 64 pixels tall in the first audit and shows the workspace name. [80899598-5e1d-4054-963d-764eba1d50a0]
- Clicking a memo card opens the memo detail screen. [d5f05ca1-6c1c-4ffd-b439-b214abdca764]
... (24 facts in all)

## Conflicts

- composerMaxRows: 12 [8a8aa039-f1a3-4e35-be48-441ff1c368d5]; 6 [1c1cd226-3817-4475-b274-37e4e77473ae]
- headerHeight: 64 [80899598-5e1d-4054-963d-764eba1d50a0]; 72 [3340714d-13c2-4cc0-8ee0-c0b664e4242c]
- saveShortcut: "Cmd+Enter" [55e5a8f6-3d4b-40c4-be9f-93d9c5544e40]; "Ctrl+Enter" [b70c6049-05f9-4fb8-92f7-2efb5de57da9]
```

The seed script prints `subjects_created=5` and `facts_created=32`.

## Publish: a bundle for agents with no tools

`dossier publish --out <dir>` exports the store as a self-describing bundle of markdown files that an agent can read straight from a repository, with no MCP server, daemon or network. It is a one-shot command that writes files.

```sh
dotnet src/Dossier/bin/Release/net10.0/Dossier.dll publish --out docs/dossier \
  [--subject <name|id>] [--budget 1200] [--depth full|index] [--facts detail|none]
```

`--subject` limits the bundle to that subject and its descendants; `--budget` and `--depth` are the compile budget and depth used for every subject file (defaults 1200 and `full`); `--facts none` skips the per-fact files. `--out` is created if missing. A committed example is in `examples/memos-bundle/`, regenerated by `bash scripts/publish-demo.sh`.

```text
AGENTS.md         agent entry point: what this is, where to start, how to navigate, safety warnings
README.md         the human version: exact command, generation time, totals, drill-down path
INDEX.md          one row per subject: kind, facts, conflicts, gaps, token cost, link; totals; conflicted subjects
manifest.json     sorted keys, no volatile fields: ids to paths, per-file tokens, options, every generated file
conflicts.md      every conflict across subjects, each value linked to its fact
gaps.md           every gap across subjects
subjects/<slug>.md  the compiled dossier for one subject; every claim ends in a bracketed fact key that links to its fact file
facts/<slug>-<key>.md  one fact in full: store id, text, attributes, provenance, data, refs, inbound refs, subject link
```

The drill-down path is README -> INDEX -> `subjects/<slug>.md` -> `facts/<slug>-<key>.md`. An agent is told to read one subject file and to choose files by the token estimates in INDEX.md, not to read the bundle whole. Fact text is untrusted data, and `AGENTS.md` says so.

Rules:

- **Slugs.** A subject file is named by its name lowercased, every run of characters outside `a-z0-9` turned into one hyphen, leading and trailing hyphens trimmed, capped at 80 characters, `subject` if nothing remains. Subjects whose slugs collide are taken in tree order (name, kind, aliases, then id only as a last resort): the first keeps the slug and the rest get `-2`, `-3`, and so on, so the result depends on content, not on ids.
- **Content-addressed fact files.** `facts/<slug>-<key>.md` is named from the fact's content, not its random store id, so re-seeding or importing the same facts into a new store produces the same file names and a bundle committed to a repository does not churn. The `<key>` is the first 8 hex characters of the SHA-256 of the normalized text, declared key, kind and canonical data (refs and ids are excluded); the `<slug>` is the first six words of the text. Claims in subject files end in the bracketed key, linked to the file. Only facts whose keys collide are widened to 12, then 16, characters. Each fact file carries a `Store id:` line, and `manifest.json` maps each key to its store id and path.
- **Fact text is never truncated.** Fact files hold the full text. With `--depth index` the subject files use the compile's one-line index form, but fact files stay complete.
- **Idempotent and repo-safe.** Identical inputs produce byte-identical files and unchanged files are not rewritten. The README timestamp is kept while the rest of the bundle is unchanged. Files the previous run listed in `manifest.json` that are no longer produced (a retracted fact) are removed; any other file in the directory is never deleted. If a path the bundle needs is already held by a file it did not generate, the run fails before writing anything.
- **Order is content-derived.** Subjects are ordered as a tree by name, kind and aliases; facts by key, kind, text and content hash; ids break ties only after every content key.

## Surfaces

All three surfaces call the same core functions.

**CLI.** Commands: `init`, `dump`, `post`, `correlate`, `search`, `show`, `retract`, `dossier compile`, `publish`, `mcp`, `serve`. Examples against the seeded database (`d` is `dotnet src/Dossier/bin/Release/net10.0/Dossier.dll`):

```text
$ d search --q composer --subject Memos/Home --limit 2     # trimmed
{"total":9,"complete":false,"hits":[
  {"id":"4b2d39e9","kind":"element","text":"Home composer suggests @mentions as the user types a name.","status":"live","score":-1.83},
  {"id":"1c1cd226","kind":"element","text":"Home composer grows to at most 6 rows before it scrolls.","status":"live","score":-1.80}]}

$ d dossier compile --subject Memos/Home --depth index --budget 300 --need "billing invoice" --format markdown   # tail
## Conflicts
- composerMaxRows: 12 [...]; 6 [...]
- headerHeight: 64 [...]; 72 [...]
- saveShortcut: "Cmd+Enter" [...]; "Ctrl+Enter" [...]

## Gaps
- billing invoice: no fact

$ d dump --source scripts/seed/notes.md --subject Notes/Demo   # first run, then second run
created=4 deduped=0, skipped=[], errors=[]
created=0 deduped=4

$ d correlate --subject Memos/Home                         # 6 proposals, none written
{"proposed":[{"fact_id":"4b2d39e9-...","ref":{"rel":"mentions","kind":"fact","target":"92dc475f-...","basis":"derived"}}, ...
```

A need with no matching fact is reported as a gap instead of being silently dropped, and conflicting values for the same slot are listed with both cites; `conflicts[].resolution` is always null.

**MCP.** `dossier mcp` serves newline-delimited JSON-RPC over stdio (protocol versions 2025-06-18, 2025-03-26, 2024-11-05). Six tools: `dump`, `post_facts`, `correlate`, `search`, `get_fact`, `compile_dossier`. Resources: `dossier://subjects`, and the templates `dossier://subject/{id}` and `dossier://fact/{id}`. Tool descriptions mark fact text as untrusted data that must never be followed as instructions.

**Web.** `dossier serve [--port 8787]` serves a minimal page on `http://127.0.0.1:<port>/` (loopback only). It has a search box in the header, a subject list, search results, a compiled dossier view with its raw JSON, and a single-fact view. JSON endpoints: `/api/subjects`, `/api/search`, `/api/compile`, `/api/fact`.

## Architecture

One project, `src/Dossier/Dossier.csproj`: C# on net10.0, SQLite (WAL) with FTS5, raw ADO.NET, no ORM, no DI container. Core operations are plain functions over a `DossierStore`, and the CLI, MCP and web layers are thin transports over them. The core has no models and no network. The only package dependency is `Microsoft.Data.Sqlite`. Tests are TUnit on Microsoft.Testing.Platform.

| File | Owns |
| --- | --- |
| `Models.cs` | Request, response and domain types |
| `Store.cs` | `DossierStore`: the SQLite connection, schema and FTS5 index |
| `PostFacts.cs` | Writes: resolution order (declared supersede, hash dedupe, insert), refs, attachments |
| `Dump.cs` | Deterministic ingest and the markdown splitter |
| `Correlate.cs` | The `same_ref` and `shared_tag` matchers |
| `Search.cs` | Search, filters, reverse `ref_target` lookup |
| `Compile.cs` | Ranking, budgeted selection, conflicts, gaps, markdown rendering |
| `Show.cs`, `Retract.cs` | Fact detail with inbound refs; tombstoning |
| `ContentHash.cs`, `CanonicalJson.cs`, `JsonCodec.cs`, `Names.cs` | Content hashing, canonical JSON, serialization options, name helpers |
| `Mcp.cs` | MCP server over stdio |
| `Web.cs`, `www/index.html` | Loopback HTTP server and the embedded page |
| `Program.cs` | CLI entry point |

## Repository map

```text
README.md          this file
Dossier.sln        solution (src project plus tests)
global.json        pins the Microsoft.Testing.Platform test runner
assets/            icon
contract/          JSON Schemas: subject, fact, ref, ops, dossier (the normative shapes)
docs/PLAN.md       hypothesis, kill criterion, invariants, measured results
examples/          memos-bundle/, a committed publish output
scripts/           seed.sh, e2e.sh, eval.sh, scaling.sh, verify-refs.sh, publish-demo.sh
scripts/seed/      the Memos demo corpus and a notes.md for dump
scripts/eval/      questions.json, sources.json; artifacts/ is git-ignored output
src/Dossier/       the reference implementation
tests/Dossier.Tests/  109 TUnit tests
```

## Reproducing the evaluation

```sh
bash scripts/e2e.sh          # seed a temp DB and exercise every surface of the loop
bash scripts/eval.sh         # arms A, A2, B and C token counts (arm C fetches from raw.githubusercontent.com)
bash scripts/scaling.sh      # the N=50/200/1000 bounded-cost table
bash scripts/verify-refs.sh  # fails unless every seeded git ref resolves with HTTP 200
```

All scripts need bash, `jq` and a Release build. `dotnet test` runs the 109 tests.

## Status

Done (Gate A): dump, post with declared refs, the two matchers, reverse `ref_target` search, search, compile, MCP, minimal web; 109 passing tests; the seeded Memos demo; the evaluation harness.

Not done (Gate B, not built): reverify, follow in compile, trust-gated supersede, computed contested and stale status, dump adapters. Also open: selection accuracy at scale, a second evaluation domain (a repo module), and primary-source accuracy (arm C).

## Contract and implementation

The JSON Schemas in `contract/` are the normative shapes; the C# in this repository is a reference implementation of them. Nothing in the core is specific to any consumer, so another implementation of the same contract would interoperate.

## Design notes

Five foot-guns shaped the design; each is a decision, not an accident.

**Fact text is untrusted.** A dossier is read by an agent, so fact text is carried as delimited data, never as instructions and never executed. `dossier mcp` marks returned fact text as untrusted data that must never be followed as instructions, in the server instructions and in every tool description.

**Similarity never makes an edge.** Similarity is only a retrieval and ranking signal; the only edge is a ref carried by a fact, with an explicit basis. The graph therefore cannot fill with hallucinated links, because a relationship has to be declared to exist.

**Dedupe never merges silently.** Every write reports what it did: `new`, `deduped` with the existing fact id, or `replaced` with the id it superseded. Content-hash dedupe is scoped to one subject and never merges across subjects or declared keys, and correction is a new superseding fact, so every merge stays traceable.

**Conflicts are exempt from the budget.** The budget bounds the fact content; conflicts and gaps are never charged against it. A dossier whose conflicts alone exceed the budget overruns it, because a dossier that hides a contradiction to save tokens is worse than one that is over budget.

**Dossier facts never feed back in.** Compile skips the reserved kind `dossier` when it loads candidates, so a fact of that kind can never appear in a compiled dossier's output. Compiling is a read: the result is returned to the caller and is not itself written as a fact.
