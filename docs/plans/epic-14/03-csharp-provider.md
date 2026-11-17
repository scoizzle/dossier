# Story 3 — C# provider

Issue: [#18](https://github.com/scoizzle/dossier/issues/18). Tier: T2 (new dependency,
contract output). Depends on: 1, 2. Blocks: 7.

## Premise check (`ee9469e1`)

- No C# outline exists. `dump --split code` is rejected as `invalid_split`
  (`src/Dossier/Dump.cs:248-258`), and the contract enum is `heading|file|none`
  (`contract/ops.schema.json:71`).
- `src/Dossier/Compile.cs` is 879 lines with 10 top-level types (including the partial
  `DossierStore`) plus 2 nested types
  (`grep -nE '^\s*(public|internal|private|file)?\s*…(class|record|interface|enum|struct|delegate)' src/Dossier/Compile.cs`)
  and roughly a hundred members. That is the fixture the issue names.
- The repository has no package allowlist; `src/Dossier/Dossier.csproj` has exactly one
  `PackageReference` (`Microsoft.Data.Sqlite` 10.0.14). `docs/architecture.md:5` states
  that as a property.
- The release pipeline publishes **Native AOT** and fails on any IL/ILC warning
  (`.github/workflows/ci.yml::aot-smoke`, step "Fail on trim and AOT warnings"). This is
  the story's hard constraint, not a footnote (D5).

## Decisions

### D5 — Roslyn and Native AOT (spike first, sign-off on the outcome)

`Microsoft.CodeAnalysis.CSharp` is not an AOT-annotated library. The plan does not assert
it fails; it requires the spike before any provider code is written, because the answer
changes the design.

Spike (throwaway branch, no product code). Both CI release RIDs, not just the local one,
because a clean osx-arm64 says nothing about linux-arm64:

```sh
dotnet add src/Dossier/Dossier.csproj package Microsoft.CodeAnalysis.CSharp --version 5.12.0
for RID in linux-x64 linux-arm64; do
  dotnet restore src/Dossier/Dossier.csproj -r "$RID" -p:PublishAot=true
  dotnet publish src/Dossier/Dossier.csproj -c Release -r "$RID" -p:PublishAot=true \
    --no-restore -o "/tmp/aot-$RID" 2>&1 | tee "/tmp/aot-$RID.log"
  grep -E "warning (IL|ILC)[0-9]+" "/tmp/aot-$RID.log" && echo "FAIL $RID" || echo "CLEAN $RID"
done
```

Pass criteria for **each** RID: `CLEAN`; the native binary outlines `src/Dossier/Compile.cs`
identically to the managed run **and** does not fail at runtime on a malformed file and
a file with no declarations (Roslyn can hit reflection/culture resources only at runtime,
where ILC warns about nothing). Record each binary's size delta in the PR. If any
linux RID is unavailable on this machine, run it in a container or record the spike as
incomplete; do not generalize from macOS.

If it fails, in order of preference:

1. **Managed-only provider (simplest, recommended by the advisory consult).** The provider
   ships in managed builds; the AOT binary always reports `provider_unavailable` and
   relies on story 6. One build shape to keep correct, no stub, no conditional package.
   Cost: native users lose built-in `code` split unless they configure an external
   provider; say that in `docs/cli.md`.
2. **Conditional provider.** Gate it on an explicit property, never on `PublishAot`:
   `-p:EnableRoslynOutline=false` at **both** restore and publish (CI and `release.yml`),
   with the package reference and provider source conditioned on the same property. Keying
   on `PublishAot` alone is a trap: restore without the property caches the package in,
   then publish silently compiles it into the AOT binary (or the stub into managed CI).
   Guard it with a CI assertion that the AOT binary reports the fallback and the managed
   test binary has the provider.
3. Drop Native AOT from the release pipeline. Out of scope here; it changes the
   distribution story and needs its own issue.
4. Change story 3 to a hand-written C# outline scanner with no dependency. It violates
   "Roslyn syntax API" but keeps AOT; a new sub-issue, not a silent substitution.

Never disable the CI warning gate to accommodate the package. Whichever option lands,
`scripts/smoke-aot.sh` (or the `aot-smoke` job) runs `dump --split code` on the native
binary and asserts either the outline or the documented fallback, so the stub path is
executed somewhere.

### Dependency review (required in the PR)

Measured 2026-11-17 from nuget.org:

| Package | Version | License | Package size | Transitive (net10.0 group) |
| --- | --- | --- | --- | --- |
| `Microsoft.CodeAnalysis.CSharp` | 5.12.0 | MIT (expression; `requireLicenseAcceptance` is set) | 12.4 MB nupkg | `Microsoft.CodeAnalysis.Common`, `Microsoft.CodeAnalysis.Analyzers` (build-time) |
| `Microsoft.CodeAnalysis.Common` | 5.12.0 | MIT | 4.6 MB nupkg | none beyond the analyzers |

