# Installing a release

Release archives, the .NET tool package, platform notes and verification. Back to the [README](../README.md). Maintainers cutting a release: [releasing](releasing.md).

## Install as a .NET tool

The tool package id is `Poly.Dossier` (plain `Dossier` is taken on nuget.org); the command it installs is `dossier`.

```sh
dotnet tool install -g Poly.Dossier   # add --version <version> to pin one, or --prerelease for a pre-release
dossier version
dotnet tool update -g Poly.Dossier    # later
```

Without installing, `dnx` runs it from nuget.org in one gesture (it needs the .NET 10 SDK, which ships `dnx`):

```sh
dnx Poly.Dossier -- version
dnx Poly.Dossier -- help
```

The package is RID-specific: the .NET CLI downloads the Native AOT build for `win-x64`, `linux-x64`, `linux-arm64` or `osx-arm64`. On any other platform (for example `osx-x64` or `win-arm64`) it downloads the framework-dependent `any` fallback, which needs the .NET 10 runtime installed. An install needs network access to nuget.org for the package and, the first time, for the .NET apphost pack the command shim is built from.

MCP clients start the server like this (stdio JSON-RPC):

```json
{"command": "dnx", "args": ["Poly.Dossier", "--yes", "--", "mcp"]}
```

An installed tool works the same: `{"command": "dossier", "args": ["mcp"]}`. `DOSSIER_DB` selects the store (default `./dossier.db`) and `DOSSIER_AGENT` names the writer when the client sends no `clientInfo.name`; both are optional and documented in [cli](cli.md). nuget.org lists the package's `.mcp/server.json` under its "MCP Server" tab.

Versions are published in a fixed order — the four RID packages and `any` first, the pointer package last — because the pointer is what `dotnet tool install` resolves. If an install says the package cannot be found just after a release, nuget.org is still indexing it; retry in a few minutes. A pre-release version is never picked up by a plain `dotnet tool install -g Poly.Dossier`; name it with `--version` (or add `--prerelease`).

## Choosing and verifying an archive

Pick the archive that matches your machine:

| Archive | Machines |
| --- | --- |
| `linux-x64` | Intel/AMD 64-bit Linux with glibc 2.34+ |
| `linux-arm64` | 64-bit ARM Linux with glibc 2.34+. Tested on GitHub's Ubuntu 24.04 arm64 runners. Raspberry Pi 4/5 with a 64-bit OS, AWS Graviton, and Linux VMs on Apple Silicon (Parallels, UTM) should work but are not covered by CI |
| `osx-arm64` | Apple Silicon Macs |
| `win-x64` | Windows x64, and Windows 11 on ARM should run it through built-in x64 emulation |

On Linux, `uname -m` tells you which one: `x86_64` means `linux-x64`, `aarch64` means `linux-arm64`. `cannot execute binary file: Exec format error` means you downloaded the wrong architecture.

Each archive extracts into a single directory, `dossier-<version>-<rid>/`, containing the `dossier` binary (`dossier.exe` on Windows), the native SQLite library, the README, `LICENSE`, `THIRD-PARTY-NOTICES.md`, and `dotnet-runtime-THIRD-PARTY-NOTICES.TXT` (the .NET runtime's own notices). Keep the native SQLite library beside the binary; the binary does not run without it. Verify a download against `SHA256SUMS` in the same directory and, optionally, check its build provenance, then extract:

```sh
sha256sum -c --ignore-missing SHA256SUMS      # Linux
shasum -a 256 -c --ignore-missing SHA256SUMS  # macOS
gh attestation verify dossier-<version>-linux-arm64.tar.gz --repo scoizzle/dossier  # build provenance
tar -xzf dossier-<version>-linux-arm64.tar.gz && cd dossier-<version>-linux-arm64
```

Each archive carries a GitHub artifact attestation proving it was built by this repository's release workflow from the tagged commit (releases published before attestations were added have none). `gh attestation verify` needs GitHub CLI 2.49 or later; use the `.zip` name for `win-x64`. `SHA256SUMS` itself is not attested; the attestations cover the four archives.

Platform notes:

- Linux binaries are built and tested on Ubuntu 24.04, on both x64 and arm64 runners. They need glibc 2.34 or newer — the release workflow measures the highest glibc symbol version that `linux-x64` and `linux-arm64` require on every release, and fails any build that would need more than 2.39 — plus `libicu` and OpenSSL (`libssl3`). Distributions at or above 2.34 include Ubuntu 22.04 or newer, Debian 12 or newer, Fedora 35 or newer, RHEL 9 / Rocky 9 / Alma 9 or newer, and Amazon Linux 2023; older ones such as Ubuntu 20.04 and Debian 11 are not supported.
- macOS binaries are unsigned. If Gatekeeper blocks the binary, remove the quarantine flag from the whole extracted directory (it also lands on `libe_sqlite3.dylib`): `xattr -dr com.apple.quarantine <extracted dir>`.
