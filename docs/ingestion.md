# Epic: structured code ingestion

Plan for making dossier ingest whole code repositories as symbol-level facts with resolvable citations. Status: proposed, 2026-11-11. Back to the [README](../README.md).

## Why

An external evaluation in an isolated environment ingested this repository with dump. Its findings, reported on 2026-11-11 and not reproduced in this repository:

1. Paragraph splitting of src/Dossier/Compile.cs produced 105 facts from one file (one chunk skipped as too short). A C# symbol splitter (types, methods, properties, XML summaries, source spans) is needed; code split is Python-only today (`docs/cli.md:9`, `src/Dossier/Dump.cs:517-525`).
2. Bulk ingestion needed an external loop of 104 dump processes; dump reads one file (`src/Dossier/Dump.cs:75`, `File.ReadAllBytes`) and has no `--source-root`, globs or run report (`src/Dossier/Program.cs:57-78`). The MCP dump tool claims "file or directory" (`src/Dossier/Mcp.cs:209`), which is wrong.
3. Facts kept absolute source refs and line ranges, but 114 relative links copied from source content pointed outside the published bundle.
4. Whole-repo ingestion mixed tests, fixtures, demos and generated bundles with product docs.
5. Structural checks passed (3,234/3,234 files matched the manifest; 3,234 navigation links resolved), but nothing measured whether the facts help answer engineering questions.

What worked and must not regress: bundle navigation, token estimates, line-level provenance.

## Principle: dossier owns the seam

Dossier defines a language-neutral outline contract and an outline-provider interface. Built-in providers ship in dossier; external providers run as a separate process speaking a documented protocol. Dossier takes no dependency on Poly, and no dependency on any language toolkit that is not stable and released. Built-in providers may use stable, released packages; story 3's `Microsoft.CodeAnalysis.CSharp` (syntax API only) is the one named exception, pending the dependency decision in [Open questions](#open-questions). Rationale: an external grammar/LSP toolkit (Poly) was evaluated as a provider; it has a cheap pattern-table grammar engine but is about to be heavily refactored, so dossier will not build on it now. It can plug in later through the external-provider protocol (story 6) with no dossier change.

## Outline contract (summary; story 1 specifies it)

An outline node: `name`, `qualified_name`, `kind` (open string: namespace, class, struct, interface, enum, record, method, constructor, property, field, event, function, ...), `start_line`, `end_line` (1-based inclusive), optional `start_col`/`end_col`, optional `signature` (one line), optional `doc` (first paragraph of the doc comment), `children`.

Mapping onto existing facts (`src/Dossier/Dump.cs:165-218`): text = signature, data = `{symbol, entity_kind, parent, start_line, end_line}`, items = doc, and the entity locator `{line, selector "L<start>-L<end>", symbol}` built at `src/Dossier/Dump.cs:182-185` (`LineRangeLocator` at `src/Dossier/Dump.cs:463-464` is the simpler helper paragraph chunks use). Today `BuildFact` emits only one ref, `derived_from` to the source file (`src/Dossier/Dump.cs:206-216`). The `symbol` ref whose target is `"<qualified-name>@<revision>"` (`contract/ref.schema.json:5`) does not exist yet: story 1 specifies it and story 3 emits it. `--entity-subjects` keeps working (`src/Dossier/Dump.cs:255-329`).

## Stories

| # | Story | Tier | Depends on | Done when |
| --- | --- | --- | --- | --- |
| 0 | Correct the MCP dump description to "file" (or land with story 4) | T0 | none | `Mcp.cs:209` text matches behaviour; `dotnet test` green |
| 1 | Outline contract: `contract/outline.schema.json` plus docs; decide Locator end-line and the qualified-name format for overloads | T2 (public contract) | none | Schema committed, validated in tests, `docs/cli.md` updated |
| 2 | Provider interface; move the existing Python scanner behind it with no behaviour change | T1 | 1 | Existing `DumpTests` pass unchanged |
| 3 | C# provider using Roslyn syntax trees only | T2 (new dependency, contract output) | 2 | One fact per type and member on `src/Dossier/Compile.cs`, both fallback cases pinned by tests |
| 4 | Bulk ingest: `--source-root`, globs, run report, classification tags | T2 (CLI/MCP contract) | none | Ingesting this repo is one command; the report is reproducible |
| 5 | Resolvable citations in published bundles | T2 (publish output contract) | 1 | Zero relative links leave the bundle; a test pins the rewrite |
| 6 | External outline provider protocol | T2 (process execution, contract) | 1, 2 | A test provider round-trips; failures fall back and report |
| 7 | Task-oriented evaluation | T1 | 3, 4 | One command runs the question set and records scores per revision |

### 0. Correct the MCP dump description

**Scope.** Change the MCP `dump` tool description from "file or directory" to "file" (`src/Dossier/Mcp.cs:209`), or land the change with story 4, when dump really does accept a directory.

**Done when.** The description at `src/Dossier/Mcp.cs:209` matches what the code does, and `dotnet test` is green.

**Out of scope.** Any behaviour change to dump; accepting a directory before story 4.

### 1. Outline contract

**Scope.** Add `contract/outline.schema.json` plus its docs, and settle two open points: whether `Locator` gains an `end_line` or keeps the `L<start>-L<end>` selector, and the qualified-name format for overloads (for example `Ns.Type.Method(int,string)`).

**Done when.** The schema is committed, validated in a test, and `docs/cli.md` is updated. Proved by `dotnet test`.

