# Story 1 — outline contract

Issue: [#16](https://github.com/scoizzle/dossier/issues/16). Tier: T2 (public contract).
Depends on: none. Blocks: 5 (`#20`), 6 (`#21`), and the seam in 2 (`#17`).

## Premise check (`ee9469e1`)

The contract directory has seven schemas and no outline schema
(`contract/*.schema.json`). There is one relevant existing decision: `Locator` carries
`line` plus a free-form `selector`, and `Dump` already writes the range as
`line=<start>` + `selector="L<start>-L<end>"` (`src/Dossier/Dump.cs:324-330`,
`contract/ref.schema.json:28-43`). The schema test helper in
`tests/Dossier.Tests/JsonlSchemaTests.cs` already validates `$ref`, `$defs`, `const`,
`enum`, `required` and `additionalProperties`, but it is private to that class.

## Decisions this story settles

### D1 — `Locator` keeps `line` + `selector`

Do **not** add `end_line` to `Locator`. Outline nodes carry `start_line` and `end_line`;
code facts additionally put `start_line`/`end_line` in `data` (D3). The mapping to a ref
stays `{ "line": start, "selector": "L<start>-L<end>" }`.

Why:

- `Locator` is a published contract with `additionalProperties: false`. Adding a field
  means new bundles cannot be imported by an older dossier, for a range the outline
  node and `data` already carry. Pre-1.0 that is still a migration nobody asked for.
- The selector is already the human- and machine-readable range, and `Dump` is its only
  producer. Story 5 parses `^L(\d+)-L(\d+)$` when the ref also has a `file` kind and
  `rev`; anything else falls back to `#L<line>`. That is a bounded, tested parse of
  dossier's own format, not of user prose.
- The alternative (optional `end_line`, selector kept for display) buys nothing that
  `data.start_line`/`data.end_line` does not, and costs a contract widening in the
  story that is explicitly allowed to make exactly one such decision.

Reject the alternative explicitly in the PR so it is not re-litigated in story 5.

### D2 — qualified names

```text
namespace.type[.nested].member(param-type,...)
```

- Namespace omitted in the global namespace. Nested types join with `.` (never `+`).
- Generic **types** and **methods** use metadata arity: ``Ns.Box`1``, ``Ns.Box`1.Inner``,
  ``Ns.Type.Map`2``. This disambiguates `M()` from `M<T>()`, which C# allows.
- Constructors: `.ctor(...)`; static constructors: `.cctor()`; indexers: `.this[int,string]`;
  finalizers `.Finalize()`; operators metadata names (`.op_Addition(int,int)`).
- Explicit interface implementations qualify the interface member:
  `Ns.Type.IFoo.Bar(int)` where the interface is written as the source names it.
- Conversions carry the target type because the parameter list alone can collide:
  `.op_Implicit(int)->Ns.Meters`.
- Parameter types are canonical, **not** source-spelled: predefined types are always
  `int`/`string`/`object`/…, all types are fully qualified without `global::`, nullable
  annotations become `?`, arrays `[]`, generic arguments recursive (`List<int>`,
  `Dictionary<string,List<int>>`), type parameters `T`. No parameter names, no spaces
  after commas. `ref`/`out`/`in` are dropped (C# does not overload on them); `params` is
  dropped; pointer/`nint` spellings are kept canonical. This is the only way
  `List<int>` and a source-spelled `System.Collections.Generic.List<int>` name the same
  overload.
- No return type (except a conversion's target), no modifiers, no revision, no hash. The
  revision belongs in the ref target (`<qualified-name>@<revision>`,
  `contract/ref.schema.json:5`).
- **Partial types are merged into one node** by the provider: start_line is the first
  declaration's start, end_line the last declaration's end, and children are the union.
  One fact per type is the issue's requirement, and duplicate qualified names are a
  validation error, so leaving merging to consumers is not an option.

Pinned by a test with an overload set that differs only by parameter type, one that
differs only by arity, a nested generic, and an indexer.

### D3 — syntax errors and the fact payload

`parse_errors` lives on the outline **document** (count of Roslyn diagnostics), and a
code fact records `data.parse_errors` only when the count is > 0. `data` is open JSON
(`contract/fact.schema.json:20-23`), so this needs no schema change. The same `data`
object carries:

```json
{ "symbol": "Ns.Type.Method(int,string)", "entity_kind": "method", "parent": "Ns.Type",
  "start_line": 12, "end_line": 20, "parse_errors": 2 }
```

`parent` is the qualified name of the containing node, or absent at the top level.

## The schema

`contract/outline.schema.json` (new):

```json
{
  "$schema": "https://json-schema.org/draft/2020-12/schema",
  "$id": "https://dossier.local/contract/outline.schema.json",
  "title": "Outline",
  "description": "Language-neutral symbol outline for one source file: the seam between dossier and a built-in or external outline provider. Lines are 1-based and inclusive. The root object is what an external provider returns on stdout (story 6) and what the C# provider produces (story 3). A file that cannot be outlined produces no document; the caller falls back to a whole-file chunk.",
  "type": "object",
  "additionalProperties": false,
  "required": ["version", "language", "nodes"],
  "properties": {
    "version": { "const": 1 },
    "language": { "type": "string", "minLength": 1, "description": "Provider id, e.g. csharp." },
    "parse_errors": { "type": "integer", "minimum": 0, "description": "Syntax diagnostics found while recovering the tree; absent or 0 when clean." },
    "nodes": { "type": "array", "items": { "$ref": "#/$defs/Node" } }
  },
  "$defs": {
    "Node": {
      "type": "object",
      "additionalProperties": false,
      "required": ["name", "qualified_name", "kind", "start_line", "end_line", "children"],
      "properties": {
        "name": { "type": "string", "minLength": 1, "description": "Identifier as written: filter, Foo, ctor." },
        "qualified_name": { "type": "string", "minLength": 1, "description": "Per docs/cli.md: namespace.type[.nested].member(param-types); generic arity uses a backtick-n suffix." },
        "kind": { "type": "string", "minLength": 1, "description": "Open string: namespace, class, struct, interface, enum, record, delegate, method, constructor, property, field, event, indexer, operator, function, module, ..." },
        "start_line": { "type": "integer", "minimum": 1 },
        "end_line": { "type": "integer", "minimum": 1 },
        "start_col": { "type": "integer", "minimum": 1 },
        "end_col": { "type": "integer", "minimum": 1 },
        "signature": { "type": "string", "description": "One line, whitespace collapsed, no newline. Null when the declaration has no useful signature." },
        "doc": { "type": "string", "description": "First paragraph of the doc comment or XML summary, whitespace collapsed." },
        "children": { "type": "array", "items": { "$ref": "#/$defs/Node" } }
      }
    }
  }
}
```

Rules JSON Schema cannot express, enforced by `OutlineValidator` (C#) on every document
the code accepts, and pinned by tests:

- `end_line >= start_line`; `end_col` may only appear with `start_col`.
- A child's `[start_line,end_line]` is inside its parent's.
- `qualified_name` is unique among a document's nodes (partial declarations are merged
  before this check, so two parts of one type are one node).

## Edits

| File | Change |
| --- | --- |
| `contract/outline.schema.json` | New, above |
| `src/Dossier/Outline.cs` | New: `OutlineNode`, `OutlineDocument` records, `OutlineValidator.Validate`, and the D2 name formatter used by story 3 |
| `tests/Dossier.Tests/JsonSchema.cs` | New: move the private validator from `JsonlSchemaTests.cs` (methods `Errors`, `Valid`, `Resolve`, `TypeMatches`, the `Annotations` set, `Validate`, `JsonEquals`, `Parse`) into an internal static class; `JsonlSchemaTests` calls it. No assertion changes. |
| `tests/Dossier.Tests/OutlineSchemaTests.cs` | New: positive and negative validation |
| `docs/cli.md` | New "Outline contract" section after the `dump` paragraph; link the schema; state D1–D3 |

`src/Dossier/Outline.cs` must be added to the AOT JSON contract only when it is
serialized (story 6); until then it is plain records and needs no `JsonSerializable`
entry. Do not add one early.

## Tests

Red first: `OutlineSchemaTests` does not compile until the schema and the models exist,
so the first red is `CS0246`/file-not-found. That is the honest red for a new contract;
record it, then make the tests pass.

```csharp
[Test] Outline_AcceptsAMinimalDocument()                     // version 1, one node, empty children
[Test] Outline_RejectsUnknownNodeProperty()                  // additionalProperties: false
[Test] Outline_RejectsMissingEndLine()
[Test] Outline_RejectsEndLineBeforeStartLine()               // validator, not JSON Schema
[Test] Outline_RejectsChildSpanOutsideParent()               // validator
[Test] Outline_RejectsDuplicateQualifiedNames()              // validator
[Test] Outline_KindIsOpen()                                  // "macro" accepted, no enum
[Test] QualifiedName_OverloadsDifferByParameterTypes()       // D2
[Test] QualifiedName_MethodsDifferByArity()                  // D2: M() vs M<T>()
[Test] QualifiedName_IndexerUsesThisBrackets()               // D2
[Test] QualifiedName_GlobalNamespaceHasNoLeadingDot()        // D2
```

`Outline_AcceptsAMinimalDocument` and `Outline_RejectsMissingEndLine` are the two the
issue names; the rest are what makes the contract worth trusting.

Green:

```sh
dotnet test --solution Dossier.sln -c Release --no-build
```

## Done-when evidence

| Claim | Evidence |
| --- | --- |
| `contract/outline.schema.json` is committed | `git show --stat` |
| A valid sample is accepted and an invalid one rejected | `OutlineSchemaTests` names and output |
| `docs/cli.md` documents the contract and both decisions | the new section, read in the PR |
| `dotnet test` green | CI command output |

## Risks

- **Moving the validator** touches a test file whose job is to prove itself. Do it in
  its own commit inside this PR (`refactor: extract the JSON schema validator`) with
  `JsonlSchemaTests` unchanged; if any JSONL test changes, stop — that is a defect in
  the extraction.
- **Kind as an open string** invites typos. Keep it open because the epic says so, and
  put the vocabulary in `docs/cli.md`; do not add an enum.
- `signature` may exceed the 240-character fact rule. Story 3's rule is: `text` is the
  signature when it fits and the qualified name otherwise, `data.signature` always holds
  the full signature, and nothing is truncated.

## Size

~180 new lines (schema + records + validator), ~150 moved lines, ~120 test lines, ~40
doc lines. One PR.
