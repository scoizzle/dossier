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

## Contract and implementation

The JSON Schemas in `contract/` are the normative shapes; the C# in this repository is a reference implementation of them. Nothing in the core is specific to any consumer, so another implementation of the same contract would interoperate.

## Design notes

Five foot-guns shaped the design; each is a decision, not an accident.

**Fact text is untrusted.** A dossier is read by an agent, so fact text is carried as delimited data, never as instructions and never executed. `dossier mcp` marks returned fact text as untrusted data that must never be followed as instructions, in the server instructions and in every tool description.

**Similarity never makes an edge.** Similarity is only a retrieval and ranking signal; the only edge is a ref carried by a fact, with an explicit basis. The graph therefore cannot fill with hallucinated links, because a relationship has to be declared to exist.

**Dedupe never merges silently.** Every write reports what it did: `new`, `deduped` with the existing fact id, or `replaced` with the id it superseded. Content-hash dedupe is scoped to one subject and never merges across subjects or declared keys, and correction is a new superseding fact, so every merge stays traceable.

**Conflicts are exempt from the budget.** The budget bounds the fact content; conflicts and gaps are never charged against it. A dossier whose conflicts alone exceed the budget overruns it, because a dossier that hides a contradiction to save tokens is worse than one that is over budget.

**Dossier facts never feed back in.** Compile skips the reserved kind `dossier` when it loads candidates, so a fact of that kind can never appear in a compiled dossier's output. Compiling is a read: the result is returned to the caller and is not itself written as a fact.
