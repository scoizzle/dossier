# Contributing to Dossier

Thanks for your interest. Dossier is maintained by a single person, so replies are best-effort.

## Prerequisites

- The .NET 10 SDK (the project targets `net10.0`; CI uses `10.0.x`).
- `global.json` selects the Microsoft.Testing.Platform test runner, which the `dotnet test --solution` form below needs.
- Node is optional; it is only needed for the graph page smoke test.

## Build and test

These are the commands CI runs (see `.github/workflows/ci.yml`, which is authoritative):

```sh
dotnet restore Dossier.sln -p:NuGetAuditLevel=moderate "-p:WarningsAsErrors=NU1902%3BNU1903%3BNU1904"
dotnet build Dossier.sln -c Release --no-restore
dotnet test --solution Dossier.sln -c Release --no-build
```

CI also enforces a minimum test count, so do not delete tests to make a run pass. Optionally, run the graph page smoke test (CI runs it on Linux):

```sh
node scripts/graph-smoke.mjs
```

## Proposing changes

- For anything non-trivial, open an issue first so we can agree on the approach.
- Keep pull requests small and focused.
- Add or update tests for behaviour changes.
- CI must pass, including the gitleaks secret scan. Never commit secrets or personal data.

## Security

Do not report vulnerabilities in public issues or pull requests. See [SECURITY.md](SECURITY.md).

## License

By contributing you agree that your contributions are licensed under the repository's MIT license, see [LICENSE](LICENSE).
