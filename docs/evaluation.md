# Evaluation

Measured results, what they do not prove, and how to reproduce them. The bounded-cost guarantee itself is in [concepts](concepts.md#the-guarantee-strict-mode). Back to the [README](../README.md).

## Measured results

Measured 2026-11-09 on the seeded subject `Memos/Home` (24 live facts) with `bash scripts/eval.sh`. The baseline is primary sources: the original git files and screenshots an agent would otherwise read. Token estimator: chars/4 for text, pixels/750 for images.

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

The project's success bar (at least 90% of raw-dump accuracy at no more than 25% of the tokens across both eval domains) is not yet established: only one domain has been measured.

## Fleet evaluation

Measured 2026-11-20 with `node scripts/fleet-eval.mjs` (defaults: four writer agents and one reader, 50 chains, 100 facts, 20 probes, seed 1). Every agent is a real `dossier mcp` process with its own identity, all on one database; the script calls no model, so each number is a property of the store, not of an agent. Rates carry a 95% Wilson score interval. Seeds 1 and 2 gave identical rates.

Each experiment answers one failure mode of memory shared by several agents (the sources are in [multi-agent](multi-agent.md#what-a-shared-store-owes-its-agents)).

| Experiment | Metric | Result | 95% CI |
| --- | --- | --- | --- |
| Provenance | depth-4 derivation chain reconstructed, each step by a different agent | 50/50 | [0.929, 1.000] |
| Provenance | writer identity preserved at every hop | 50/50 | [0.929, 1.000] |
| Contradiction | both contradictory writes admitted (near-identical prose, different value) | 200/200 | [0.981, 1.000] |
| Contradiction | conflict surfaced in the compiled dossier, citing both facts | 200/200 | [0.981, 1.000] |
| Contradiction | declared dispute (`contradicts`): `verify` reports both facts contested | 100/100 | [0.963, 1.000] |
| Supersession | exactly one live value per slot after two writers (half of them concurrent) | 200/200 | [0.981, 1.000] |
| Supersession | more than one live row read for a slot | 0/200 | [0.000, 0.019] |
| Supersession | superseded fact returned by default search or compile | 0/200 | [0.000, 0.019] |
| Correction | another agent's `supersedes` ref takes effect, and `verify` names it as the replacement | 100/100 | [0.963, 1.000] |
| Correction | corrected fact returned by default search or compile | 0/100 | [0.000, 0.037] |
| Correction | old text and both writers still on record | 100/100 | [0.963, 1.000] |
| Correction | correction naming a fact that is not in the store is rejected | 100/100 | [0.963, 1.000] |
| Derivation currency | descendant of a changed input verifies stale, with the right input named | 120/120 | [0.969, 1.000] |
| Derivation currency | fact derived from a corrected claim verifies stale, naming the correction | 100/100 | [0.963, 1.000] |
| Derivation currency | false stale after a same-claim repost (control) | 0/30 | [0.000, 0.114] |
| Revocation | retracted fact, or its text, returned by search or compile | 0/20 | [0.000, 0.161] |
| Revocation | tombstone kept for audit (id and writer, no text) | 20/20 | [0.839, 1.000] |
| Propagation | write visible to another agent's cursor on its first poll | 20/20 | [0.839, 1.000] |
| Convergence | four agents post one keyed fact at once: one row, one id, nothing else journalled | 20/20 | [0.839, 1.000] |

Latency on one Apple-silicon laptop, one local SQLite file: `get_fact` per hop p50 0.3 ms, p95 below 1 ms (n=200, three runs); write-to-visible window p50 0.3 ms, p95 below 1 ms (n=20, three runs), which is one `changes` round trip, measured by polling each fact at once and one at a time from the moment its write returned.

Two rows are reported, not asserted:

- **The baseline `verify` replaces.** The 120 stale descendants all still read `live` by their own stored status (120/120), because a fact's row is never rewritten when its input changes. A check of the fact itself misses every one of them.
- **A known gap.** When two agents write different values to the same slot, the later write supersedes the earlier and the overwritten value is never surfaced as a conflict (0/200). It stays in history, and `verify` names what replaced it, but nothing flags that two agents disagreed.

**What this does not prove.**

- It is a self-evaluation of mechanism. No agent decided anything here, and research on agent memory finds that agents often fail to act on an update they did retrieve, so a correct label is necessary, not sufficient.
- Scoped access is not measured because it does not exist: every agent on a store reads all of it.
- Agent identity is the label a client sends. The run shows the label is preserved, not that it is true.
- It is one process group on one machine and one SQLite file, at hundreds of facts. Nothing here speaks to a networked store or to contention at scale; `scripts/live-demo.mjs` and `MultiWriterTests` cover concurrent writers.
- The harness can fail: with the same-claim rule or the keyed-repost dedupe removed, it exits 1 on the control and convergence rows.

## Reproducing the evaluation

```sh
bash scripts/e2e.sh          # seed a temp DB and exercise every surface of the loop
bash scripts/eval.sh         # arms A, A2, B and C token counts (arm C fetches from raw.githubusercontent.com)
bash scripts/scaling.sh      # the N=50/200/1000 bounded-cost table
bash scripts/verify-refs.sh  # fails unless every seeded git ref resolves with HTTP 200
node scripts/fleet-eval.mjs  # the fleet evaluation table; exits 1 if an expectation fails
```

The bash scripts need bash, `jq` and a Release build; `fleet-eval.mjs` needs Node 18+ and a Release build. `dotnet test` runs the test suite.
