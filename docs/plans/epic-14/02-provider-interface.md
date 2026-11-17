# Story 2 — provider interface

Issue: [#17](https://github.com/scoizzle/dossier/issues/17). Tier: T1 (one area, existing
test oracle). Depends on: 1 (`#16`). Blocks: 3, 6.

## Premise check (`ee9469e1`)

The issue says: "move the existing Python scanner (`ScanPython`, `src/Dossier/Dump.cs:718`)
behind it with no behaviour change" and "the existing `CodeSplit_*` tests in
`tests/Dossier.Tests/DumpTests.cs:224-461` pass unchanged".

Neither exists:

- `src/Dossier/Dump.cs` is 333 lines and has no scanner. `grep -rn ScanPython src` returns
  nothing. The splitter is `Split(text, split)` with `heading`, `file`, `none`
  (`src/Dossier/Dump.cs:234-258`).
- `DumpTests.cs` is 356 lines with 17 tests, none named `CodeSplit_*`
  (`grep -n "public async Task" tests/Dossier.Tests/DumpTests.cs`).
- The splitter was removed deliberately in `1e2005d1` ("dump: drop paragraph/code split;
  add symbol documentation loop to skill"), and `docs/cli.md:7` plus
  `contract/ops.schema.json:71` now advertise exactly three splits.

So story 2 is not a port. It is the **introduction of the seam** that story 3's C#
provider and story 6's external provider plug into. The honest oracle is still the
issue's second sentence: all existing `DumpTests` pass with **no test edits**.

**D4b (new, needs sign-off):** the epic's principle says built-in Python *and* C#
providers ship. The Python one no longer exists and nothing later in the epic needs it
(story 3 is C#, story 6 is external, story 7 evaluates this repository). Recommend
dropping the Python built-in from #14's principle and recording that in the epic. Adding
it back is a new sub-issue with no oracle to port — a hand-written scanner, not a
refactor — and would need its own tier.

## Design

One interface, one mapping function, no public behaviour change.

```csharp
// src/Dossier/OutlineProviders.cs (new)
/// <summary>A language outline provider. Built-ins implement this; story 6 adds a
/// process-backed implementation. A provider never throws for bad input: it returns
/// a result with no document and a fallback reason.</summary>
internal interface IOutlineProvider
{
    /// <summary>Stable language id written into the document and the fact data: csharp, python, ...</summary>
    string Language { get; }

    /// <summary>Extension/name test. The dump split chooses the first provider that handles the path.</summary>
    bool Handles(string path);

    /// <summary>Outline one decoded file. <paramref name="revision"/> may be null.</summary>
    OutlineResult TryOutline(string path, string text, string? revision);
}

/// <summary>Either a validated outline, or why the caller must fall back to a whole-file chunk.</summary>
internal sealed record OutlineResult(
    OutlineDocument? Document,
    string? FallbackReason,
    IReadOnlyList<string> Warnings);
```

The mapping from document to chunks lives in `Dump.cs` so it is next to `BuildFact`:

```csharp
// depth-first, document order; one chunk per node, children after their parent
private static List<Chunk> OutlineToChunks(OutlineDocument document, DumpResponse response, string? revision);
```

`Chunk` grows optional fields and `BuildFact` writes them into the fact:

```csharp
private sealed record Chunk(
    string Text, int StartLine, int EndLine,
    string? Symbol = null, string? EntityKind = null, string? Parent = null,
    string? Doc = null, int ParseErrors = 0);
```

- `Text` = the node's `signature` when present, otherwise `name` (see story 3's 240-char
  handling).
- `data` is written only when `Symbol` is non-null: `{symbol, entity_kind, parent,
  start_line, end_line, parse_errors?}` (D3). Existing `heading`/`file`/`none` chunks have
  no symbol, so their facts are byte-identical to today's.
- `items` = `[{text: doc}]` when `doc` is non-empty. Otherwise absent.
- `refs` = today's `derived_from` file ref, plus a `symbol` ref
  (`<qualified_name>@<revision>`, `basis: derived`) only when a revision is known, because
  `PostFacts` rejects a symbol target without one (`src/Dossier/PostFacts.cs:187-198`).
- Nodes of kind `namespace` are walked but emit no chunk: the qualified name already
  carries the namespace and a namespace fact would assert nothing. External providers may
  emit them; the mapping skips them deterministically.
- A node whose text trims shorter than `MinChunkTextLength` is reported in `skipped` with
  `reason: "too_short"` and its locator, exactly like a short heading chunk.
- A provider that returns no nodes, or a null document, is a fallback: the caller splits
  with `file` and adds `warning: split_fallback: <reason>` (story 3 defines the split
  value; story 2 only exposes the warning field — see story 4 for the `warnings` response
  field, or emit it in `errors` with the `warning:` prefix if 4 has not landed).

No `code` value is added to `ValidateSplit`/the CLI/MCP enum in this story. Story 3 adds
it together with the provider that can serve it. That keeps story 2 a pure seam and keeps
its tests free of a public contract change.

## Edits

| File | Change |
| --- | --- |
| `src/Dossier/OutlineProviders.cs` | New: `IOutlineProvider`, `OutlineResult` |
| `src/Dossier/Dump.cs` | `Chunk` gains the optional node fields; `BuildFact` writes `data`/`items`/symbol ref; new internal `OutlineToChunks`; a small `ResolveProvider(path)` over a provider list that is empty in this story |
| `docs/architecture.md` | `Dump.cs` row: "Deterministic ingest, the markdown heading splitter, and the outline-provider seam"; add `OutlineProviders.cs` |
| `tests/Dossier.Tests/OutlineSplitTests.cs` | New: drive `OutlineToChunks` with a fake provider |

Do **not** edit `tests/Dossier.Tests/DumpTests.cs`. That is the story's oracle.

## Tests

Red first: `OutlineSplitTests` cannot compile before the interface and mapping exist
(`CS0246`). Record that, then make it green. These tests are new coverage, not a rewrite.

```csharp
[Test] Outline_NodeBecomesOneChunkWithSymbolData()        // text=signature, data.start_line/end_line/entity_kind
[Test] Outline_SignatureAbsent_UsesNameAsText()
[Test] Outline_NestedNodesCarryParentQualifiedName()      // children after parent, document order
[Test] Outline_DocBecomesOneItemNotPartOfText()
[Test] Outline_ParseErrorsAppearOnEveryFactOfTheDocument()
[Test] Outline_TooShortNodeIsSkippedWithLocator()
[Test] Outline_SymbolRefOnlyWhenRevisionIsKnown()         // no rev -> no symbol ref, no throw
[Test] Outline_EmptyDocumentReportsFallbackReason()
```

No provider is registered for `heading`/`file`/`none`; these tests call the mapping
directly, which is why the seam is exercised without a public flag.

Green, and the unchanged oracle:

```sh
dotnet test --solution Dossier.sln -c Release --no-build
git diff --stat tests/Dossier.Tests/DumpTests.cs   # must print nothing
```

## Done-when evidence

| Claim | Evidence |
| --- | --- |
| The interface exists and is the path to the splitter | `src/Dossier/OutlineProviders.cs`; story 3's `ResolveProvider` call |
| The Python path is reached through it | **Re-scoped:** there is no Python path. Say this in the PR and point at D4b. |
| Existing code-split tests pass unchanged | `dotnet test` output + empty `DumpTests.cs` diff |
| No behaviour change | `heading`/`file`/`none` facts keep their exact JSON (`DumpTests` green); `git diff src/Dossier/Dump.cs` shows no change to `Split`, `SplitHeading` or `DefaultSplit` |

## Risks

- **A seam with no implementation.** If this lands alone it is indirection reviewers
  cannot exercise. Recommended PR layout: bundle stories 2 and 3 in one PR, two commits
  (`refactor: outline-provider seam`, `feat: C# outline provider`), so the seam's first
  user is in the same review.
- **Exposing internals for tests.** `InternalsVisibleTo` already exists
  (`src/Dossier/Dossier.csproj:29-31`). Use it; do not make the interface public.
- **Do not change `DefaultSplit`.** A `.cs` file must still default to `none` until story
  3 deliberately changes that (if it does at all; the recommendation is that it does not
  and `code` stays explicit).

## Size

~140 production lines, ~120 test lines, ~4 doc lines. With story 3: ~2 source files more.
