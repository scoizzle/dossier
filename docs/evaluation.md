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
## Reproducing the evaluation

```sh
bash scripts/e2e.sh          # seed a temp DB and exercise every surface of the loop
bash scripts/eval.sh         # arms A, A2, B and C token counts (arm C fetches from raw.githubusercontent.com)
bash scripts/scaling.sh      # the N=50/200/1000 bounded-cost table
bash scripts/verify-refs.sh  # fails unless every seeded git ref resolves with HTTP 200
```

All scripts need bash, `jq` and a Release build. `dotnet test` runs the test suite.
