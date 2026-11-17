# Story 7 — task-oriented evaluation

Issue: [#22](https://github.com/scoizzle/dossier/issues/22). Tier: T1 (a harness with a
named command as its oracle). Depends on: 3 (`#18`), 4 (`#19`).

## Premise check (`ee9469e1`)

- The existing harness measures *tokens*, not answers: `docs/evaluation.md` records arms
  A/A2/B/C for the seeded `Memos/Home` subject, and `scripts/eval.sh` never asks a
  question (`scripts/eval/questions.json` holds ten questions that two agents answered
  once, by hand; the script does not grade them). Its own "What this does not prove"
  section says so.
- Nothing in the repository ingests this repository, so there is no bundle to ask about.
  Story 4 creates one.
- Artifacts are gitignored (`scripts/eval/artifacts/.gitignore` = `*`), so scores that
  must survive per revision need a different home.

## Design

Two additions, no change to the existing arm results:

1. `scripts/eval/ingest-questions.json` — the question set for **this repository**.
2. `scripts/eval/ingest-eval.sh` — one command that builds the bundle at a revision,
   scores the question set mechanically, and writes `scripts/eval/scores/<rev>.json`
   (committed; the per-revision record the issue asks for).

The harness makes **no model calls** (D9). Correctness is graded from an answers file a
person or agent supplies, using the same deterministic rules every time; if no answers
are supplied, token and citation metrics are still recorded and `correct` is `null` with
`pending_answers: true`. That is honest: the one command always runs, and the score file
always records *something* per revision.

### The question set

Ten questions, in the three shapes the issue names. Every question has a deterministic
oracle, so a wrong answer is detectable without a judge.

```jsonc
{
  "set": "dossier-repo",
  "revision": "ee9469e1",
  "questions": [
    {
      "id": "q-dump-default-split",
      "kind": "locate",
      "question": "Which --split value does `dump` use by default for a .md file, and for everything else?",
      "expected_answer": "heading for .md/.markdown; file for everything else.",
      "supporting_fragments": ["heading", "file", ".markdown"],
      "required_paths": ["src/Dossier/Dump.cs"]
    },
    {
      "id": "q-split-values",
      "kind": "locate",
      "question": "Which --split values are accepted after story 3, and what happens to any other value?",
      "expected_answer": "heading, file, none, code; anything else is invalid_split in the manifest's errors, with no blob and no facts written.",
      "supporting_fragments": ["heading", "file", "none", "code", "invalid_split"],
      "required_paths": ["src/Dossier/Dump.cs", "contract/ops.schema.json"]
    },
    {
      "id": "q-symbol-target",
      "kind": "guarantee",
      "question": "What exact shape must a symbol ref target have, and what happens without the revision?",
      "expected_answer": "<qualified-name>@<revision>; a target without a non-empty revision is rejected with symbol_target_requires_revision.",
      "supporting_fragments": ["<qualified-name>@<revision>", "symbol_target_requires_revision"],
      "required_paths": ["contract/ref.schema.json", "src/Dossier/PostFacts.cs"]
    },
    {
      "id": "q-dump-callers",
      "kind": "callgraph",
      "question": "Which entry points reach DossierStore.Dump?",
      "expected_answer": "The CLI dump command, the MCP dump tool, and the bulk ingest path; all call the same core function.",
      "supporting_fragments": ["Program.cs", "Mcp.cs", "Dump"],
      "required_paths": ["src/Dossier/Program.cs", "src/Dossier/Mcp.cs", "src/Dossier/Dump.cs"]
    },
    {
      "id": "q-dedupe",
      "kind": "guarantee",
      "question": "What makes two posted facts dedupe instead of creating a second fact, and what is excluded from that hash?",
      "expected_answer": "A sha256 over normalized text, canonical data and sorted refs (kind,target,locator); rev, snapshot, etag and verified_at are excluded.",
      "supporting_fragments": ["sha256", "text", "data", "rev"],
      "required_paths": ["contract/fact.schema.json", "src/Dossier/ContentHash.cs"]
    },
    // ... six more: publish link guarantee, strict budget, MCP tool count,
    //     attachment path, slot resolution, graph node bounds.
  ]
}
```

Rules for the set:

- `required_paths` are repository paths at the pinned revision; the source arm reads
  exactly these, and a bundle citation is traceable only if its fact's `derived_from` path
  is one of them.
- `supporting_fragments` is a case-insensitive substring check on the supplied answer.
  Fragments must be things a correct answer cannot avoid (a name, a code), never prose.
- The set is pinned to a revision. When the questions themselves change, bump the set and
  say so in `docs/evaluation.md`; do not silently re-score old revisions.

### The scorer

For each question:

| Metric | How it is computed | Deterministic? |
| --- | --- | --- |
| `correct` | every `supporting_fragment` occurs in the answer (case-insensitive), and every supplied citation resolves | yes, given the answers file |
| `citation_traceable` | each citation (`<factId>` or `path:line`) resolves: the fact id is in `manifest.json.facts` and its `derived_from` path ∈ `required_paths`; a `path:line` must exist at that line | yes |
| `bundle_tokens` | `manifest.json.tokens["INDEX.md"]` + the cited facts' subject `index.md` tokens + the cited fact files' tokens (a reader walks index → subject → fact) | yes |
| `source_tokens` | `ceil(bytes/4)` over `required_paths` at the revision (the same estimator `eval.sh` uses) | yes |
| `ratio` | `bundle_tokens / source_tokens` | yes |

