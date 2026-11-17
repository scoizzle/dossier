# Architecture

Back to the [README](../README.md).

One project, `src/Dossier/Dossier.csproj`: C# on net10.0, SQLite (WAL) with FTS5, raw ADO.NET, no ORM, no DI container. Core operations are plain functions over a `DossierStore`, and the CLI, MCP and web layers are thin transports over them. The core has no models and no network. The only package dependency is `Microsoft.Data.Sqlite`. Tests are TUnit on Microsoft.Testing.Platform.

| File | Owns |
| --- | --- |
| `Models.cs` | Request, response and domain types |
| `Store.cs` | `DossierStore`: the SQLite connection, schema and FTS5 index |
| `PostFacts.cs` | Writes: resolution order (declared supersede, hash dedupe, insert), refs, attachments |
| `Dump.cs` | Deterministic ingest, and the markdown heading splitter |
| `Correlate.cs` | The `same_ref` and `shared_tag` matchers |
| `Search.cs` | Search, filters, reverse `ref_target` lookup |
| `Compile.cs` | Ranking, budgeted selection, conflicts, gaps, markdown rendering |
| `Show.cs`, `Retract.cs` | Fact detail with inbound refs; tombstoning |
| `ContentHash.cs`, `CanonicalJson.cs`, `JsonCodec.cs`, `Names.cs` | Content hashing, canonical JSON, serialization options, name helpers |
| `Mcp.cs` | MCP server over stdio |
| `Web.cs`, `www/index.html`, `www/app.js`, `www/graph.js` | Loopback HTTP server and the embedded page and scripts |
| `Graph.cs` | Bounded graph neighbourhood behind `/api/graph` |
| `Program.cs` | CLI entry point |

## Repository map

```text
README.md          the entry point
docs/              reference docs: concepts, cli, publish, evaluation, ingestion, install, releasing, architecture
Dossier.sln        solution (src project plus tests)
global.json        pins the Microsoft.Testing.Platform test runner
SECURITY.md        security policy: how to report a vulnerability
CONTRIBUTING.md    how to build, test and propose changes
LICENSE            MIT license for Dossier
THIRD-PARTY-NOTICES.md  notices for components shipped in release archives
.github/           CI (ci.yml), the tag-triggered AOT release workflow (release.yml), issue forms and the pull request template
assets/            icon
contract/          JSON Schemas: subject, fact, ref, ops, dossier (the normative shapes)
examples/          memos-bundle/ (committed publish output), NOTICE.md (upstream licenses)
profiles/          consumer quota profiles for publish --profile (copilot-studio.json, generic-large.json)
scripts/           seed.sh, e2e.sh, eval.sh, scaling.sh, scale-test.sh, verify-refs.sh, publish-demo.sh, publish-profile-demo.sh
scripts/smoke-aot.sh       smoke-test a published Native AOT binary
scripts/seed/      the Memos demo corpus and a notes.md for dump
scripts/eval/      questions.json, sources.json; artifacts/ is git-ignored output
skills/dossier/    SKILL.md: how an agent uses Dossier well (the loop, rules, commands)
src/Dossier/       the reference implementation
tests/Dossier.Tests/  TUnit tests
```
