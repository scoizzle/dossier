# Releasing

Maintainer notes. Users: see [install](install.md).

## Cutting a release

To cut a release, tag a commit that is on `main` and push the tag:

```sh
git tag v1.2.3
git push origin v1.2.3
```

The tag must look like `vMAJOR.MINOR.PATCH` with an optional prerelease suffix (`v1.2.3-rc.1`; a suffix marks the GitHub release as a prerelease). The release workflow builds Native AOT binaries, smoke-tests each one, and publishes a GitHub release with these assets:

- `dossier-<version>-linux-x64.tar.gz`
- `dossier-<version>-linux-arm64.tar.gz`
- `dossier-<version>-osx-arm64.tar.gz`
- `dossier-<version>-win-x64.zip`
- `SHA256SUMS`

`workflow_dispatch` runs the same build and package steps and uploads them as workflow artifacts, but never creates a GitHub release and never pushes to nuget.org.

## .NET tool packages

The same binaries are published to nuget.org as the .NET tool `Dossier.Cli` (the command is `dossier`). The package id is not `Dossier` because that id is taken on nuget.org. The layout is the .NET 10 RID-specific tool format (`src/Dossier/Dossier.csproj` sets `ToolPackageRuntimeIdentifiers`):

| Package | Contents | Built by |
| --- | --- | --- |
| `Dossier.Cli.<version>.nupkg` | pointer: tool settings listing the five package ids below, `README.md`, `icon.png`, `.mcp/server.json`. No code. | `dotnet pack` (no `-r`) |
| `Dossier.Cli.win-x64.<version>.nupkg` | Native AOT `Dossier.exe` + native SQLite | `dotnet pack -r win-x64 -p:PublishAot=true` on Windows |
| `Dossier.Cli.linux-x64.<version>.nupkg` | Native AOT `Dossier` + native SQLite | `dotnet pack -r linux-x64 -p:PublishAot=true` on Linux x64 |
| `Dossier.Cli.linux-arm64.<version>.nupkg` | Native AOT `Dossier` + native SQLite | `dotnet pack -r linux-arm64 -p:PublishAot=true` on Linux arm64 |
| `Dossier.Cli.osx-arm64.<version>.nupkg` | Native AOT `Dossier` + native SQLite | `dotnet pack -r osx-arm64 -p:PublishAot=true` on macOS arm64 |
| `Dossier.Cli.any.<version>.nupkg` | framework-dependent IL + every RID's native SQLite | `dotnet pack -r any -p:PublishAot=false` |

Rules that matter:

- **Always pack the pointer with `-p:PublishAot=true`.** It ships no code, but without the flag the SDK tries to pack every RID itself as non-AOT packages, in-process, with the wrong contents. `-p:PublishAot=true` makes `dotnet pack` produce only the pointer.
- **A RID package is packed on a runner whose OS matches the RID.** Native AOT does not cross-compile across operating systems. The `.nupkg` version must equal the pointer's version exactly.
- **Symbols are excluded from the packages.** Native AOT leaves a `.dSYM` bundle (macOS) or a `.pdb` (Windows) in the publish directory; `ExcludeToolPackageSymbols` drops both so the macOS package is about 10 MB rather than 46 MB.
- **The MCP manifest carries the version.** `src/Dossier/.mcp/server.json` is the committed template; `GenerateMcpServerManifest` rewrites both `version` fields to `$(Version)` into `obj/` at pack time and adds it to the pointer package only. Keep the template's description at or under 100 characters and its name in reverse-DNS form (`io.github.scoizzle/dossier`).
- **`PackageType` is `McpServer` for the pointer only.** The SDK replaces the package type on the RID and `any` packages with `DotnetToolRidPackage`, so nuget.org does not list them as tools or MCP servers.

To rehearse locally (needs the .NET 10 SDK; run the RID pack only on a matching OS):

```sh
dotnet restore src/Dossier/Dossier.csproj -p:PublishAot=true
dotnet pack src/Dossier/Dossier.csproj -c Release -p:PublishAot=true -p:Version=0.0.0-local -o feed

dotnet restore src/Dossier/Dossier.csproj -r any -p:PublishAot=false
dotnet pack src/Dossier/Dossier.csproj -c Release -r any -p:PublishAot=false -p:Version=0.0.0-local -o feed

RID=osx-arm64   # the RID of this machine
dotnet restore src/Dossier/Dossier.csproj -r "$RID" -p:PublishAot=true
dotnet pack src/Dossier/Dossier.csproj -c Release -r "$RID" -p:PublishAot=true -p:Version=0.0.0-local -o feed

bash scripts/verify-tool-packages.sh feed 0.0.0-local "$RID"
```

`scripts/verify-tool-packages.sh` checks the package types, the versions, the MCP manifest, the command settings and that no debug symbols were packed. The `tool-package` CI job then installs from the feed and runs the full [smoke test](../scripts/smoke-aot.sh) plus `dnx` on every RID; the release's `tool-smoke` job repeats that on the tag before publishing.

### Publishing order and the nuget.org policy

The release workflow does this in order: build and smoke the four archives, pack each RID package in the same build matrix, pack the pointer and `any` (`tool-meta`), install and smoke every RID from a folder feed (`tool-smoke`), then push (`nuget-publish`) and verify from nuget.org (`verify-published`).

- The four RID packages and `any` are pushed **before** the pointer, because the pointer is what `dotnet tool install` resolves; a pointer that lands first makes the tool uninstallable until its RID packages arrive.
- `--skip-duplicate` makes a rerun of a partially pushed version idempotent. A published version cannot be replaced or deleted (only unlisted), so the smoke test before the push is the only protection.
- `nuget-publish` is the only job with `id-token: write`. It exchanges the GitHub OIDC token for a short-lived key with `NuGet/login`, so no long-lived nuget.org API key is stored in the repository.

One-time owner setup on nuget.org:

1. Create the account that owns the packages and set its profile name; store it as the repository secret `NUGET_USER`.
2. Add a **Trusted Publishing** policy for this repository and the `release.yml` workflow (`scoizzle/dossier`, workflow `release.yml`, no environment unless one is added to the job). The policy is what lets `NuGet/login` mint a key.
3. Reserve the `Dossier.Cli` prefix so nobody can publish a `Dossier.Cli.*` package id ahead of the RID packages.

The first publish of a new major or package-id change should be a pre-release (`v0.2.0-rc.1`): verify the published install first, then tag the final release. `verify-published` re-runs `dotnet tool install -g Dossier.Cli --version <version>` and `dnx Dossier.Cli --version <version> -- version` on Windows x64, Linux x64, Linux arm64 and macOS arm64 after a tag, retrying while nuget.org indexes. That job is the evidence for the release's done-when line; it only exists once a tag has been pushed, so a dry run cannot prove it.

The GitHub release and the nuget.org push are independent jobs: a failed push leaves the archives published on GitHub but the tool unavailable. Re-running the workflow for the same tag is the fix (`--skip-duplicate` makes the packages that did land a no-op); do not delete or move the tag.
