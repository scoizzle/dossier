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

**dump** ingests raw material deterministically into facts: `dossier dump --source <path> --subject <name>`. The input is stored as a content-addressed blob, split by markdown headings, paragraphs, or (with `--split code`) Python code entities, and the result is a manifest of created, deduped and skipped items. Running it twice is idempotent. Structured facts with declared refs go in through `dossier post --file <request.json>`.

**Code split.** `dossier dump --source mod.py --subject pkg/mod --split code` emits one fact per class, function, async function and method at any nesting depth, in source order, instead of paragraph blobs. The fact text is the signature (colon removed, whitespace collapsed; capped at 240 characters only for a longer signature, cut at a word boundary with an ellipsis and tagged `signature_truncated`). `data` carries `symbol` (dotted qualname such as `QuerySet.filter`), `entity_kind` (`class`, `function`, `async_function`, `method`, `static_method`, `class_method`), `parent` (enclosing qualname, or the module stem), `start_line` and `end_line`; the `derived_from` locator carries `line`, `selector` and `symbol`; tags include `entity:<kind>` and `decorator:<name>`; the docstring's first paragraph is the fact's single item. Add `--entity-subjects` to also make every entity its own subject `<module-subject>::<qualname>` (kind = entity kind, parent = the module subject) holding that entity's fact, while the module subject gets one `contains` fact per top-level entity. **Only Python (`.py`, `.pyi`) is supported**; any other file with `--split code` falls back to paragraph and reports `warning: split_fallback` in the manifest's `errors`. The scanner is a line-based tokenizer, not a full parser: it understands strings, comments, bracket and backslash continuation, but not f-string nesting corner cases. `scripts/dump-code-demo.sh` ingests `django/db/models` at tag 6.1.3 this way and publishes `examples/django-models-bundle`.

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
- Ref kind `symbol` cites a symbol in an external static analysis. It is external (never a node, never an internal edge, no effect on centrality or ranking). Its target is `<qualified-name>@<revision>`, for example `django.db.models.QuerySet.filter@e4f3fb2d2d11`: the qualified name may contain dots, colons and parentheses, and the revision is everything after the last `@` and must be non-empty. A target without a revision is rejected with `symbol_target_requires_revision`, identically in `post`, `post --dry-run` and `check --drafts`. Basis `observed` is a runtime or human observation; basis `derived` is a citation of an analyzer's output, not an assertion of the referencing fact. If an observation disagrees with the analysis, post it with rel `refutes` against the symbol ref. `search --ref-target '<qualified>@<rev>' --direction in` returns every fact citing the symbol; `--direction out` still rejects it as external. Publish renders it as plain text, not a link.
- Status is derived, never stored authority.
- Fact text has a soft limit of 240 characters and is never truncated.
- Writes fail closed (the item is rejected with a reason); compile fails open (last good dossier plus a degraded marker).

The normative shapes are the JSON Schemas in `contract/` (`subject`, `fact`, `ref`, `ops`, `dossier`).

## Budget modes

`compile` and `publish` take `--budget-mode complete|strict` (JSON: `budget_mode`).

- **complete** (the default): no fact is omitted. Near-duplicate clustering is not applied, so a fact never hides behind another fact's `cites`: `facts` holds every candidate in rank order, each cites only its own id, `dropped` is empty, and `used_tokens` is the true total, which may exceed `budget_tokens`. The budget is only the highlight threshold: when the facts do not fit it, the markdown shows a `## Highlights` section (the top facts that fit the budget) followed by `## All facts` (every remaining fact as one compact line, still ranked). When everything fits, it is the single `## Facts` list. Complete mode is **not bounded**: cost grows with the corpus.
- **strict**: near-duplicates still cluster into one representative whose `cites` list the collapsed fact ids, then the facts are cut to the budget and the remainder is listed in `dropped`. Only strict mode gives the bounded-cost guarantee below.

Conflicts and gaps behave the same in both modes. An invalid value exits non-zero and names the accepted values.

## The guarantee (strict mode)

