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

- **dump** `({ source, subject, kind?, split?: "heading"|"paragraph"|"file"|"none", tags? })` => `{ created[], deduped[], skipped[{locator, reason}], errors[] }`. v0 ships exactly ONE splitter (markdown headings/paragraphs). Raw input is stored as a content-addressed blob before parsing. Deterministic, idempotent, manifest-returning. No truncation.
- **post_facts** `({ idempotency_key?, subject: {name,kind?,parent?,aliases?}|{id}, redact?: string[], facts: [{ key?, local_id?, kind, text, data?, items?, tags?, confidence?, refs?, attachments? }] })` => `{ subject: {id,name,created,parent?}, facts: [{id, status: "new"|"deduped"|"replaced"|"near_duplicate", replaced?, duplicate_of?}] }`
- **correlate** `({ subject?, matchers?: ["same_ref","shared_tag"] })` => `{ proposed[] }`. Deterministic matchers only; emits PROPOSED refs with basis "derived", never asserted.
- **search** `({ subject?, kind?, key?, tag?, actor?, status?, since?, q?, ref_target?, direction?: "in"|"out", limit?: 20, cursor? })` => `{ hits: [FactView], total, complete, refine?, next? }`
- **compile_dossier** `({ subject, descendants?, needs?, budget?, depth?: "index"|"full", order?: "rank"|"seq", rank?: {recency: 0..1}, follow?: {rels?, hops?: 1|2}, format?: "json"|"markdown" })` => **Dossier** `{ subject, depth, needs[], budget_tokens, used_tokens, facts, linked, conflicts, gaps, dropped, degraded?, self_check }`. `linked` comes from follow with a separate budget slice (~25%). `conflicts[].resolution` is always null.

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
- Three arms: A raw dump, B compiled dossier at <=25% tokens, C no context.
- Primary: B >= 90% of A's accuracy at <=25% of A's tokens.
- Secondary: citation precision >= 95% on 20 spot-checked claims; unsupported-claim rate 0; reverse-impact recall on the code domain; compile p95 < 1s at 20 facts.
- Report the estimator used for token counts.

### Measured results

Measured 2026-11-09 on the seeded subject `Memos/Home` (24 live facts), on a clean
temp DB. Token counts use the chars/4 estimator (`ceil(chars / 4)`).

| Arm | Context | Chars | Tokens (chars/4) | Facts |
| --- | --- | --- | --- | --- |
| A | `search` JSON, limit 100 | 5902 | 1476 | 24 |
| A2 | same facts as bare text, one line each, no ids or tags | 1483 | 371 | 24 |
| B | compiled dossier, budget 1200, depth full, markdown | 2830 | 708 | 24 |

Accuracy: two independent agents, one given only arm A and one given only arm B,
each with the ten questions in `scripts/eval/questions.json`, both scored 10/10.
Both answered all three contradiction questions as a conflict with both values,
and both answered both unanswerable questions `UNANSWERABLE`.

Outcome: the dossier matched the raw context on accuracy at 2.08x compression
against the JSON baseline (A/B). Against the plain-text baseline it does not
compress: A2 is 371 tokens and B is 708, so B is 190.8% of A2 (ratio A2/B 0.52).
The plain-text baseline is smaller than the dossier because citations cost
tokens, and the 25 percent target is **not** met. This is expected at 24 facts:
every fact is relevant to some question, so there is nothing to cut. Compression
can only be expected to matter as the fact count grows.

This does **not** prove the hypothesis. The hypothesis is untested at the scale
where it could hold, because a small corpus of all-relevant facts leaves a
budgeted compiler nothing to select away. The next experiment is a subject with
200 or more facts, where a fixed token budget forces selection and a raw dump
cannot fit.

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
