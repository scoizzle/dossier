# Dossier — Plan

## Hypothesis and kill criterion

**Hypothesis:** a compiled, cited dossier beats a raw dump at equal token budget on agent tasks.

**Kill criterion:** if the dossier does not reach >=90% of raw-dump task accuracy at <=25% of the tokens across both eval domains, the concept fails and Poly should not absorb it.

This is a POC with a planned integration into Poly. Poly is the target, never a dependency. **Falsification test:** if Dossier ever needs a Poly type (Domain, AnalysisResult, Session), the abstraction failed.

## What this is (three verbs)

Three verbs: **dump**, **correlate**, **retrieve**.

- **dump** — ingest raw material deterministically into facts.
- **correlate** — propose (never assert) refs between facts using deterministic matchers.
- **retrieve** — `search` and `compile_dossier`: find facts, or compile a cited, budgeted dossier.

## Non-goals

- No models and no network in the core.
- No second query engine; no consumer-specific fact shape; domain templates live outside the core.
- No EF Core, DI container, NuGet packages, or layered production architecture.
- No reference to Poly or any other repo.
- Not a vector store; no similarity-derived edges.

## Domain model

Three nouns plus one pointer. Normative shapes live in `contract/*.schema.json`.

- **Subject** `{ id, name, kind (open string, e.g. app|screen|repo|module|doc|process), parent? (subject id), aliases[] (string), pin? {repo, rev} }`
- **Fact** (immutable) `{ id, subject_id, kind (OPEN STRING, reserved value "dossier"), text, data?, items?, tags[], confidence (0..1), status (live|superseded|contested|retracted|stale), provenance {actor, actor_type (human|agent|tool), channel (cli|mcp|api), origin?, posted_at}, content_hash }`
  - `Fact.key?: string` — a declared slot. Unique per (subject_id, kind, key) among live facts.
  - `Fact.items?: [{ key?, text, locator? }]` — optional compound sub-assertions; allowed on ANY fact.
- **Ref** (the only edge, carried by a fact) `{ rel, kind, target, locator?, basis, confidence?, seq?, rev?, snapshot?, snapshot_hash?, etag?, verified_at?, valid? }`
  - `rel`: about | mentions | contains | supersedes | contradicts | supports | derived_from | leads_to | confirms | refutes
  - `kind`: open string; INTERNAL kinds are exactly `fact | slot | subject`; every other kind is EXTERNAL (has freshness).
  - `target`: for kind=slot, `"<subjectIdOrName>#<key>"`; otherwise an opaque normalized string.
  - `locator`: `{ line?, symbol?, bbox? [x,y,w,h], selector?, item? }`
  - `basis`: observed | derived | inferred — REQUIRED on every ref.
  - `confidence`: 0..1 per ref; effective chain confidence = MIN over refs.
  - `seq`: integer ordering within a chain.
- **Attachment** `{ sha256, filename, mime, bytes, perceptual? {algo, value} }` — files on disk (`blobs/<sha256>`), never in the DB.

**FactView** is ONE object used by both search hits and dossier facts: `{ id, subject_id, kind, text, tags[], confidence, status, score? (search only), section? (dossier only) }` plus `cites` (fact ids) on dossier facts. Optional fields are null when not applicable.

## Lifecycle and resolution order

Hard invariants (rules):

1. Facts are immutable. Correction = a new fact with rel=supersedes.
2. status is DERIVED, never authoritative: superseded if a live fact supersedes it; contested if it has an unresolved refutes/contradicts; retracted if tombstoned; stale if the newest reverify disagrees.
3. Resolution order on write: (a) same (subject,kind,key) on a live fact => declared supersede, response status "replaced" + replaced id; (b) content_hash match => "deduped" + existing id; (c) insert => "new". Content hash NEVER merges across different keys.
4. content_hash = sha256 over normalized text + canonical JSON of data + sorted refs (kind,target,locator). EXCLUDES rev, snapshot, etag, verified_at.
5. text has a SOFT limit of 240 chars. Warn above 280. NEVER truncate.
6. kind is an open string. The engine branches on structure only: has data => conflict-eligible; has attachments => carries bytes; has refs => has edges. Never branch on the value of kind except the reserved "dossier".
7. Verification is fail-closed: reverify refuses to report "still" when snapshot_hash disagrees.
8. Retrieval is fail-open: a degraded compile returns the last good dossier plus an explicit degraded marker; it never errors out.
9. Zero models, zero network in the core. The client resolves rev/snapshot/etag and supplies them.
10. Absence is a fact: a scan: note fact is how "not scanned" is distinguished from "no references".
11. Dedupe scope is (subject_id, content_hash); content-hash dedupe never merges across subjects or across different keys.