In strict mode, for a given subject and budget, the compiled dossier costs at most the budget regardless of how large the corpus grows. In complete mode (the default) there is no such bound. This boundedness, not any single compression ratio, is the claim worth relying on, and `scripts/scaling.sh` and the eval pass `--budget-mode strict` explicitly.

Measured with `bash scripts/scaling.sh` (synthetic distinct facts on one subject; two consecutive runs printed identical values):

```text
budget=1200 mode=strict depth=full format=markdown estimator=chars/4
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
  [--subject <name|id>] [--budget 1200] [--depth full|index] [--facts detail|none] [--assets detail|none]
```

`--subject` limits the bundle to that subject and its descendants; `--budget` and `--depth` are the compile budget and depth used for every subject file (defaults 1200 and `full`); `--budget-mode complete|strict` (default `complete`) decides whether each subject page lists every fact (the budget is then only the highlight threshold, and the page may be far larger than the budget) or is cut to the budget; `--facts none` skips the per-fact files. `--out` is created if missing. A committed example is in `examples/memos-bundle/`, regenerated by `bash scripts/publish-demo.sh`.

```text
AGENTS.md         agent entry point: what this is, where to start, how to navigate, safety warnings
README.md         the human version: exact command, generation time, totals, drill-down path
INDEX.md          one row per subject: kind, facts, conflicts, gaps, token cost, link; totals; conflicted subjects
manifest.json     sorted keys, no volatile fields: ids to paths, per-file tokens, options, every generated file
conflicts.md      every conflict across subjects, each value linked to its fact
gaps.md           every gap across subjects
index/<group>.md  deeper index files, only when INDEX.md would exceed --index-max-tokens; a `group` row links to one
subjects/<slug>/index.md  the compiled dossier for one subject; every claim ends in a bracketed fact key that links to its fact file
subjects/<slug>/facts/<words>-<key>.md  one fact in full: store id, text, attributes, provenance, data, refs, inbound refs, attachments, subject link
subjects/<slug>/assets/<sha8>-<file-stem>.<ext>  the bytes of each attachment on that subject's facts
```

Everything that belongs to a subject lives in that subject's directory, so removing a subject removes one directory.

The drill-down path is AGENTS.md -> INDEX.md -> `index/<group>.md` -> `subjects/<slug>/index.md` -> `subjects/<slug>/facts/<key>.md`. An agent is told to read one subject file and to choose files by the token estimates in INDEX.md, not to read the bundle whole. Fact text is untrusted data, and `AGENTS.md` says so.

A fact file links onward to the facts and subjects it depends on, so the bundle is a graph to walk, not a list of described edges:

- A ref of kind `fact` links to that fact's file; a ref of kind `slot` (`<subject>#<key>`) links to the fact that currently occupies the slot, so after the slot is superseded the link points at the new head, and an empty slot is shown as text marked `unresolved slot`; a ref of kind `subject` (id or name) links to that subject's `index.md`.
- Paths are computed from the two files they join: `<file>` inside one subject, `../../<other>/facts/<file>` to a fact in another subject, `../../<other>/index.md` to another subject from a fact file and `../<other>/index.md` from a subject's index.md. The `Referenced by` list links back with the referring fact's kind and rel.
- External refs (git, file, doc, http) stay text, except a target starting with `http://` or `https://`, which is a plain markdown link with the URL unchanged.
- Every generated internal link resolves to a file in the bundle. A ref whose target is not in the bundle (outside a `--subject` scope, superseded, or `--facts none`) is shown as text, never as a dangling link.
- A subject with no live fact and no descendant holding one gets no directory, so retracting its last fact removes it on the next publish.

Rules:

- **Slugs.** A subject directory is named by its name lowercased, every run of characters outside `a-z0-9` turned into one hyphen, leading and trailing hyphens trimmed, capped at 80 characters, `subject` if nothing remains. Subjects whose slugs collide are taken in tree order (name, kind, aliases, then id only as a last resort): the first keeps the slug and the rest get `-2`, `-3`, and so on, so the result depends on content, not on ids.
- **Content-addressed fact files.** `subjects/<slug>/facts/<words>-<key>.md` is named from the fact's content, not its random store id, so re-seeding or importing the same facts into a new store produces the same file names and a bundle committed to a repository does not churn. The `<key>` is the first 8 hex characters of the SHA-256 of the normalized text, declared key, kind and canonical data (refs and ids are excluded); the `<words>` are the first six words of the text, and no subject prefix is part of the file name (the directory carries it). Claims in subject files end in the bracketed key, linked to the file. Only facts whose keys collide are widened to 12, then 16, characters. Each fact file carries a `Store id:` line, and `manifest.json` maps each key to its store id and path.
- **Assets.** Attachment bytes are copied from `blobs/<sha256>` (next to the database) to `subjects/<slug>/assets/<sha8>-<file-stem>.<ext>`: `sha8` is the first 8 hex characters of the blob's sha256, the stem is the attachment file name without extension (slugified like fact files, at most 40 characters, `asset` if empty), and the extension is the file's own lowercased, else derived from the mime type, else `bin`. Names depend only on the attachment, so independent stores agree. A blob used by two subjects is copied once per subject, deliberately duplicating bytes so each subject directory is self-contained. Subject files get an `Assets` section and fact files an `Attachments` section; **every link is relative to the file it is written in**: `assets/<file>` from the subject's `index.md` and `../assets/<file>` from one of its fact files. `manifest.json` gains an `assets` map keyed by the asset's bundle path with `{sha256, bytes, mime, missing}`. Republishing removes asset files it generated earlier and no longer needs, by the same manifest rule as markdown, and never a file it did not generate. `--assets none` writes no assets directories and lists attachments by sha256 with no link.
- **Missing blobs are fail-open.** If `blobs/<sha256>` does not exist, publish still writes the markdown, renders the entry as `MISSING <sha256>`, creates no asset file, records `{sha256, missing: true}` in the manifest, prints a warning line to stderr and exits 0. (A file in the output directory that the bundle did not generate is different: that still refuses, before writing anything.)
- **Fact text is never truncated.** Fact files hold the full text. With `--depth index` the subject files use the compile's one-line index form, but fact files stay complete.
- **Idempotent and repo-safe.** Identical inputs produce byte-identical files and unchanged files are not rewritten. The README timestamp is kept while the rest of the bundle is unchanged. Files the previous run listed in `manifest.json` that are no longer produced (a retracted fact) are removed; any other file in the directory is never deleted. If a path the bundle needs is already held by a file it did not generate, the run fails before writing anything.
- **Order is content-derived.** Subjects are ordered as a tree by name, kind and aliases; facts by key, kind, text and content hash; ids break ties only after every content key.
- **Machine record.** Every fact file ends with a `## Machine record` heading and one fenced `json` block holding the canonical record of the fact: `id`, `subject_id`, `subject_name`, `key`, `kind`, `text`, `data`, `items`, `tags`, `confidence`, `status`, `provenance` (`actor`, `actor_type`, `channel`, `origin`, `posted_at`), `refs` (`rel`, `kind`, `target`, `locator`, `basis`, `confidence`, `rev`, `snapshot`, `snapshot_hash`, `etag`, `verified_at`, `valid`) and `attachments` (`sha256`, `filename`, `mime`, `bytes`, `perceptual`), with contract field names, keys sorted at every level and nulls omitted. A ref target is the original, unmodified target (a `fact` ref carries the fact id, not the bundle key shown in the prose) and the declared `key` is printed. The block is authoritative; the prose above it is the view. `manifest.json`'s `subjects` map also carries each subject's `aliases`, `parent` (when the parent is in the bundle) and `pin`.

### Import: rebuild a store from a bundle

`dossier import --from <bundle dir> [--db <path>]` reads every fact file's machine record and reconstructs the store: subjects first (name, kind, parent, aliases and pin from the manifest's subject map), then facts with their **original ids**, then refs with their original targets, then attachments, copied from the subject's `assets/` directory into `blobs/<sha256>` next to the database (bytes that do not hash to the recorded sha256 are not copied). Import inserts ids verbatim instead of generating them, still enforces the live-slot rule (two live facts claiming the same subject, kind and key abort the import naming both ids), writes everything in one transaction, and refuses to overwrite a subject or fact id already in the target store, so use an empty database. It prints a manifest as JSON: `subjects`, `facts`, `refs`, `attachments`, `blobs` and `skipped` (each skipped record with its path and reason, for example a fact file with no machine record or attachment bytes missing from the bundle).