**Out of scope.** Any provider implementation; widening existing fact contracts beyond the Locator decision.

### 2. Provider interface

**Scope.** Define a language-neutral outline-provider interface and move the existing Python scanner (`ScanPython`, `src/Dossier/Dump.cs:718`) behind it with no behaviour change.

**Done when.** The existing code-split tests — the `CodeSplit_*` tests in `tests/Dossier.Tests/DumpTests.cs:224-461` — pass unchanged. Proved by `dotnet test`.

**Out of scope.** New languages; changing the fact shape Python produces.

### 3. C# provider

**Scope.** A C# provider built on Roslyn syntax trees only (`Microsoft.CodeAnalysis.CSharp`, no project load, no restore, no semantic model): namespaces, types, members, XML `<summary>`, spans; partial and nested types; file-scoped namespaces. Roslyn always returns a tree, so the fallback trigger is not a parse failure: fall back to paragraph with `warning: split_fallback` when the file is not valid UTF-8 or the tree has no type or member declarations. A file with syntax errors is still outlined from the recovered tree, and its fact records that the tree had diagnostics (for example a `data.parse_errors` count; whether that field exists, and its name, is a story 1 decision). The repository has no package allowlist today; story 3 includes a dependency review (licence, size, transitive packages) recorded in the PR.

**Done when.** `dump --split code` on `src/Dossier/Compile.cs` yields one fact per type and member with correct line ranges and summaries, a test pins it, and tests pin both fallback cases (non-UTF-8, no declarations). Proved by `dotnet test`.

**Out of scope.** Semantic analysis, project or solution loading, other languages.

### 4. Bulk ingest

**Scope.** `dump --source-root <dir>` with `--include`/`--exclude` globs, per-glob split rules, an optional manifest file carrying the same, deterministic order, a JSON run report (files seen, ingested, skipped with reason, facts, errors), and a classification tag (test, fixture, demo, generated) so callers can exclude or separate them. It uses the providers from stories 2 and 3 when they are present, and the MCP dump tool then accepts a directory honestly.

**Done when.** Ingesting this repository is one `dossier dump --source-root . --subject dossier-repo` command, a test pins the run report (counts and skipped reasons) and that two runs produce the same report, and `scripts/dump-code-demo.sh`'s per-file loop is replaced by one call. Proved by running that command twice on this repository and comparing the two reports.

**Out of scope.** Deleting `scripts/dump-code-demo.sh`; parallel ingestion of one tree.

### 5. Resolvable citations in published bundles

**Scope.** Publish takes a source URL template with revision (for example `https://github.com/<owner>/<repo>/blob/{rev}/{path}#L{start}-L{end}`) and rewrites relative links found in fact text to it or to included source artifacts. The revision is recorded at dump time (`git rev-parse HEAD` or a flag).

**Done when.** Publishing this repository leaves zero relative links pointing outside the bundle, and a test pins the rewrite. Proved by `dotnet test` and by publishing this repository and reading the resulting bundle's links.

**Out of scope.** Rewriting links in content dossier does not own; signing or verifying the revision.

### 6. External outline provider protocol

**Scope.** Dossier spawns a configured command, sends file paths and content, and reads outline JSON per the story 1 schema. Timeouts, size limits, a non-zero exit or invalid JSON fall back to paragraph with a warning. The command is never run unless configured. An LSP documentSymbol bridge and a future Poly provider live outside dossier behind this protocol.

**Done when.** A test provider script round-trips, and the failure cases fall back and report. Proved by `dotnet test`.

**Out of scope.** Shipping an LSP bridge or a Poly provider inside dossier.

### 7. Task-oriented evaluation

**Scope.** A question set for this repository (where is X, what calls Y, what does Z guarantee), scored for correctness, citation traceability and tokens, comparing a bundle against reading source directly. It extends `docs/evaluation.md`.

**Done when.** The harness runs with one command and records scores per revision. Proved by running that command on this repository and reading the scores file it writes.

**Out of scope.** A general benchmark; changing the results `docs/evaluation.md` already records.

## Order

Story 0 any time. 1 then 2 then 3. 4 can run beside 1 to 3; 5 after 1. 6 after 2. 7 after 3 and 4. Suggest landing 1, 2, 3 and 4 first: they remove the two biggest pains from the evaluation.

## Non-goals

- No dependency on Poly, and no dependency on any language toolkit that is not stable and released. Built-in providers may use stable, released packages; `Microsoft.CodeAnalysis.CSharp` (story 3, syntax API only) is the one exception, pending the dependency decision.
- No LSP server or client inside dossier.
- No semantic analysis (references, types, call graphs).
- No incremental parsing.
- No languages beyond Python and C# built in.

## Open questions

- Locator `end_line` versus the `L<start>-L<end>` selector.
- Qualified-name format and overload disambiguation.
- Where the revision comes from outside git.
- Whether classification tags are facts' tags or a separate field.
- Roslyn package size (the repository has no package allowlist today).
- Approve `Microsoft.CodeAnalysis.CSharp` as a dependency.
- Whether bulk ingest should run providers in-process in parallel.

## Revisit Poly when

Its refactor has landed and it exposes a stable way to produce an outline (name, kind, range, children, doc) from a grammar plus a batch CLI; then it implements story 6's protocol as an external provider. As context only, with no line refs: evaluated 2026-11-11, Poly's LSP then served `.poly` files only and its grammar engine was not wired to its LSP or analysis.