The `net10.0` dependency group avoids the `System.*` backports the `netstandard2.0`
group carries. MIT is compatible with this repository's MIT license. Add both rows to
`THIRD-PARTY-NOTICES.md` in the same PR (the file lists what release archives contain;
under option 1 say "managed builds only").

**Pinning:** use an exact version, `Version="5.12.0"` with no floating range, so
Dependabot owns bumps like every other CI-pinned thing. `Directory.Packages.props` does
not exist here; do not introduce central package management in this story.

### DE1 — symbol refs churn the store on every revision (recommend default off)

The epic wants a `symbol` ref per code fact (`<qualified-name>@<revision>`). Fact
identity is a content hash over text, `data` and refs' `(kind,target,locator)`
(`contract/fact.schema.json` `content_hash`), and the symbol target embeds the revision.
So ingesting the same tree at a new commit creates a fresh fact per symbol: a re-ingest
grows the store by the whole outline every time, and `dump` stops being idempotent across
revisions.

Recommendation: **story 3 emits no `symbol` ref and adds no `--symbol-refs` flag.**
`data.symbol` carries the qualified name; a flag whose only purpose is to document churn
is contract surface with no consumer. The epic's `docs/ingestion.md` says story 3 emits
the ref; this supersedes that line, and the PR must say so.