## The three verbs

Shapes in `contract/ops.schema.json`.

- **dump** `({ source, subject, kind?, split?: "heading"|"paragraph"|"file"|"none", tags? })` => `{ created[], deduped[], skipped[{locator, reason}], errors[] }`. v0 ships the markdown splitter (headings/paragraphs); a later addition is `split: "code"` (Python only, see "Code split" below; the contract enum is not yet widened). Raw input is stored as a content-addressed blob before parsing. Deterministic, idempotent, manifest-returning. No truncation.
- **post_facts** `({ idempotency_key?, subject: {name,kind?,parent?,aliases?}|{id}, redact?: string[], facts: [{ key?, local_id?, kind, text, data?, items?, tags?, confidence?, refs?, attachments? }] })` => `{ subject: {id,name,created,parent?}, facts: [{id, status: "new"|"deduped"|"replaced"|"near_duplicate", replaced?, duplicate_of?}] }`
- **correlate** `({ subject?, matchers?: ["same_ref","shared_tag"] })` => `{ proposed[] }`. Deterministic matchers only; emits PROPOSED refs with basis "derived", never asserted.
- **search** `({ subject?, kind?, key?, tag?, actor?, status?, since?, q?, ref_target?, direction?: "in"|"out", limit?: 20, cursor? })` => `{ hits: [FactView], total, complete, refine?, next? }`
- **compile_dossier** `({ subject, descendants?, needs?, budget?, depth?: "index"|"full", order?: "rank"|"seq", rank?: {recency: 0..1}, follow?: {rels?, hops?: 1|2}, format?: "json"|"markdown" })` => **Dossier** `{ subject, depth, needs[], budget_tokens, used_tokens, facts, linked, conflicts, gaps, dropped, degraded?, self_check }`. `linked` comes from follow with a separate budget slice (~25%). `conflicts[].resolution` is always null.

### publish (CLI-only export, not a fourth verb)

`dossier publish --out <dir> [--subject s] [--budget 1200] [--depth full|index] [--facts detail|none]` renders the store as a markdown bundle for agents with no tool access. It calls `compile_dossier` once per subject (markdown, no descendants) and `show`-equivalent reads per fact; it changes no semantics and calls no model or network. It is a one-shot file writer, independent of MCP and the web surface.

Layout: `AGENTS.md` (entry point), `README.md`, `INDEX.md` (subject, kind, facts, conflicts, gaps, tokens, link; totals; conflicted subjects), `manifest.json`, `conflicts.md`, `gaps.md`, `subjects/<slug>.md`, and unless `--facts none`, `facts/<shortid>.md`. Drill-down: README -> INDEX -> subject -> fact. Every claim in a subject file ends in a bracketed fact id that is a link to its fact file.

Invariants:

- Output is a pure function of store content and options. Ordering uses content keys (subject name/kind/aliases, fact key/kind/text/content_hash); ids are last-resort tie-breaks. Fact ids themselves are random, so two stores built separately have the same structure but different fact file names.
- `manifest.json` has sorted keys and no timestamps; it lists every generated file and a `bundle_hash`. README's `Generated at` is carried over from the previous run while that hash is unchanged, so republishing is byte-identical.
- Republish removes only files the previous manifest listed; foreign files are preserved. A generated path occupied by a foreign file aborts before any write.
- Fact text is never truncated in fact files. Slugs: lowercase, runs of non `a-z0-9` to one hyphen, trimmed, 80 max, deterministic `-2`, `-3` suffixes on collision.
- `AGENTS.md` carries the untrusted-data warning and the staleness note (facts are pinned to the revisions in their files).

### import (the inverse of publish)

`dossier import --from <dir> [--db path]` rebuilds a store from a bundle. Each fact file ends with `## Machine record` and a fenced `json` block holding the canonical record (id, subject_id, subject_name, key, kind, text, data, items, tags, confidence, status, provenance, refs with their original targets, attachments); keys are sorted, nulls omitted, and the block is authoritative while the prose above it is the view. `manifest.json`'s subject map adds `aliases`, `parent` and `pin` so subjects can be rebuilt.

