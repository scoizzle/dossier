# Story 6 — external outline provider protocol

Issue: [#21](https://github.com/scoizzle/dossier/issues/21). Tier: T2 (process execution
and a contract). Depends on: 1 (`#16`), 2 (`#17`). Blocks: none.

## Premise check (`ee9469e1`)

- Nothing spawns a process in the ingest path. `Dump` reads bytes and splits in-process;
  `Process` appears only in tests and the web/demo tooling.
- The epic and issue say failures "fall back to paragraph". There is no paragraph split
  (`src/Dossier/Dump.cs:234-258`): the fallback is one whole-file chunk (`file`). This plan
  says "whole-file" everywhere; the issue text is stale, not the design.
- The story's value is larger than the epic assumed: it is the **only** outline path in a
  Native AOT build if D5 forces the Roslyn provider out (story 3). It must therefore work
  without any language dependency.

## Configuration (never runs unless asked)

```sh
dossier dump --source-root . --subject dossier-repo \
  --rule '**/*.cs=code' \
  --outline-provider /usr/local/bin/lsp-outline \
  --outline-provider-arg --stdio \
  --outline-timeout-ms 5000 \
  --outline-max-output-bytes 8388608 \
  --report /tmp/report.json
```

- Flags on `dump`: `--outline-provider <path>` (one), `--outline-provider-arg <arg>`
  (repeatable, appended in order), `--outline-timeout-ms` (default 5000, minimum 100),
  `--outline-max-output-bytes` (default 8 MiB).
- Environment fallback for MCP/web callers that cannot pass flags:
  `DOSSIER_OUTLINE_PROVIDER` (path only; no argument splitting, ever) plus
  `DOSSIER_OUTLINE_PROVIDER_ARGS` as a **JSON array of strings**. Never `sh -c`, never a
  string split.
- Manifest (story 4): `"outline_provider"`, `"outline_provider_args"`,
  `"outline_timeout_ms"`, `"outline_max_output_bytes"`.
- The provider is used only for chunks whose split resolves to `code`. If no rule asks for
  `code`, no process is started — pinned by a canary test.
- Precedence: when a provider is configured it is authoritative for `code`; on any
  provider failure the fallback is the whole-file chunk, **not** the built-in C# provider.
  Predictable beats clever, and it keeps the external contract testable.

## Protocol (version 1)

One process per file. Dossier writes one JSON line to stdin, closes stdin, and reads one
JSON document from stdout.

Request:

```json
{"protocol":1,"path":"src/Dossier/Dump.cs","language":"cs","revision":"ee9469e1…","content":"<file text, UTF-8>"}
```

- `path` is the same string dossier will put on the `derived_from` ref (absolute for
  `--source`, root-relative for `--source-root`).
- `language` is the extension without the dot (`cs`), or empty when there is none. The
  provider maps it to its own language id; the response's `language` is the provider's id.
- `revision` is null when unknown.
- `content` is the decoded file text (for `code`, the lossy decode from story 3 if the
  bytes are not UTF-8, with a warning).

Response: exactly the story-1 outline document (`{"version":1,"language":"csharp",
"parse_errors":0,"nodes":[…]}`), optionally followed by whitespace. An empty `nodes`
array is a deliberate "no declarations" and takes the whole-file fallback with
`outline_no_declarations`. Anything else on stdout is `outline_invalid_json`; a document
that fails `OutlineValidator` is `outline_schema_invalid`.

Failure handling:

| Case | Kill | Warning code | Result |
| --- | --- | --- | --- |
| process cannot start | — | `outline_spawn_failed` | whole-file |
| no output before the timeout | tree kill | `outline_timeout` | whole-file |
| stdout exceeds the cap | tree kill | `outline_oversize` | whole-file |
| exit code ≠ 0 | — | `outline_exit_<code>` | whole-file |
| stdout is not one JSON document | — | `outline_invalid_json` | whole-file |
| document fails the schema/validator | — | `outline_schema_invalid` | whole-file |
| `nodes: []` | — | `outline_no_declarations` | whole-file |

Every warning is prefixed `warning: split_fallback: ` and appended to
`DumpResponse.Warnings` (added in story 3/4; if story 6 lands first, add the field here).
Stderr is captured up to 4 KiB, sanitized of control characters, and attached to the
warning as `stderr="…"` — never to fact text. A timeout is wall-clock around the whole
exchange, enforced with `Process.WaitForExitAsync(ct)` plus `Kill(entireProcessTree: true)`
so the `dotnet` host's child dies with it.

## Edits