`manifest.json` already carries `facts` (`id` → `path`) and `tokens` per file (verified
against `examples/memos-bundle/manifest.json`), so no new bundle format is needed.
`scripts/eval/ingest-eval.sh` is bash + `jq` (already required by the other eval scripts);
keep the scoring logic in `scripts/eval/score-ingest.jq` so it is reviewable and testable
on a small fixture bundle. The jq program reads the bundle's `manifest.json`, the question
set and an answers object, and emits the score object; the shell script never parses JSON
itself.

Answers file (`--answers <path>`):

```json
{
  "revision": "ee9469e1…",
  "answers": {
    "q-split-values": {
      "answer": "heading, file, none and code; any other value gives invalid_split.",
      "citations": ["01986879", "src/Dossier/Dump.cs:234"]
    }
  }
}
```

### The command

```sh
bash scripts/eval/ingest-eval.sh            # record metrics; correctness null
bash scripts/eval/ingest-eval.sh --answers /tmp/answers.json
```

It does, in a temp `DOSSIER_DB` (never the user's store):

```sh
dotnet "$DLL" dump --source-root . --subject dossier-repo --rev "$(git rev-parse HEAD)" \
  --report "$WORK/report.json"
dotnet "$DLL" publish --out "$WORK/bundle" --subject dossier-repo \
  --source-url "https://github.com/scoizzle/dossier/blob/{rev}/{path}"
jq -f scripts/eval/score-ingest.jq --arg bundle "$WORK/bundle" \
  --arg questions scripts/eval/ingest-questions.json > "$WORK/score.json"
```

and writes `scripts/eval/scores/<short-rev>.json`: `revision`, `dirty`, `bundle_hash`
(from `manifest.json`), `question_set`, per-question metrics, and totals (`correct`,
`graded`, `mean_ratio`). A second run at the same revision rewrites the same file with
identical content; a dirty tree records `dirty: true` and the harness refuses to overwrite
a clean score with a dirty one (`--allow-dirty` overrides). Commit only clean scores.

### Red first

Before story 3/4, build the bundle with the current splitter and run the harness:

```sh
bash scripts/eval/ingest-eval.sh
# expected: locate/callgraph questions have no fact whose derived_from path is
# required_paths, so citation_traceable is false for all of them and correct is
# null/false with the supplied answers; mean_ratio is recorded as worse than source.
```

That is the honest red — the harness measures the gap the epic describes, rather than
failing because a script is missing. Capture the `scores/<rev>.json` from that run in the
PR, then re-run after 3/4 and show the improvement. If the harness scores the same before
and after, it is not measuring the thing the issue asks for; stop and say so.

## Edits

| File | Change |
| --- | --- |
| `scripts/eval/ingest-questions.json` | New: ten questions, three shapes |
| `scripts/eval/ingest-eval.sh` | New: one command, temp DB, build + publish + score |
| `scripts/eval/score-ingest.jq` | New: the deterministic scorer |
| `scripts/eval/scores/<rev>.json` | New: the record, one per measured clean revision |
| `docs/evaluation.md` | New section "Task-oriented ingestion evaluation" after "Reproducing the evaluation": command, arms, metrics, what it does not prove (no judge; answers are supplied; one repository) |
| `docs/cli.md` | Only if story 5's `--source-url` needs a cross-reference; no new command |

Not in CI: the eval needs a Release build, a full ingest and a publish; it is a
before/after record like `scripts/eval.sh`, not a gate. Say so in `docs/evaluation.md`.

## Done-when evidence

| Claim | Evidence |
| --- | --- |
| The harness runs with one command | the command block above and its output on this repository |
| It records scores per revision | `scripts/eval/scores/<rev>.json`, committed; `git show --stat` |
| It measures the epic's question shapes | the question set (locate, callgraph, guarantee) and per-question `kind` in the score file |
| It is not vacuous | the before/after red run, both score files or both totals pasted in the PR |
| `docs/evaluation.md` extends, not rewrites, the existing results | a diff that adds a section and touches no measured number |

## Risks

- **A harness that only counts tokens repeats `eval.sh`.** The citation check and the
  answers file are the difference; if either is dropped, the story is not done.
- **Answers are an input, not an oracle.** A dishonest answers file can score 10/10. The
  score file records `answers_sha256` so a score can be audited against the answers that
  produced it.
- **`required_paths` churn** as code moves. Treat the question set as pinned to a revision;
  a new revision may need new paths, which is a set change, not a silent pass.
- **Bundle size for this repository.** A symbol outline of 3,234 files will be large;
  publishing all of it may be slow and the `index_max_tokens` default may split indexes.
  Use `--subject dossier-repo` and a full ingest; if publish exceeds a minute, record the
  time rather than shrinking the tree, and note it in `docs/evaluation.md`.
- **Scoring a bundle that is wrong for the wrong reason.** Check the report from story 4
  first: a skipped `src/**` would make every citation untraceable and look like a dossier
  failure.

## Size

~150 bash lines, ~120 jq lines, one question set, one score file, ~50 doc lines. No
product code. One PR after 3 and 4.