- Order: subjects, then facts with their original ids (inserted verbatim, `created_at` from `provenance.posted_at`, `content_hash` recomputed), then refs, then attachment rows and blobs copied from `subjects/<slug>/assets/` to `blobs/<sha256>` after the sha256 is verified. One transaction; nothing is written on failure.
- Fail closed: no fact files (the bundle was published with `--facts none`: round tripping requires `--facts detail`), two live facts claiming one (subject, kind, key) slot (names both ids), a duplicate fact id across files, or an id already present in the target store. A fact file with no or an unreadable machine record is skipped with its reason; the manifest printed on stdout lists subjects, facts, refs, attachments and blobs restored, and skipped records.
- Proof: publish A, import into a fresh store B, publish B: the two bundles are identical file for file apart from README's `Generated at` line (test `RoundTrip_PublishImportPublishIsIdentical`; also run on `examples/memos-bundle`).
- Not restored: superseded or retracted facts and subjects with no live facts in their subtree (never published), and ref `seq` gaps (order is kept).

## Failure policy

| Path | Policy | Behaviour |
| --- | --- | --- |
| write | fail closed | reject the item, name the reason |
| verify | fail closed | refuse "still" on hash mismatch |
| read / compile | fail open | last good dossier + degraded marker |

## Stack

- C#, net10.0, ONE project `src/Dossier/Dossier.csproj`, `dotnet run`.
- SQLite (WAL) + FTS5, raw ADO.NET. Attachments as files in `blobs/<sha256>`.
- No EF Core, no DI container, no NuGet packages, no Poly reference.
- Core operations are pure functions over a Store abstraction, so storage/transport/domain stay out of the core.
- Tests: TUnit 1.81.10 running on Microsoft.Testing.Platform.
- `global.json` sets `test.runner = Microsoft.Testing.Platform`; the .NET 10 SDK requires it for `dotnet test`.

## Gates

- **Gate A (this POC):** dump, post, declared refs, two matchers, reverse ref_target search, search, compile, MCP, minimal web.
- **Gate B (integration, NOT built now):** reverify, follow in compile, trust-gated supersede, contested/stale status computation, dump adapters.

## Evaluation