**Round tripping requires `--facts detail` (the default).** A bundle published with `--facts none` has no fact files, so import fails closed and says so. Publish, import into a fresh store and publish again yields the same bundle file for file apart from the README's `Generated at` line (given the same recorded command line); `bash scripts/publish-demo.sh` output was checked this way. Only what a bundle holds is restored: superseded and retracted facts, and subjects with no live facts in their subtree, are not published and so not imported.

### Profiles and shards: publishing to a consumer's quotas

Some consumers cap how many files you can upload and degrade on tiny ones. Microsoft Copilot Studio, for example, accepts 500 uploaded files per agent and falls back to document-level citations for files under about 4 KB, while a Django-sized bundle is over a thousand files of 1-2 KB. A **profile** is a small JSON file of limits; publish checks the bundle against it and, with `--respect-limits`, repacks it to fit.

```sh
dotnet src/Dossier/bin/Release/net10.0/Dossier.dll publish --out out --profile profiles/copilot-studio.json                    # normal bundle + compliance table
dotnet src/Dossier/bin/Release/net10.0/Dossier.dll publish --out out --profile profiles/copilot-studio.json --respect-limits   # shards + compliance table
```

`profiles/copilot-studio.json` (Microsoft Learn, "Quotas and limits", <https://learn.microsoft.com/en-us/microsoft-copilot-studio/requirements-quotas>, retrieved 2026-11-09) holds `max_files` 500, `min_file_bytes` 4096, `max_file_bytes` 536870912, `max_total_bytes` 0 (unbounded: the page states no total), `allowed_extensions` doc, docx, xls, xlsx, ppt, pptx, pdf, `max_path_depth` 10, plus `source_url`, `retrieved` and a `note`. `profiles/generic-large.json` (5000 files, no size floor, `md` allowed) shows the mechanism is not Microsoft-specific. Every limit is optional; `0` means unbounded (no floor for `min_file_bytes`) and an absent `allowed_extensions` accepts anything. An unknown key or a wrongly typed field makes publish exit non-zero naming the field, before anything is written.

**Compliance table.** With `--profile`, publish prints one row per limit (`max_files`, `min_file_bytes`, `max_file_bytes`, `max_total_bytes`, `allowed_extensions`, `max_path_depth`): allowed, actual and PASS/FAIL, then `overall`. It measures what a consumer would upload: the whole bundle except `manifest.json` for a normal publish, the `shards/` documents in shard mode (the index, `AGENTS.md`, `README.md`, `conflicts.md`, `gaps.md` and `manifest.json` are navigation aids for a reader of the repository and are not counted). `--profile` alone only reports; it exits 0 even when rows FAIL.

**`--respect-limits`** (requires `--profile`) writes shards instead of the subject tree. Subjects are taken in the bundle's deterministic tree order and packed into `shards/<n>.md`, at most `max_files` documents, each at least `min_file_bytes` where the corpus allows (a corpus smaller than the floor yields one short shard and the table says FAIL) and never above `max_file_bytes`. Each shard opens with front matter (`shard`, `of`, `subjects`, `fact_files: absent`), a table of contents of its subjects, then one section per subject whose anchor is the subject's slug (`<a id="<slug>"></a>`). Every index row, and the links in `conflicts.md` and `gaps.md`, point at `shards/<n>.md#<slug>`; parent and child links inside a shard are `#<slug>` or `<n>.md#<slug>`. Subject directories, fact files and assets are **not** written: fact keys are plain citations and attachments are listed by sha256. Shard boundaries depend only on subject content, so the same store and profile give identical bytes. If one subject's page cannot fit `max_file_bytes`, publish fails before writing and names the subject and its size.

`bash scripts/publish-profile-demo.sh` rebuilds a 1080-subject Django-shaped corpus from the committed `examples/django-bundle` manifest (no re-ingest), prints the table before and after, and writes `examples/django-shards/` (193 shards of 4104 to 7551 bytes). Against `copilot-studio.json` the shard bundle passes `max_files`, `min_file_bytes`, `max_file_bytes`, `max_total_bytes` and `max_path_depth`.

**The format gap.** Copilot Studio uploads accept doc, docx, xls, xlsx, ppt, pptx and pdf. The bundle is markdown, and no converter ships here, so the `allowed_extensions` row **FAILs** against `copilot-studio.json` even in shard mode (`unsupported: md (markdown)`). Sharding fixes the file cap and the size floor; converting the shards to a supported format (for example with pandoc) is a step you run before uploading. The profile reports the gap; it does not hide it.

## Surfaces

All three surfaces call the same core functions.

**CLI.** Commands: `init`, `dump`, `post`, `correlate`, `search`, `show`, `retract`, `dossier compile`, `publish`, `import`, `check`, `mcp`, `serve`. Examples against the seeded database (`d` is `dotnet src/Dossier/bin/Release/net10.0/Dossier.dll`):

```text
$ d search --q composer --subject Memos/Home --limit 2     # trimmed
{"total":9,"complete":false,"hits":[
  {"id":"4b2d39e9","kind":"element","text":"Home composer suggests @mentions as the user types a name.","status":"live","score":-1.83},
  {"id":"1c1cd226","kind":"element","text":"Home composer grows to at most 6 rows before it scrolls.","status":"live","score":-1.80}]}

$ d check --subject "memos home"                            # resolve + what is known, one call
{"subject":{"id":"…","name":"Memos/Home","kind":"subject","aliases":[],"facts":42,"match":"exact_name"},
 "summary":{"facts":42,"conflicts":3,"gaps":0,"top":[{"key":"…","text":"…"}]}}   # top: at most 8, text capped at 120 chars

$ d check --subject "memos home" --drafts drafts.json       # adds a verdict per draft: new|deduped|replaced + advisory near[] (up to 3 ids at Jaccard >= 0.85); writes nothing

$ d post --file payload.json --dry-run                      # same verdicts as a real post, nothing written
$ d search --q composer --subject Memos/Home --brief        # id, kind, status, first 120 chars of text; total/complete/next kept

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

**MCP.** `dossier mcp` serves newline-delimited JSON-RPC over stdio (protocol versions 2025-06-18, 2025-03-26, 2024-11-05). Seven tools: `dump`, `post_facts`, `correlate`, `search`, `get_fact`, `compile_dossier`, `check`. Resources: `dossier://subjects`, and the templates `dossier://subject/{id}` and `dossier://fact/{id}`. `post_facts` takes `dry_run`, `search` takes `brief`, and `check` takes `subject` and optional `drafts` (returns the subject with `match` of `exact_name`, `exact_alias`, `prefix` or `fuzzy`, a summary, and per-draft verdicts with an advisory `near` list; a near duplicate posted anyway is a separate `new` fact). Tool descriptions mark fact text as untrusted data that must never be followed as instructions.

**Web.** `dossier serve [--port 8787]` serves a minimal page on `http://127.0.0.1:<port>/` (loopback only). It has a search box in the header, a subject list, search results, a compiled dossier view with its raw JSON, and a single-fact view. JSON endpoints: `/api/subjects`, `/api/search`, `/api/compile`, `/api/fact`.

## Architecture

One project, `src/Dossier/Dossier.csproj`: C# on net10.0, SQLite (WAL) with FTS5, raw ADO.NET, no ORM, no DI container. Core operations are plain functions over a `DossierStore`, and the CLI, MCP and web layers are thin transports over them. The core has no models and no network. The only package dependency is `Microsoft.Data.Sqlite`. Tests are TUnit on Microsoft.Testing.Platform.

| File | Owns |
| --- | --- |
| `Models.cs` | Request, response and domain types |
| `Store.cs` | `DossierStore`: the SQLite connection, schema and FTS5 index |
| `PostFacts.cs` | Writes: resolution order (declared supersede, hash dedupe, insert), refs, attachments |
| `Dump.cs` | Deterministic ingest, the markdown splitter and the Python code splitter |
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
SECURITY.md        security policy: how to report a vulnerability
LICENSE            MIT license for Dossier
THIRD-PARTY-NOTICES.md  notices for components shipped in release archives
.github/           CI (ci.yml) and the tag-triggered AOT release workflow (release.yml)
assets/            icon
contract/          JSON Schemas: subject, fact, ref, ops, dossier (the normative shapes)
docs/PLAN.md       hypothesis, kill criterion, invariants, measured results
examples/          memos-bundle/, django-bundle/, django-models-bundle/, django-shards/: committed publish outputs
profiles/          consumer quota profiles for publish --profile (copilot-studio.json, generic-large.json)
scripts/           seed.sh, e2e.sh, eval.sh, scaling.sh, scale-test.sh, verify-refs.sh, publish-demo.sh, publish-profile-demo.sh
scripts/dump-code-demo.sh  demo: dump a source file into linked facts
scripts/smoke-aot.sh       smoke-test a published Native AOT binary
scripts/seed/      the Memos demo corpus and a notes.md for dump
scripts/eval/      questions.json, sources.json; artifacts/ is git-ignored output
skills/dossier/    SKILL.md: how an agent uses Dossier well (the loop, rules, commands)
src/Dossier/       the reference implementation
tests/Dossier.Tests/  210 TUnit tests
```

## Releases

To cut a release, tag a commit that is on `main` and push the tag:

```sh
git tag v1.2.3
git push origin v1.2.3
```

The tag must look like `vMAJOR.MINOR.PATCH` with an optional prerelease suffix (`v1.2.3-rc.1`; a suffix marks the GitHub release as a prerelease). The release workflow builds Native AOT binaries, smoke-tests each one, and publishes a GitHub release with these assets:

- `dossier-<version>-linux-x64.tar.gz`
- `dossier-<version>-osx-arm64.tar.gz`
- `dossier-<version>-win-x64.zip`
- `SHA256SUMS`

Each archive holds the `dossier` binary (`dossier.exe` on Windows), the native SQLite library, this README, `LICENSE`, `THIRD-PARTY-NOTICES.md`, and `dotnet-runtime-THIRD-PARTY-NOTICES.TXT` (the .NET runtime's own notices). Keep the native SQLite library beside the binary; the binary does not run without it. Verify a download against `SHA256SUMS` in the same directory:

```sh
sha256sum -c --ignore-missing SHA256SUMS      # Linux
shasum -a 256 -c --ignore-missing SHA256SUMS  # macOS
```

Platform notes:

- Linux binaries are built on Ubuntu 22.04 and need glibc 2.35 or newer, `libicu`, and OpenSSL (`libssl3` or `libssl1.1`).
- macOS binaries are unsigned. If Gatekeeper blocks the binary, remove the quarantine flag from the whole extracted directory (it also lands on `libe_sqlite3.dylib`): `xattr -dr com.apple.quarantine <extracted dir>`.

## Reproducing the evaluation

```sh
bash scripts/e2e.sh          # seed a temp DB and exercise every surface of the loop
bash scripts/eval.sh         # arms A, A2, B and C token counts (arm C fetches from raw.githubusercontent.com)
bash scripts/scaling.sh      # the N=50/200/1000 bounded-cost table
bash scripts/verify-refs.sh  # fails unless every seeded git ref resolves with HTTP 200
```

All scripts need bash, `jq` and a Release build. `dotnet test` runs the 210 tests.

## Status

Done (Gate A): dump, post with declared refs, the two matchers, reverse `ref_target` search, search, compile, MCP, minimal web; 210 passing tests; the seeded Memos demo; the evaluation harness.

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

## License

MIT, see [LICENSE](LICENSE). Third-party notices are in [THIRD-PARTY-NOTICES.md](THIRD-PARTY-NOTICES.md) and are included in every release archive.
