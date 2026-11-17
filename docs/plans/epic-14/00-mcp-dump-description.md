# Story 0 — correct the MCP dump description

Issue: [#15](https://github.com/scoizzle/dossier/issues/15). Tier: T0. Depends on: none.

## Premise check (`ee9469e1`)

Already done. The registered description is:

```csharp
new("dump", "Chunk a file into facts for one subject, deduping repeats. " + Untrusted,
    """{… "properties":{"source":…,"subject":…,…},"required":["source","subject"]}"""),
```

`src/Dossier/Mcp.cs:280-281`. It says "a file", and `source` is a single required
string. There is no "file or directory" left to correct, and the code cannot read a
directory: `File.ReadAllBytes` at `src/Dossier/Dump.cs:74`.

The epic's line reference (`Mcp.cs:209`) is also two moves stale.

## What to change

No product code. The point of the issue is that the advertised contract matches the
code, so make that checkable instead of a reading exercise:

1. Extend `tests/Dossier.Tests/McpTests.cs:214`
   (`Mcp_DumpToolAdvertisesSplitEnum`) — do not add a second tools/list test — with
   two assertions on the same `tool`:

   ```csharp
   var description = tool.GetProperty("description").GetString()!;
   await Assert.That(description).Contains("Chunk a file");
   await Assert.That(description.Contains("directory", StringComparison.OrdinalIgnoreCase)).IsFalse();
   ```

   Rename the test to `Mcp_DumpToolAdvertisesOneFileAndTheSplitEnum` so the name states
   what it now pins. This strengthens the existing test; it removes no assertion.

2. Close #15 with the test name and the `dotnet test` line as evidence.

## Red check first

```sh
dotnet test --solution Dossier.sln -c Release --filter-query "/Mcp_DumpToolAdvertisesOneFileAndTheSplitEnum"
```

Red reason at `ee9469e1`: the test name does not exist yet (`no tests matched`). After
the rename the assertion passes immediately — the red is the missing pin, not a bug,
and the plan says so rather than inventing a failure.

## Done-when evidence

| Claim | Evidence |
| --- | --- |
| The description matches the code | `src/Dossier/Mcp.cs:280`; the new assertions |
| No directory is accepted | `DumpRequest.Source` is one string (`src/Dossier/Dump.cs:8-15`), `File.ReadAllBytes` (`:74`), schema `required:["source"]` (`src/Dossier/Mcp.cs:281`) |
| `dotnet test` green | CI command, pasted in the PR |

## Out of scope

- Accepting a directory. That is story 4 (`#19`), which changes this description again
  to mention `--source-root` and a directory.

## Size

One test edit, under 10 lines. No docs change: `docs/cli.md:7` already says `--source
<path>`.