- Two domains: (1) Memos UI crawl (multi-modal, attested); (2) a repo module (Poly's native material).
- **Baseline: primary sources.** The alternative to Dossier is an agent opening the original artifacts itself: the git files and screenshots the facts were captured from. Search JSON and plain fact lines are not baselines; they are the product's own output, already compressed by capture.
- Arms: **C** primary sources (git files at the pinned rev plus screenshots at pixels/750), **A** `search` JSON, **A2** plain fact lines, **B** compiled dossier.
- Two-stage decomposition:
  1. **Stage one, capture:** primary artifact to cited fact (C to A2). Unmeasured before this run.
  2. **Stage two, compile:** fact set to budgeted dossier (A2 to B).
- The previous run measured only stage two (A/B and A2/B). At 24 facts stage two is a net loss: B is 708 tokens against 371 for A2 (190.8%), because citations cost tokens and every fact is relevant.
- Secondary: citation precision >= 95% on 20 spot-checked claims; unsupported-claim rate 0; reverse-impact recall on the code domain; compile p95 < 1s at 20 facts.
- Report the estimator used for token counts: chars/4 for text, pixels/750 for images. Also report the number of distinct primary artifacts, which is the number of read operations before an agent can answer.

### Measured results

Measured 2026-11-09 on the seeded subject `Memos/Home` (24 live facts), clean temp
DB, `bash scripts/eval.sh`. Arm C fetches from raw.githubusercontent.com (network
only for this measurement; failures print SKIPPED and exit 0).

Every seeded git ref now resolves. The pinned rev is the default-branch HEAD
`e4f3fb2d2d114f6eaea6ec75a10b0a274f57a8a1` (raw.githubusercontent.com does not
accept the short `e4f3fb2`), and the four cited paths were corrected to the real
components: `web/src/components/AppSidebar/AppSidebar.tsx` (header),
`web/src/components/MemoEditor/MemoEditor.tsx` (composer),
`web/src/components/PagedMemoList/PagedMemoList.tsx` (memo list) and
`web/src/pages/Home.tsx`. `bash scripts/verify-refs.sh` fetches each distinct ref
and fails unless every one is HTTP 200; the current run is 4 of 4 at 200.

| Arm | Context | Chars | Tokens | Facts |
| --- | --- | --- | --- | --- |
| C | primary sources: 4 of 4 files at the pinned rev (47940 chars, 11987 tokens) + 3 declared screenshots at 1440x900 (5184 tokens) | 47940 + images | 17171 | n/a |
| A | `search` JSON, limit 100 | 5902 | 1476 | 24 |
| A2 | same facts as bare text | 1483 | 371 | 24 |
| B | compiled dossier, budget 1200, full, markdown | 2830 | 708 | 24 |

Per-file arm C tokens (chars/4): AppSidebar.tsx 19271/4818, MemoEditor.tsx
9786/2447, PagedMemoList.tsx 14938/3735, Home.tsx 3945/987.

Ratios: B/C 0.04, B/A 0.48, B/A2 1.91. Arm C needs 7 distinct primary artifacts
(4 files + 3 screenshots), so an agent performs 7 read operations before answering;
the Dossier arms need 1. The screenshot count and 1440x900 size are declared in
`scripts/eval/sources.json`, not measured (the seeded PNG is a 1x1 placeholder),
and they supply 30 percent of arm C's tokens; the four source files supply the
other 70 percent.

Accuracy (unchanged): two agents given only arm A or only arm B scored 10/10 on
the ten questions in `scripts/eval/questions.json`, including all three
contradiction questions and both unanswerable ones. No agent has yet answered from
arm C.

Outcome: on tokens, B is smaller than C, at 0.04 of the measured total, so B beats
C by about 24x. Both halves of the two-stage framing are now measured: stage one
(primary sources to bare facts, C to A2) is 46x, and stage two (A2 to B) is a net
loss at 24 facts. The honest reading is that capture carries the compression (most
of it in the four source files, not only the declared screenshots) and compile
currently adds cost, while C's accuracy is still unmeasured. The hypothesis still
needs a subject with 200 or more facts, where a fixed token budget forces
selection.

### Reproducibility

For a given subject and budget, the dossier costs at most the budget regardless of corpus
size. Selection is deterministic for a given logical fact set and independent of fact id
assignment: ranking breaks score ties on content, never on the random fact id (score
descending, then key when present, kind, text, and content_hash last; applied to selected
facts, dropped, conflict values and `order: seq` ties). This boundedness, rather than any
single compression ratio, is the claim worth relying on. The 24-fact ratio above says
nothing about growth.

Ordering note: content_hash was intended as the first tie-break, but it hashes resolved ref
targets, which for fact-to-fact refs are random ids, so placed first it reintroduced id
dependence (found by `Reproducible_SelectionAcrossIndependentStores`). It is now the last
disambiguator.

Within one store, selection is id-independent and byte-stable: `Reproducible_SelectionAcrossIndependentStores`
and `Reproducible_RepeatedCompileIsByteIdentical` hold that half. The remaining cross-machine
dependence is recency: the recency term is derived from `created_at`, a wall-clock value set by
whichever machine posted the fact, so two stores holding the same logical facts posted hours
apart can rank differently at the default weight. Setting `rank.recency` to 0 removes the term
and is the reproducible mode; `Reproducible_WithRecencyDisabled_IgnoresWallClock` proves it by
compiling the same 40 logical facts with `created_at` offset six hours between two stores and
getting identical facts, dropped facts and `used_tokens`. `Recency_DefaultStillAffectsOrdering`
proves the other half: at the default weight, two otherwise-identical candidates differing only
in `created_at` rank the newer one first, so the mode is a deliberate choice and not a dead term.

Measured with `bash scripts/scaling.sh` (synthetic distinct facts on one subject, budget
1200, depth full, markdown, chars/4; two consecutive runs printed identical values):

| N | plain-facts tokens | dossier tokens | facts emitted | ratio plain/dossier |
| --- | --- | --- | --- | --- |
| 50 | 625 | 892 | 39 | 0.70 |
| 200 | 2500 | 892 | 39 | 2.80 |
| 1000 | 12500 | 892 | 39 | 14.01 |

The dossier cost is flat (892 tokens, under 1200) while plain facts grow linearly; the
ratio is a consequence of the bound, not the claim. Guarded by `Budget_IsBoundedAsCorpusGrows`.

### Scale test

`bash scripts/scale-test.sh` ingests django/django tag `6.1.3` (fetched from codeload into `$TMPDIR`, never vendored) through `dossier dump --split paragraph` (kind `doc` for `docs/**/*.txt`, `code` for `django/**/*.py`), stopping at 50,000 facts, then measures and publishes. Run on dotnet 10.0.403 at repo sha `4a386d9`, one machine, one run; absolute times are indicative.

| Measurement | Value |
| --- | --- |
| Files listed (docs `*.txt`, django `*.py`, top-level `*.md`) | 1588 |
| Files consumed / facts | 1230 / 50,013 (overshoots the limit by one file) |
| Subjects created (files that yielded at least one fact) | 1080 |
| Ingest wall clock / mean per file | 155.9 s / 126.7 ms |
| DB size / blobs | 82.9 MB / 9.8 MB in 1078 files |
| Compile latency, 20 seeded subjects (depth full, budget 1200, json) | p50 96 ms, p95 128 ms (range 90-150) |
| Compile of the largest subject (`docs/ref/models/querysets`, 1339 facts) | 284 ms, 866 tokens, 10 facts emitted, 1242 dropped |
| Conflicts across all 1080 subjects | 0 |
| Fact files a detail publish would write | 50,013 (over the 5000 cap, so published `--facts none`) |
| Bundle | 1086 files, 3,657,881 bytes, no fact files; `INDEX.md` 166,690 bytes |

Ten slowest files were all under 0.65 s, mostly `docs/ref/contrib/gis/*` and `docs/ref/forms/*` (e.g. `geoquerysets.txt` 0.625 s for 336 facts); the 0.4 s outlier `forms/index.txt` made only 4 facts, so it is noise, not size.

- What worked: the whole path (dump, compile, publish) handled 50k facts to completion (the script does not tally per-chunk `skipped`/`errors`, so those counts were not recorded), and every sampled compile stayed within budget (largest subject 866 of 1200 tokens with 99% of its facts dropped), consistent with the boundedness claim above. Publish time was not measured separately (the whole script took 4m34s).
- What was slow: ingest, at about 3.1 ms per fact, and almost entirely a per-file process cost (each dump is a fresh `dotnet` start plus a sqlite open; compile has a ~90 ms floor that is mostly runtime startup, not work). Reading all 1080 subjects for the conflict total took roughly two minutes.
- What was surprising: `publish --facts detail` writes a file for every live fact (50,013), not only the ones that survive the budget, so the bundle size is governed by corpus size, not by the token budget. Also the per-subject dossier for a paragraph-split reference page is a sample of ~10 paragraphs from 1300, so the selection signal is thin without keys or tags.
- What breaks: the conflict check is vacuous here (0 conflicts) because paragraphs carry no keys; a corpus without keyed claims cannot exercise conflict detection at this size. A 50k-file bundle, and a 167 KB `INDEX.md` (about 42k tokens by chars/4), already exceeds what an agent can read in one go, so the drill-down depends on grep rather than reading.
- What I would change: add a batch dump (many files in one process/transaction) so ingest is not bound by process startup; let `--facts detail` follow the budget or take a per-subject cap; paginate or shard `INDEX.md` by top-level directory; derive keys or tags from headings so paragraph facts can conflict and rank meaningfully; and add a corpus-level subject count and conflict total to the tool so they need not be summed by compiling each subject.

## Path to Poly

- The contract is the deliverable; the C# implementation is a reference implementation.
- Zero project references to Poly. If a Poly type is ever required, the abstraction failed.
- Frozen core, mirroring Poly's: no second query engine, no consumer-specific fact shape, domain templates live outside the core.
- Integration seam: Store interface (sqlite now, Poly persistence later); transports call the same core functions.

## Risks and foot-guns

Ranked:

1. Prompt injection via fact text when an agent reads a dossier.
2. Hallucinated edges from similarity.
3. Silent merge breaking traceability.
4. Budget hiding conflicts.
5. Dossier-as-fact recursion.
6. Confidence theatre.
7. Alias drift.
8. Screenshot rot.
9. Tokenizer drift.
10. Falling in love with the reference implementation.
11. C# tempting premature production architecture (EF/DI/layers).

## Open questions

- Subject granularity for non-UI domains.
- Temporal validity beyond supersession.
- Actor trust as static config.
- When extractive compilation stops being enough.

## End-to-end

The seeded demo lives in `scripts/seed/` and the evaluation harness in
`scripts/eval/`. Both scripts need only bash, jq, and the built DLL, and every
command calls `src/Dossier/bin/Release/net10.0/Dossier.dll` rather than `dotnet run`.
`DOSSIER_DB` selects the database; each script makes its own temp DB with
`mktemp` and removes it on exit.

`post_facts` carries exactly one subject, so the seed is five valid requests:
`memos-root.json` plus `memos-signin.json`, `memos-memodetail.json` and
`memos-archived.json`, and `memos.json` (the 24 Home facts the eval reads).
`scripts/seed.sh` posts all five and prints the created counts.

Reproduce the demo:

```sh
dotnet build -c Release src/Dossier/Dossier.csproj
bash scripts/e2e.sh
```

Measured on a clean temp DB (macOS, .NET 10.0.403):

- subjects created: 5 (Memos, Memos/SignIn, Memos/Home, Memos/MemoDetail, Memos/Archived)
- facts created: 32 (24 of them on Memos/Home)
- search total for `q=composer`: 9
- Memos/Home at depth full, budget 1200, markdown: 24 facts emitted (used_tokens 709)
- conflicts: `composerMaxRows` 6 vs 12, `headerHeight` 64 vs 72, `saveShortcut` Cmd+Enter vs Ctrl+Enter
- gaps for `billing invoice` and `webhook signature`: both `no fact`
- dump of `scripts/seed/notes.md`: first run created=4 deduped=0, second created=0 deduped=4
- correlate proposals for Memos/Home: 6

Reproduce the eval:

```sh
bash scripts/eval.sh
```

Measured on the same seed:

- arm A (raw search, limit 100): 5902 chars, 1476 tokens (chars/4), 24 facts
- arm A2 (same facts as bare text): 1483 chars, 371 tokens (chars/4), 24 facts
- arm B (compiled dossier, budget 1200, depth full, markdown): 2830 chars, 708 tokens (chars/4), 24 facts
- ratio A/B (tokens): 2.08, so B is about 48% of A
- ratio A2/B (tokens): 0.52, so B is 190.8% of A2

`docs/PLAN.md#measured-results` records the accuracy scores for these arms.

Ids are GUIDs, so arm B's exact bytes move by a few characters between fresh
databases; the counts above come from one real run.

`scripts/eval/questions.json` holds the 10-question set: 3 questions require a
contradiction to be noticed and 2 are unanswerable from the seed. The harness
writes `arm-a.json`, `arm-a2.txt` and `arm-b.md` under `scripts/eval/artifacts/`
(git-ignored).

## Code split (`--split code`, `--entity-subjects`)

Motivation: paragraph-splitting `django/db/models/query.py` gave 308 facts with no structure, and compile picked arbitrary ones (REPL snippets, directives). A Python module's real units are its classes and functions.

- `--split code` walks a Python file (`.py`/`.pyi`) and emits ONE fact per class, function, async function and method, at any depth, in source order (deterministic). Text = the signature without the trailing colon, whitespace collapsed; truncated at a word boundary to 240 characters with an ellipsis only when longer, and then tagged `signature_truncated`. No other fact text is truncated.
- `data`: `symbol` (dotted qualname), `entity_kind` (`class|function|async_function|method|static_method|class_method`), `parent` (enclosing qualname or module stem), `start_line` (first decorator line if decorated), `end_line`. `derived_from` locator: `line`, `selector` `L<start>-L<end>`, `symbol`. Tags: `entity:<kind>`, `decorator:<name>` per decorator, `async` for async defs (an async method is `method`), `signature_truncated`. The docstring's first paragraph is the single item.
- Nesting is by indentation: a method's parent is its class, a nested function's parent is the enclosing function. The module itself is not an entity.
- `--entity-subjects` (default off): each entity also becomes a subject `<module-subject>::<qualname>` with kind = `entity_kind` and parent = the module subject id; the entity fact is posted there, and the module subject gets one `contains` fact (ref `rel=contains`, `kind=subject`) per top-level entity.
- Limitation: **Python only.** Other files fall back to paragraph with `warning: split_fallback` in `errors`. Subject names are compared case-insensitively, so `Foo` and `foo` in one module share a subject; conditional redefinitions and property setters (`x` / `x.setter`) produce several facts for one qualname.
- Demo: `bash scripts/dump-code-demo.sh` ingests `django/db/models` (tag 6.1.3) into 45 modules, 2,630 facts and 2,228 subjects (385 classes, 1,662 methods, 88 functions, 43 class methods, 6 static methods, 3 async functions, 41 module subjects) and publishes `examples/django-models-bundle` (4,870 files). `examples/django-bundle` (paragraph split) is untouched. Module `django/db/models/query.py`: paragraph split = 308 facts / 1 subject; code split with entity subjects = 209 facts / 187 subjects (186 entities + the module).

