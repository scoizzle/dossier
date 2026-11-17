# Epic 14: structured code ingestion — implementation plan

Status: proposed for sign-off, 2026-11-17. Back to the [README](../../../README.md).
Tracking epic: [#14](https://github.com/scoizzle/dossier/issues/14). Sub-issues:
[#15](https://github.com/scoizzle/dossier/issues/15) to
[#22](https://github.com/scoizzle/dossier/issues/22).

This directory turns each sub-issue into an implementable plan: the premise checked
against `main` at `ee9469e1`, the design and the decisions it needs, the exact files
it edits, the test that goes red first, and the evidence that closes it. The
sub-issue bodies say *what* and *done when*; these files say *how* and *in what
order*.

| Story | Issue | Plan | Tier | Depends on | Verdict on `main` |
| --- | --- | --- | --- | --- | --- |
| 0. MCP dump description | #15 | [00-mcp-dump-description.md](00-mcp-dump-description.md) | T0 | none | **Already satisfied** |
| 1. Outline contract | #16 | [01-outline-contract.md](01-outline-contract.md) | T2 | none | Ready |
| 2. Provider interface | #17 | [02-provider-interface.md](02-provider-interface.md) | T1 | 1 | **Premise stale** (no Python scanner) |
| 3. C# provider | #18 | [03-csharp-provider.md](03-csharp-provider.md) | T2 | 2 | Ready, two blockers |
| 4. Bulk ingest | #19 | [04-bulk-ingest.md](04-bulk-ingest.md) | T2 | none | Ready; one done-when is void |
| 5. Resolvable citations | #20 | [05-resolvable-citations.md](05-resolvable-citations.md) | T2 | 1 | Ready |
| 6. External provider protocol | #21 | [06-external-provider.md](06-external-provider.md) | T2 | 1, 2 | Ready; fallback wording stale |
| 7. Task-oriented evaluation | #22 | [07-task-oriented-evaluation.md](07-task-oriented-evaluation.md) | T1 | 3, 4 | Ready |

## What changed since the epic was written

The epic and all eight sub-issues were written on 2026-11-11 against the tree that
still had a Python paragraph/code splitter. That code is gone.

| Epic assumption | `main` today | Evidence |
| --- | --- | --- |
| `dump` has a Python code splitter (`ScanPython`, `Dump.cs:718`) | No scanner and no `code`/`paragraph` split. Splits are `heading`, `file`, `none`. | `src/Dossier/Dump.cs:53`, `:219-226`, `:234-258`; `grep -rn ScanPython src` returns nothing; `git log -1 1e2005d1` ("dump: drop paragraph/code split; add symbol documentation loop to skill") |
| Fallback is "to paragraph" (stories 3, 6) | There is no paragraph split. The whole-file chunk (`file`) is the only non-heading fallback. | `src/Dossier/Dump.cs:239-245` |
| MCP `dump` claims "file or directory" (`Mcp.cs:209`) | Already says "Chunk a file into facts…", and the schema requires one `source`. Story 0 is done. | `src/Dossier/Mcp.cs:280-281` |
| `scripts/dump-code-demo.sh` has a per-file loop (story 4) | The script was deleted with the splitter. The story's third done-when has nothing to replace. | `test -e scripts/dump-code-demo.sh` → absent; `git show 1e2005d1 --stat` |
| `dump` "extracts nothing"; symbols are documented by hand into subject trees | Still the documented skill doctrine, and it is the deliberate replacement for code split. Stories 2, 3, 6 and 7 reverse part of that decision. | `skills/dossier/SKILL.md:35` ("it extracts nothing"), skill step 2 ("identify its semantic symbols") |
| `docs/cli.md:9` says "code split is Python-only" | `docs/cli.md:7` documents only `heading`, `file` and `none`, and `invalid_split` for anything else. | `docs/cli.md:7` |
| Story 3 line references (`DumpTests.cs:224-461`, `Dump.cs:75`) | `DumpTests.cs` is 356 lines and has 17 tests, none named `CodeSplit_*`. | `wc -l tests/Dossier.Tests/DumpTests.cs`; `grep -n "public async Task" tests/Dossier.Tests/DumpTests.cs` |

Two consequences follow, and they are the first thing to settle:

1. **Story 2 is not a refactor of a Python scanner.** It is the introduction of a
   seam that has no second implementation yet. Its value is as the seam stories 3
   and 6 plug into, and its oracle is "all 17 `DumpTests` pass with no test edits",
   which is still true and still worth pinning.
2. **The epic now contradicts a deliberate product decision.** `1e2005d1` removed
   code split and replaced it with a human/agent symbol-documentation loop ([D4](#decisions)).
   Landing story 3 without updating `skills/dossier/SKILL.md` would ship two
   contradictory stories of what `dump` is for.

## Decisions

Each decision is recorded with a recommendation so implementation can proceed; the
ones marked **sign-off** need the repository owner, and a plan below that depends on
one cannot start until it is answered. The two open questions from the epic table
(Locator end line, qualified-name format) are D1 and D2.

| ID | Decision | Recommendation | Blocks |
| --- | --- | --- | --- |
| D1 | Locator `end_line` or keep `L<start>-L<end>` selector | **Keep `line` + `selector`; do not widen `Locator`.** Outline nodes carry `start_line`/`end_line`, and code facts also put them in `data`. Story 5 parses the selector only in the exact form dossier writes. | 1, 5 |
| D2 | Qualified-name format and overloads | `<namespace>.<type>[.<nested>].<member>(<param-types>)`; no spaces; `.ctor(...)`, `.cctor()`, indexers `.this[...]`; generic arity as ``Box`1``; **canonical** parameter types (fully qualified, predefined types normalized, `T`); conversions append `-> Target`; partial types merge into one node. | 1, 3, 6 |
| D3 | Where the syntax-error count lives | `data.parse_errors` (integer, present only when > 0). `data` is open JSON, so no schema change. Same record carries `symbol`, `entity_kind`, `parent`, `start_line`, `end_line`. | 1, 3 |
| D4 | Does `dump` get a `code` split at all? This decides whether the epic proceeds. | **Yes, but opt-in:** `--split code` only, never a default; update `skills/dossier/SKILL.md` and `docs/cli.md` in the same change so "dump preserves bytes" and "dump can outline" are not two contradictory claims. The skill keeps the rule that an outline is not a claim. **Sign-off required.** If no: close #16–#18 and #21–#22 and keep #19. | all |
| D4b | Does the epic still ship a built-in Python provider? | **No.** The scanner was removed in `1e2005d1`; nothing later in the epic needs it. Drop it from #14's principle and record the removal. Adding one back is a new sub-issue (hand-written scanner, no oracle), not a refactor. | 2 |
| D5 | Roslyn versus the Native AOT release | **Spike both release RIDs before committing to story 3**; a clean macOS build proves nothing about linux-arm64, and runtime reflection failures carry no ILC warning. If it fails: a managed-only provider is simplest (AOT always uses story 6), otherwise gate on an explicit `EnableRoslynOutline=false` at restore **and** publish, never on `PublishAot`. **Sign-off required** if the spike fails. | 3, 7 |
| D6 | Classification tags: fact `tags` or a new field | **Fact tags**, namespaced `class:test`, `class:fixture`, `class:demo`, `class:generated`. No schema change, filterable with `search --tag`, visible in the bundle. | 4 |
| D7 | Where the revision comes from | `--rev` wins; with `--source-root`, fall back to `git -C <root> rev-parse HEAD` and fail soft (no rev, no rewrite) when git is absent. Stored on the `derived_from` ref's existing `rev`. | 4, 5 |
| D8 | External provider wire shape and invocation | One process per file, one JSON line in and one out; configured only by explicit flags or `DOSSIER_OUTLINE_PROVIDER`; default 5 s timeout, 8 MiB stdout cap. | 6 |
| DE1 | Symbol refs and fact identity | **No `symbol` ref and no flag in story 3.** Its target embeds the revision and would churn fact identity; `data.symbol` already carries the name. Document the broader churn (`rev` plus the locator also feed the hash) as a known limit and a follow-up issue. | 3, 4, 7 |
| D9 | How story 7 scores correctness without an LLM | Mechanical grading against `supporting_fragments` plus citation resolution and token counts, with an optional `--answers` file for a person/agent to supply prose answers. No model calls in the harness. | 7 |

## Order and pull requests

The epic's order holds, with one change: **2 and 3 ship together** unless the owner
wants a pure-refactor PR. A seam with one implementation and no new split value is
dead weight in review, and story 3 is what proves the seam.

```text
PR A  story 0 (test only; close #15)                    — can land any time
PR B  story 1 (schema + docs)                            — blocks 5 and 6
PR C  stories 2 + 3 (seam + C# provider + D4/D5)         — blocks 7
PR D  story 4 (bulk ingest)                              — independent of B/C except `code` rules
PR E  story 5 (citation rewrite)                         — after B
PR F  story 6 (external provider)                        — after C (needs a second provider to fall back from)
PR G  story 7 (evaluation)                               — after C and D
```

`suggest landing B, C and D first`: they remove the two pains the external
evaluation reported (paragraph facts from a C# file, one process per file).

## Cross-cutting risks

- **Scope and doctrine (highest).** D4 asks the owner to re-open a decision made on
  2026-11-11. Do not implement around it; an unreviewed split is worse than no split.
- **AOT and the dependency.** `Microsoft.CodeAnalysis.CSharp` 5.12.0 is MIT, 12.4 MB
  (plus `Microsoft.CodeAnalysis.Common` 4.6 MB), and its `net10.0` dependency group
  adds only `Microsoft.CodeAnalysis.Common` (the analyzers package is build-time).
  The package is not AOT-annotated; D5's spike is the gate, not a formality.
- **The 240-character fact rule.** `contract/fact.schema.json` says text is soft-capped
  at 240 and never truncated; some XML summaries and signatures exceed it. Story 3
  must emit signature (short) as `text` and the summary as `items`, or accept a
  `doc_truncated` marker; it must not silently truncate. This is a story-3 design
  detail, not an epic change.
- **Publishing is a contract.** Story 5 rewrites text dossier does not own. Keep the
  rewrite mechanical, record the original in the machine record (`docs/publish.md:52`
  already declares the prose a view and the record authoritative), and pin a
  no-rewrite path so a bundle never gains a link it cannot resolve.
- **Determinism.** Stories 4, 5 and 7 all compare runs. No timestamps, no filesystem
  order, no absolute paths in reports; `git rev-parse` is the only ambient input and
  it is recorded, not hidden.

## Definition of done, per story

Every story closes with the same shape of evidence, recorded in the PR:

1. The red check, run first: the new test name and its failing output (or, for a
   pure refactor, the unchanged oracle and an empty test diff).
2. The green check: the CI command from `CONTRIBUTING.md`
   (`dotnet test --solution Dossier.sln -c Release --no-build`), plus the story's
   named command and the file it writes.
3. `git status --short` and the commit the evidence belongs to.
4. For D4/D5, a line in the PR that names the approved decision.
