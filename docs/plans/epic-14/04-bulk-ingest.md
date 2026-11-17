# Story 4 — bulk ingest

Issue: [#19](https://github.com/scoizzle/dossier/issues/19). Tier: T2 (CLI/MCP contract).
Depends on: none (uses story 3's `code` split when it exists). Blocks: 7.

## Premise check (`ee9469e1`)

- One file per call: `Dump` reads `request.Source` with `File.ReadAllBytes`
  (`src/Dossier/Dump.cs:57-80`); the CLI requires `--source` and `--subject`
  (`src/Dossier/Program.cs:65-87`). There is no `--source-root`, glob, manifest or report.
- The issue's third done-when — "`scripts/dump-code-demo.sh`'s per-file loop is replaced
  by one call" — is **void**: that script was deleted in `1e2005d1` along with the code
  splitter (`test -e scripts/dump-code-demo.sh` → absent). Do not recreate it just to
  replace a loop. The substitute evidence is the one-command run on this repository plus a
  deterministic report; `scripts/scale-test.sh:54-68` still has the same per-file loop, and
  migrating it is a follow-up (it assigns a subject per file, which bulk ingest does not
  do — see "Out of scope").
- The MCP description no longer claims "file or directory" (story 0); this story makes a
  directory true, so it updates that description again.
- `scripts/scale-test.sh` and `scripts/e2e.sh` use `dump --source`; both keep working
  because this story changes no single-file behaviour.

## Contract

### One `DumpRequest`, exactly one source

Keep one request shape and add the tree fields. `source` stops being required in the
schema; the runtime enforces exactly one of `source` / `source_root` and reports
`missing_source` or `both_source_and_source_root`. JSON Schema cannot express
"exactly one of", and the schema test validator supports no `oneOf`, so a cross-field
runtime rule (the pattern already used for symbol targets) is the honest place for it.

```jsonc
// DumpRequest additions
"source_root": "path",                 // tree to walk
"include": ["src/**", "docs/**"],      // default ["**"]
"exclude": ["**/bin/**"],              // additive to the built-in excludes
"rules":   [{"glob": "**/*.cs", "split": "code", "class": "source"}],
"classify":[{"glob": "**/tests/**", "class": "test"}],  // CLI sugar; merged into rules
"manifest": "path",                    // JSON file with include/exclude/rules/classify/rev
"report": "path",                      // write the run report here
"revision": "…",                       // optional; see D7
"max_file_bytes": 2097152              // default 2 MiB
```

CLI:

```sh
dossier dump --source-root . --subject dossier-repo \
  --include 'src/**' --include 'docs/**' \
  --exclude '**/bin/**' --rule '**/*.cs=code' --classify '**/tests/**=test' \
  --rev "$(git rev-parse HEAD)" --report /tmp/ingest-report.json
```

Each of `--include`, `--exclude`, `--rule`/`--classify` is repeatable; the manifest is read
first and the flags append/override (a rule with the same glob later wins). `--source` and
`--source-root` are mutually exclusive. Update `VerbSpec` for `"dump"`
(`src/Dossier/Program.cs:443`).

### Walk and determinism

- Enumerate regular files under `source_root` (never follow symlinks; skip a symlink with
  `reason: "symlink"`).
- Prune these directories before enumeration, always: `.git`, `.hg`, `.svn`, `bin`, `obj`,
  `node_modules`, `TestResults`, `.vs`, `out`, `dist`. A file inside a pruned directory is
  never reported: pruning happens before `seen`, and `--include 'bin/**'` cannot re-add it
  in this story. Document that limit; a caller who needs generated output ingests it as a
  separate `--source-root`.
- Sort entries by relative path with `StringComparer.Ordinal`, always. Paths in the report
  are relative, `/`-separated, never absolute.
- Glob grammar (implement once, in `src/Dossier/Glob.cs`): `*` matches within a segment,
  `**` crosses segments, `?` matches one character, patterns are case-sensitive on every
  OS. No brace expansion. Patterns without `/` match the file name anywhere. A trailing
  `/` matches everything below.
- Skip precedence, first match wins: `not_included`, `excluded`, `symlink`, `binary` (a
  NUL in the first 8 KiB), `too_large` (> `max_file_bytes`), `unreadable`, `parse_failed`,
  `too_short` (a chunk under 3 trimmed characters; a file with only short chunks still
  counts as ingested with `facts: 0`).
- A file matching no split rule uses `DefaultSplit` (`heading` for `.md`/`.markdown`,
  `file` otherwise). `code` is only used when a rule or `--split` asks for it.

### Classification (D6)

Classes are `source`, `test`, `fixture`, `demo`, `generated`. Each file gets at most one
class; the first matching rule wins; the defaults below apply only when no user rule
matched. The class becomes a fact tag `class:<name>` (`class:source` included, so the
absence of a tag never means "source"). Report fields carry the class.

Default rules, in order:

| Glob | Class |
| --- | --- |
| `**/bin/**`, `**/obj/**`, `**/dist/**`, `**/*.g.cs`, `**/*.generated.*`, `**/wwwroot/lib/**` | `generated` |
| `**/tests/**`, `**/*.Tests/**`, `**/*Tests.cs`, `**/test_*.py`, `**/*_test.py` | `test` |
| `**/fixtures/**`, `**/__snapshots__/**`, `scripts/seed/**` | `fixture` |
| `examples/**`, `**/demo/**`, `scripts/*demo*` | `demo` |
| (no match) | `source` |

A `generated` file is **not** excluded by default; it is tagged and reported, so a caller
can exclude it with `--exclude` or separate it after the fact. That is what the issue asks
("exclude or separate them"); silent exclusion would hide product files.

### The run report

`--report <path>` writes a single JSON object. It is the deterministic artifact the
done-when compares; the normal stdout `DumpResponse` keeps `created`/`deduped`.

```jsonc
{
  "format": 1,
  "source_root": ".",
  "revision": "ee9469e1…",       // null when unknown (D7)
  "dirty": false,                // null when git is unavailable or --rev was used
  "files": [
    {"path": "assets/icon.png", "split": null, "class": "generated", "facts": 0, "skipped": "binary"},
    {"path": "src/Dossier/Dump.cs", "split": "code", "class": "source", "facts": 12, "skipped": null}
  ],
  "totals": {
    "seen": 2, "ingested": 1, "skipped": 1, "facts": 12, "errors": 0,
    "by_reason": {"binary": 1},
    "by_class": {"generated": 1, "source": 1}
  },
  "errors": []
}
```

Rules for the report:

- `files` sorted by `path`; `by_reason`/`by_class` keys sorted; no timestamps, durations,
  absolute paths, or machine names. `seen` counts regular files enumerated after default
  pruning; `facts` counts facts *attempted* for the file, so a second run (all deduped) has
  an identical report. That is the only way the issue's "two runs produce the same report"
  is true, and it is why created/deduped stay out of the report.
- `errors` holds post failures as `{path, code, message}` sorted by path; `totals.errors` is
  its length. A clean tree has `[]`.
- Leaving `created`/`deduped` out of the report is deliberate (it is what makes two runs
  identical), so idempotence needs its own assertion: `Bulk_SecondRunCreatesNothing`
  checks the store's fact count is unchanged, not just that the report matches.
- Code facts are not idempotent across revisions: `rev` and line locators feed the content
  hash (story 3 DE1). "Two runs match" means the same revision and the same tree; say that
  in `docs/cli.md`.
- `dirty` is `git status --porcelain` non-empty; omit (null) when `--rev` is given without
  a git call.

### Revision (D7)

1. `--rev` wins, verbatim.
2. Else, if `source_root` is inside a git work tree, `git -C <root> rev-parse HEAD`; capture
   `dirty` with `git status --porcelain`.
3. Else `revision: null`. Never fail the run for a missing git.

The revision goes on each `derived_from` ref's existing `rev` field (story 3), so story 5
can build a citation without a new field.

## Edits

| File | Change |
| --- | --- |
| `src/Dossier/BulkDump.cs` | New: `DumpTree(BulkDumpRequest)`, walk, glob rules, classification, report |
| `src/Dossier/Glob.cs` | New: the matcher |
| `src/Dossier/Dump.cs` | `DumpRequest` fields; route `source_root` to `DumpTree`; exactly-one-source validation |
| `src/Dossier/Program.cs` | Flags, `VerbSpec` (`:443`), usage line (`:3`) |
| `src/Dossier/Mcp.cs` | `dump` input schema: `source_root`, `include`, `exclude`, `rules`, `report`, `revision`; description "one file or a source tree" |
| `src/Dossier/Models.cs` | `BulkDumpRequest`, `RunReport`, `FileRow` (or keep them in `BulkDump.cs`) |
| `contract/ops.schema.json` | `DumpRequest` fields, `source` optional, `DumpResponse` + `warnings`; new `$defs/RunReport` is documented here even though it is a file artifact |
| `docs/cli.md` | New "Bulk ingest" subsection under `dump`: flags, defaults, glob grammar, report shape, exit behaviour, revision |
| `docs/architecture.md` | `BulkDump.cs`, `Glob.cs` rows |
| `tests/Dossier.Tests/BulkDumpTests.cs` | New: temp trees, report pinning |
| `tests/Dossier.Tests/McpTests.cs` | `Mcp_DumpTool…` gains `source_root` |

No change to `scripts/dump-code-demo.sh` (deleted). No migration of `scripts/scale-test.sh`
in this story (see Out of scope).

## Tests

Red first, captured before any code:

```sh
dotnet src/Dossier/bin/Release/net10.0/Dossier.dll dump --source-root . --subject dossier-repo
# exit 1, "dump requires --source <path> and --subject <name>"
```

Then:

```csharp
[Test] Bulk_TwoRunsProduceTheSameReport()              // byte-identical files[] and totals
[Test] Bulk_SecondRunCreatesNothing()                  // DumpResponse created==0 AND the store's fact count is unchanged
[Test] Bulk_DefaultExcludesPruneVcsAndBuildDirectories()
[Test] Bulk_SkipReasonsArePinned()                     // excluded, not_included, binary, too_large, symlink, too_short
[Test] Bulk_PrunedDirectoriesAreAbsentFromTheReport()  // no bin/, obj/, .git/ rows at all
[Test] Bulk_GlobGrammarStarsAndDoubleStars()           // * within a segment, ** across, ? one char
[Test] Bulk_RuleOrderFirstMatchWins()
[Test] Bulk_ClassificationDefaultsAndTagNames()        // class:test etc. on the facts
[Test] Bulk_ManifestAndFlagsMerge()                    // later rule wins; flags override manifest
[Test] Bulk_ReportHasNoAbsolutePathsOrTimestamps()
[Test] Bulk_RevisionPrefersFlagThenGitThenNull()
[Test] Bulk_SourceAndSourceRootAreMutuallyExclusive()  // missing_source / both_source_and_source_root
[Test] Bulk_McpAcceptsSourceRoot()                     // tools/call with source_root
```

Fixture: a temp tree built in the test (`TempDb.Directory`) with `src/A.cs`, `docs/a.md`,
`tests/A.Tests/A.cs`, `bin/gen.dll`, a symlink, a NUL-containing file and a 1-line file.
No committed tree; no network.

Green:

```sh
dotnet test --solution Dossier.sln -c Release --no-build
dotnet src/Dossier/bin/Release/net10.0/Dossier.dll dump --source-root . --subject dossier-repo --report /tmp/r1.json
dotnet src/Dossier/bin/Release/net10.0/Dossier.dll dump --source-root . --subject dossier-repo --report /tmp/r2.json
diff /tmp/r1.json /tmp/r2.json && echo IDENTICAL
```

## Done-when evidence

| Claim | Evidence |
| --- | --- |
| Ingesting this repository is one command | the two commands above, pasted outputs, `jq '.totals'` from the report |
| Two runs produce the same report | `diff` prints nothing; `Bulk_TwoRunsProduceTheSameReport` |
| A test pins counts and skipped reasons | `Bulk_SkipReasonsArePinned`, `Bulk_ClassificationDefaultsAndTagNames` |
| `scripts/dump-code-demo.sh`'s loop is replaced | **Void**, script deleted in `1e2005d1`; say so in the PR and link this plan |
| `dotnet test` green | CI command |

## Out of scope

- Deleting the demo script (already gone).
- Parallel ingestion. Sequential, deterministic, one process.
- Per-file subjects. `scripts/scale-test.sh` derives a subject per file; bulk ingest posts
  one subject per run. A `--subject-by <template>` flag would migrate that script, and it
  is a good follow-up, but it is not this issue. Do not smuggle it in.
- Reading `.gitignore` to derive excludes; the built-in prune list is explicit and
  documented.

## Risks

- **The report is a contract.** Once callers diff it, every field is pinned. Keep it
  minimal (`format: 1`), and do not add timing.
- **Classification drift.** Default globs will never be perfect; keep them in one table
  and one test, and prefer a wrong tag over a skipped file.
- **Symlinks and loops.** Never follow; dotnet's `FileSystemEnumerable` with
  `RecurseSubdirectories` can follow, so enumerate manually with an explicit stack and
  `FileAttributes.ReparsePoint` checks.
- **Huge trees.** 3,234 files is the scale the evaluation used; the walk is O(n) and each
  file is read once. `max_file_bytes` bounds a single file, not the run.

## Size

~300 production lines, ~220 test lines, ~60 doc lines, schema edits. One PR, no new
dependency.