| File | Change |
| --- | --- |
| `src/Dossier/ExternalOutlineProvider.cs` | New: config, spawn, write/read, timeout, cap, parse, validate, map to `OutlineResult` |
| `src/Dossier/OutlineProviders.cs` | Provider selection: configured external first, then built-ins (story 3) |
| `src/Dossier/Dump.cs` | Map warnings to `Warnings`; apply the provider only to `code` chunks |
| `src/Dossier/Program.cs` | `dump` flags + `VerbSpec` (`:443`) + usage (`:3`) |
| `src/Dossier/Mcp.cs` | `dump` schema: `outline_provider`, `outline_provider_args`, `outline_timeout_ms`, `outline_max_output_bytes`; description says the command is only run when configured |
| `contract/ops.schema.json` | `DumpRequest` fields |
| `docs/cli.md` | New "External outline providers" subsection: config, protocol 1 request/response, limits, warning codes, security note (no shell) |
| `docs/architecture.md` | `ExternalOutlineProvider.cs` row |
| `tests/Dossier.Tests/fixtures/outline-provider.cs` | New: .NET 10 file-based app implementing the provider in modes `echo`, `none`, `timeout`, `exit3`, `garbage`, `oversize` |
| `tests/Dossier.Tests/ExternalOutlineTests.cs` | New |

### Why a file-based C# fixture

CI runs on Ubuntu, macOS and Windows (`ci.yml` `build-test`), so a `.sh` provider would
have to be skipped on Windows — and a skipped test is not evidence. Python/Node are not
guaranteed on all runners. A `.NET 10` file-based app (`dotnet run fixture.cs -- <mode>`)
is the only fixture every runner can execute with the SDK already installed, and it
exercises a real process boundary. Serialize the provider tests (`[NotInParallel]`) and
allow a 15 s spawn timeout in the test, not the default 5 s, because the first `dotnet run`
pays JIT/restore cost. If CI proves flaky, replace it with a small console project in the
solution; do not replace it with a skipped test.

## Tests

Red first: `dump --split code --outline-provider <fixture>` is rejected today
(`invalid_split`, because `code` needs story 3; before that, the flag itself is an unknown
option and the CLI exits 1). Capture the exact message, then build.

```csharp
[Test] External_RoundTripsAnOutlineFromTheFixture()        // echo mode, one fact per node, data.symbol
[Test] External_TimeoutKillsTheProcessAndFallsBack()       // elapsed bounded, no orphan, warning
[Test] External_OversizeOutputIsCappedAndFallsBack()
[Test] External_NonZeroExitFallsBack()
[Test] External_InvalidJsonFallsBack()
[Test] External_SchemaInvalidDocumentFallsBack()
[Test] External_EmptyNodesIsNoDeclarations()
[Test] External_SpawnFailureFallsBack()
[Test] External_IsNeverRunWhenNotConfigured()              // canary script that would create a file; assert absent
[Test] External_IsNeverRunWithoutACodeSplit()              // provider configured, split heading: no spawn
[Test] External_EnvVarProvidesThePathButNeverSplitsArgs()  // path with a space stays one arg
[Test] External_StderrNeverReachesFactText()
[Test] External_TwoRunsProduceTheSameFacts()               // determinism
```

Canary: the fixture's `echo` mode writes a marker file when `MARKER` is set; the
not-configured test points `MARKER` at a temp path, runs a normal dump, and asserts the
marker is absent. That proves "never run unless configured" instead of trusting the code
path.

Green:

```sh
dotnet test --solution Dossier.sln -c Release --no-build
```

## Done-when evidence

| Claim | Evidence |
| --- | --- |
| A test provider round-trips | `External_RoundTripsAnOutlineFromTheFixture` output |
| Each failure case falls back, warns, and is pinned | the six tests above, with the warning text pasted |
| The command is never run unless configured | canary test |
| `dotnet test` green | CI command |

## Risks

- **Windows process trees.** `Kill(entireProcessTree: true)` is the only portable kill;
  test for the absence of the marker/lock file after the timeout, not just the return
  value.
- **A protocol is forever.** Version 1 is in the request and the outline document.
  Changing either needs a new version and a compatibility rule; write that sentence in
  `docs/cli.md`.
- **Untrusted output.** The provider is a local process the user configured, but its
  output is still data: validate against the schema, cap the size, and never let a
  `signature`/`doc` contain control characters that break the markdown bundle. Sanitize
  like `Inline()` does.
- **AOT.** Keep the implementation free of reflection; `JsonCodec` source generation must
  include the outline types (`[JsonSerializable(typeof(OutlineDocument))]`), or AOT
  builds will fail at runtime. Add the AOT smoke case (`scripts/smoke-aot.sh`) that runs a
  provider once, or record why it is not covered.

## Size

~230 production lines, ~250 test lines, ~50 doc lines, one fixture file. One PR after
stories 1–3.
