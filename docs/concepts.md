# Concepts

The model, its invariants, budget modes and the design notes behind Dossier. Back to the [README](../README.md).

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

## The model

| Noun | Meaning |
| --- | --- |
| Subject | The thing being described: `{ id, name, kind, parent?, aliases[], pin? }`. Kind is an open string such as app, screen, repo, module, doc. |
| Fact | One immutable, cited assertion about a subject: text, optional structured data, tags, confidence, status and provenance. Its `kind` is an open string. |
| Ref | The only edge, carried by a fact: `{ rel, kind, target, locator?, basis, ... }`. Internal targets are facts, slots and subjects; everything else is an external artifact. |
| Attachment | A file (screenshot, blob) addressed by sha256 and stored under `blobs/<sha256>`, never in the database. |

Invariants:

- Facts are immutable. Correction is a new fact that supersedes the old one, either by declared key (`subject`, `kind`, `key`) or by a `supersedes` ref of kind `fact` to its id (see [Correction](#correction)).
- Refs are the only edge. There are no similarity-derived edges.
- Every ref carries a basis of `observed`, `derived` or `inferred`.
- Ref kind `symbol` cites a symbol in an external static analysis. It is external (never a node, never an internal edge, no effect on centrality or ranking). Its target is `<qualified-name>@<revision>`, for example `django.db.models.QuerySet.filter@e4f3fb2d2d11`: the qualified name may contain dots, colons and parentheses, and the revision is everything after the last `@` and must be non-empty. A target without a revision is rejected with `symbol_target_requires_revision`, identically in `post`, `post --dry-run` and `check --drafts`. Basis `observed` is a runtime or human observation; basis `derived` is a citation of an analyzer's output, not an assertion of the referencing fact. If an observation disagrees with the analysis, post it with rel `refutes` against the symbol ref. `search --ref-target '<qualified>@<rev>' --direction in` returns every fact citing the symbol; `--direction out` still rejects it as external. Publish renders it as plain text, not a link.
- Status is derived, never stored authority. A stored fact holds only its lifecycle (live, superseded, retracted); stale and contested are derived from refs every time a fact is read (see [Derived status](#derived-status)).
- Fact text has a soft limit of 240 characters and is never truncated.
- Writes fail closed (the item is rejected with a reason); compile fails open (last good dossier plus a degraded marker).

The normative shapes are the JSON Schemas in `contract/` (`subject`, `fact`, `ref`, `ops`, `dossier`).

## Correction

There are two ways to replace a fact, and both keep the old row as history.

- **By key.** A post with the same subject, kind and key replaces the fact in that slot. Use it for an attribute you expect to change.
- **By ref.** A post that carries `{"rel": "supersedes", "kind": "fact", "target": "<id>"}` replaces that fact, keyed or not, on any subject. Use it to correct a claim that has no key, or one another writer posted. If the target held a slot, the slot is emptied, so a slot never points at a superseded fact.

Either way the old fact becomes `superseded`: it keeps its id, text and writer, `show` still returns it, and search and compile leave it out. `verify` on the old id returns `replaced_by`, the live fact at the end of its chain of successors.

Three limits, stated plainly:

- A `supersedes` ref must name a fact in the store, or the item is rejected with `supersedes_target_not_found`. A target that is already superseded or retracted is left as it is. A `supersedes` ref of any other kind (`slot`, a URL, a symbol) is stored and has no effect.
- Any writer can correct any fact, over MCP as well as the CLI. There is no trust check: see [multi-agent](multi-agent.md#not-covered).
- A corrected claim comes back if its source is dumped again. Dedupe compares a post with live facts only, so re-running `dossier dump` on an unchanged file creates the claim anew, under a new id, next to its correction. Correct the source first, or correct the new copy by its id.

A store written before corrections took effect may hold `supersedes` refs whose targets are still live. Nothing rewrites them on upgrade. Posting such a correction again returns `deduped` and applies it, naming the ids it flipped in `superseded`.

## Derived status

A stored fact is `live`, `superseded` (a keyed repost or a `supersedes` ref replaced it) or `retracted`. Two more statuses are derived from refs at read time and never written, so they cannot drift from the refs that cause them. Every read of a fact reports them, from one shared derivation: a search hit, a compiled dossier, `show` and `dossier verify <id>...` (MCP `verify_facts`) always agree.

| Status | Meaning |
| --- | --- |
| `stale` | A live fact with a `derived_from` ref of kind `fact` to a fact that was retracted, was superseded by a different claim, or is itself stale. Staleness is transitive and a derivation cycle terminates. |
| `contested` | A live fact that is not stale and that a live, non-stale fact refutes or contradicts (a ref of kind `fact`), or that itself carries `contradicts` to one. `contradicts` marks both facts; `refutes` marks only its target. |

Precedence is `retracted`, `superseded`, `stale`, `contested`, `live`; an id the store does not hold is `unknown`. A superseded answer carries `replaced_by`, and each stale or contested answer carries `why`: the input that changed and how, or the other party of the dispute.

Three rules keep the label honest:

- **A different claim, not a different row.** An input superseded by a repost with the same content hash (the same text, data and refs, say a tag-only repost) has not changed, so nothing derived from it goes stale. A correction by ref always counts as a change.
- **Exact inputs only.** A ref of kind `slot` follows whatever the slot holds now, so it names no exact input and never makes a fact stale or contested. Declare `derived_from` and `refutes` against a fact id. External refs (files, URLs, symbols) are outside this: checking them is reverify, which is not built.
- **A dispute lasts as long as the objection stands.** Retract or supersede the refuting fact, or let it go stale, and the fact it disputed is live again.

Data conflicts (two live facts whose `data` disagree) are reported in every dossier's conflicts, not as a status: a conflict slot is a bare field name across the whole subject, so unrelated facts can share one.

Where the status shows:

- **Search.** Each hit carries its derived status, and `--status` filters by it: `live` leaves out a fact that is stale or contested, and `stale` or `contested` returns exactly those, with exact totals and paging. With no `--status`, superseded and retracted facts are left out and everything else is returned, labelled.
- **Compile.** Each fact carries its status, and a stale or contested fact carries `why`. Every stale fact ranks after every fact that is not stale, and once strict mode has left a current fact out for size it takes no stale fact, so budget is never spent on a stale fact while a current one is waiting. In markdown a stale or contested line ends with the reason, for example `(stale: <input id> was superseded by <new id>)`; those ids are written bare, so a bracketed id is always the citation of an emitted fact.
- **`show`.** The fact's status, with `replaced_by` or `why`.
- **Stored status only.** A published bundle, the change journal and the graph view carry the stored lifecycle. A bundle holds live facts only, so a superseded input is not in it and a fact that was stale reads live once imported elsewhere.

Reading a fact that carries or receives no such ref costs one indexed lookup per page or subject. A filter on `live`, `stale` or `contested` classifies every fact in the store that has one; one measurement on a laptop took about 0.3 s for 5,000 of them. Each search, compile and `show` reads from a single snapshot, so a write that lands while it runs cannot make a filter and the labels on its hits disagree.

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

## Contract and implementation

The JSON Schemas in `contract/` are the normative shapes; the C# in this repository is a reference implementation of them. Nothing in the core is specific to any consumer, so another implementation of the same contract would interoperate.

## Design notes

Five foot-guns shaped the design; each is a decision, not an accident.

**Fact text is untrusted.** A dossier is read by an agent, so fact text is carried as delimited data, never as instructions and never executed. `dossier mcp` marks returned fact text as untrusted data that must never be followed as instructions, in the server instructions and in every tool description.

**Similarity never makes an edge.** Similarity is only a retrieval and ranking signal; the only edge is a ref carried by a fact, with an explicit basis. The graph therefore cannot fill with hallucinated links, because a relationship has to be declared to exist.

**Dedupe never merges silently.** Every write reports what it did: `new`, `deduped` with the existing fact id, or `replaced` with the id it superseded. Content-hash dedupe is scoped to one subject and never merges across subjects or declared keys, and correction is a new superseding fact, so every merge stays traceable. A keyed repost that is identical in every field is `deduped` and writes nothing, so several agents posting the same keyed fact converge on one row (the one exception is a deduped post whose `supersedes` ref still has a live target, which is applied: see [Correction](#correction)); a repost that changes anything, including a field the hash leaves out (tags, confidence, items, a ref's `rev` or `basis`, attachments), is `replaced`. Whichever the status, a post that flips a live target through a `supersedes` ref also reports those ids in `superseded`, so a deduped post never hides a correction it just applied.

**Conflicts are exempt from the budget.** The budget bounds the fact content; conflicts and gaps are never charged against it. A dossier whose conflicts alone exceed the budget overruns it, because a dossier that hides a contradiction to save tokens is worse than one that is over budget.

**Dossier facts never feed back in.** Compile skips the reserved kind `dossier` when it loads candidates, so a fact of that kind can never appear in a compiled dossier's output. Compiling is a read: the result is returned to the caller and is not itself written as a fact.