The consult also noted the churn is **broader** than symbol refs: `derived_from` carries
`rev` and a locator, and both feed the content hash. So a code fact dedupes only at the
same revision *and* the same line numbers; an edit above a member or a new commit creates
new facts. That is a property of dossier's fact identity, not something this story can
fix. Record it as a known limit in `docs/cli.md` and open a follow-up issue ("fact
identity across revisions for line-addressed sources") rather than pretending story 4's
idempotence covers it. Story 4's report compares the *scan*, and its test must assert the
store's fact count is unchanged on a second run at the same revision.

### Other story-3 decisions

- **Opt-in only.** `code` is a new accepted `--split` value; `DefaultSplit` stays
  `heading` for markdown and `file` for everything else (`src/Dossier/Dump.cs:219-226`).
  No C# file is outlined unless asked (D4).
- **Fact text.** `text` = the collapsed one-line signature when it is 3..240 characters,
  else the qualified name; `data.signature` always holds the full collapsed signature.
  Never cut the signature: the name is the honest short text, and the full signature stays
  machine-readable. `items` = the summary when present.
- **`kind`.** Facts from an outline provider default to `kind: "code"` unless `--kind`
  is given, so `search --kind code` works. This is a provider fact kind, not a new
  default for the other splits.
- **Members to emit:** namespaces are **not** nodes (the qualified name carries the
  namespace); types (class, struct, interface, enum, record, record struct, delegate),
  nested types, methods, constructors, finalizers, operators, conversions, properties,
  indexers, fields (one per declarator), events, enum members, and partial methods as
  declared. **Partial types merge into one node** (story 1 D2): first start, last end,
  children unioned. Local functions and lambdas are not outlined. Namespace declarations,
  `using`s and top-level statements are not nodes; a file with only top-level statements
  has no declarations and takes the fallback.
- **Spans.** `start_line`/`end_line` are the declaration's **`Span`**, not `FullSpan`:
  `node.GetLocation().GetLineSpan()` + 1. That includes attributes (part of the
  declaration) and excludes leading doc trivia, which becomes `doc`. Parse the same
  LF-normalized text that `Dump.Split` locates lines in, so CRLF and lone-CR files cannot
  shift a fact's line numbers; test all three line endings.
- **Doc.** The first paragraph of `<summary>` (or the whole doc comment when there is no
  `<summary>`), XML entities decoded, `<see cref="…"/>` rendered as its `cref` text,
  whitespace collapsed.
- **Syntax errors.** Roslyn always returns a tree. Outline the recovered tree and set
  `parse_errors` to the count of `Error`-severity diagnostics on the tree (D3). If the
  recovered tree yields **no** declarations, the no-declarations fallback wins even when
  `parse_errors` is high: one rule, "empty nodes means whole-file", so the two fallbacks
  cannot fight. Pin that precedence.
- **Preprocessor.** Parse with `CSharpParseOptions(LanguageVersion.Latest)` and no symbols,
  so only the active `#if` branch is outlined. Document that the outline depends on
  defines; test a `#if DEBUG` block is absent. `.razor` and `.cshtml` are not handled and
  fall back.

## Edits

| File | Change |
| --- | --- |
| `src/Dossier/Dossier.csproj` | `PackageReference Microsoft.CodeAnalysis.CSharp 5.12.0` (conditioned per D5 outcome) |
| `src/Dossier/CSharpOutlineProvider.cs` | New: `IOutlineProvider` implementation; `CSharpSyntaxTree.ParseText(..., CSharpParseOptions(LanguageVersion.Latest))`; `SyntaxWalker` over `MemberDeclarationSyntax`; doc extraction; D2 name formatting |
| `src/Dossier/Dump.cs` | Accept `code` in `ValidateSplit`; resolve the provider by extension (`.cs`); non-UTF-8 handling for `code` (below); `warnings` on the response; default kind `code` for provider facts |
| `src/Dossier/Mcp.cs` | `split` enum gains `code` (`:281`) |
| `src/Dossier/Dump.cs` | `DumpResponse.Warnings` (`List<string>`) |
| `contract/ops.schema.json` | `split` enum gains `code`; `DumpResponse` gains optional `warnings` |
| `docs/cli.md` | Document `--split code`, the provider table, fallback warnings, `data` keys, DE1, and the lossy non-UTF-8 rule |
| `docs/architecture.md` | Package line and file map (`CSharpOutlineProvider.cs`) |
| `THIRD-PARTY-NOTICES.md` | Roslyn rows |
| `tests/Dossier.Tests/CSharpOutlineTests.cs` | New: fixtures and fallbacks |
| `tests/Dossier.Tests/DumpTests.cs` | Two enum oracles gain `code` (see "Tests to retarget") |
| `tests/Dossier.Tests/McpTests.cs` | `Mcp_DumpToolAdvertises…` enum gains `code` |

### Non-UTF-8 behaviour (specific, because it changes an existing contract)

Today `DecodeUtf8` throws and `Dump` returns `parse_failed` with no fact
(`src/Dossier/Dump.cs:108-118`). For `split=code` only, the issue requires a fallback to a
whole-file chunk. Do this:

1. Strict decode first, as today.
2. On `DecoderFallbackException`, decode again with replacement (`new UTF8Encoding(false,
   throwOnInvalidBytes: false)`), split as `file`, and add
   `warning: split_fallback: invalid_utf8`.
3. The blob already holds the exact bytes (`:92-106`); the fact text is lossy and the
   docs say the blob is authoritative.

`heading`/`file`/`none` keep returning `parse_failed` — no behaviour change outside the
new split.

Two boundary cases the consult raised, both pinned:

- **UTF-16 with a BOM** is not "invalid UTF-8 to repair": detect a UTF-16 LE/BE BOM and
  take the whole-file fallback with `split_fallback: invalid_utf8` **without** a lossy
  decode, so the fact does not contain a page of U+FFFD.
- **`--split code` on a non-C# path** (`.txt`, `.razor`) falls back with
  `split_fallback: no_provider_for_extension` and keeps the strict decode: an invalid-UTF-8
  `.txt` still reports `parse_failed`, exactly like `file`/`heading` today. Lossy decoding
  is only for `.cs`.

## Tests

Red first, in this order, each recorded with its failing output:

1. `CSharpProvider_OutlinesCompileCs` (new) — before the provider: `dump --split code`
   returns `invalid_split` (run the CLI to capture that, it is the honest red).
2. `CSharpProvider_FallsBackOnNonUtf8` — before: `parse_failed`, zero facts.
3. `CSharpProvider_FallsBackWhenThereAreNoDeclarations` — before: `invalid_split`.

Then green:

```csharp
[Test] CSharpProvider_OutlinesCompileCs()                 // exactly one node per type and member
[Test] CSharpProvider_LineRangesMatchTheFile()            // spot-check 3 named members against raw lines
[Test] CSharpProvider_SummaryIsTheFirstParagraph()        // <summary>, entities and <see cref>
[Test] CSharpProvider_PartialTypesMergeIntoOneNode()
[Test] CSharpProvider_FileScopedAndBlockNamespacesAgree()
[Test] CSharpProvider_NestedTypesNestUnderTheirParent()
[Test] CSharpProvider_SyntaxErrorsStillOutlineWithParseErrorCount()
[Test] CSharpProvider_FallsBackOnNonUtf8()                // one fact, warning, blob bytes unchanged
[Test] CSharpProvider_FallsBackWhenThereAreNoDeclarations()
[Test] CSharpProvider_FallsBackWhenNoProviderHandlesThePath()   // .txt with --split code
[Test] CSharpProvider_LongSignatureUsesNameAndKeepsFullSignatureInData()
[Test] CSharpProvider_NoSymbolRefByDefault()              // DE1, and no --symbol-refs flag exists
[Test] CSharpProvider_LineEndingsDoNotShiftRanges()       // LF, CRLF, lone CR
[Test] CSharpProvider_Utf16BomTakesTheFallbackWithoutLossyText()
[Test] CSharpProvider_InactivePreprocessorBlockIsNotOutlined()
[Test] CSharpProvider_SyntaxErrorsWithNoDeclarationsTakeTheFallback()  // precedence pin
[Test] CSharpProvider_NonCSharpExtensionKeepsStrictDecode()           // .txt + invalid UTF-8 -> parse_failed
[Test] Docs_CodeSplitReconcilesTheSkillAndCli()           // D4: cli has --split code; SKILL.md no longer says "it extracts nothing"
```

`CSharpProvider_OutlinesCompileCs` is the issue's pin. Make it specific without a brittle
golden file: **hand-count** the expected node count (types plus members; 10 top-level types,
2 nested, plus the members) and write that number into the test after checking it against
the file, not after reading the first green run — a first-green number locks a bug in as
the oracle. Assert
`Dossier.DossierStore.Compile` and two other named nodes exist with their kind, assert the
line range of one node equals the line found by scanning the file for its signature, and
assert every child span sits inside its parent.

### Tests to retarget (intentional contract change, not weakening)

```text
tests/Dossier.Tests/DumpTests.cs:162  ContractSchema_SplitEnumIsHeadingFileNone_AndEntitySubjectsIsAbsent
                                     -> ContractSchema_SplitEnumIsHeadingFileNoneOrCode_AndEntitySubjectsIsAbsent
tests/Dossier.Tests/McpTests.cs:214   Mcp_DumpToolAdvertisesOneFileAndTheSplitEnum (after story 0)
```

Both currently assert `heading,file,none`. The contract changes, so the oracle changes
with it. Say exactly this in the PR; a reviewer must see the enum addition, not a diff
that quietly relaxes an assertion. `DumpTests.RemovedSplit_IsRejectedAsInvalidSplit_*`
keeps asserting `paragraph` and `code` are rejected for the **library** entry point only
until the flag exists — once `code` is valid, those cases must change to `paragraph`
alone. That is a removal of a now-false case, allowed as part of the contract change, and
the PR names it.

## Done-when evidence

| Claim | Evidence |
| --- | --- |
| One fact per type and member on `Compile.cs` with correct spans/summaries | run `dossier dump --split code --source src/Dossier/Compile.cs --subject dossier-repo` against a temp DB; paste the manifest and the fact count; `CSharpProvider_OutlinesCompileCs` |
| Both fallbacks pinned | `CSharpProvider_FallsBackOnNonUtf8`, `…WhenThereAreNoDeclarations` |
| Dependency review in the PR | the table above, updated with the spike's measured size delta and the AOT verdict |
| D5 approved | a line in the PR naming the outcome and the option chosen |
| `dotnet test` green | CI command |

## Risks

- **AOT (D5):** the story can be blocked outright. Do the spike before writing the
  provider, and timebox it.
- **Fact count:** 13 types plus ~100 members means a symbol outline of `Compile.cs` is
  *more* facts than the 105 paragraph chunks the evaluation complained about. The complaint
  was about coherence, not count, but story 7 must measure tokens, and this plan does not
  claim a token win for story 3.
- **Fact text vs the 240-char rule:** handled by name-as-text plus `data.signature`; do not
  let a summary become the fact text and never truncate.
- **Two build shapes (D5 option 2) are easy to get wrong:** a managed test suite never
  executes the AOT stub. If the conditional route is chosen, the AOT smoke job must run
  `dump --split code` and assert the documented fallback; otherwise the stub is untested
  code in the only artifact users download.
- **Fact identity churn (DE1):** documented as a known limit, not fixed here. Do not let a
  PR describe re-ingest as idempotent across revisions.
- **Wire back-compatibility:** `DumpResponse` is `additionalProperties: false`
  (`contract/ops.schema.json`). Adding `warnings` is additive for readers that ignore
  unknown fields, but a strict consumer validating a **response** against the old schema
  would reject it. Pre-1.0 this is acceptable; state it in the PR and in `docs/cli.md`
  rather than pretending the response shape did not change.
- **Generated `.cs`:** a `*.g.cs` file is outlined like any other when `--split code` is
  asked for; bulk ingest tags it `class:generated` (story 4) so callers can exclude it.
  Do not special-case the provider.
- **Package drift:** Roslyn 5.12.0 is a moving compiler; pin exactly and let Dependabot
  bump it, then re-run the outline pin because the syntax tree can gain nodes.
- **`code` as an accepted split on a non-C# file:** resolve by extension, fall back with
  a warning, never throw.

## Size

~350 production lines (provider ~250, dump wiring ~60, models/schema ~40), ~250 test
lines, ~50 doc lines, one package reference. This is the largest story; one PR, one
reviewer, and the advisory consult its size triggers under the global workflow.
