<img src="assets/icon.svg" width="64" height="64" alt="">

# Dossier

Created in [T3 Code](https://t3.codes).

## Quick start

```sh
dotnet build -c Release src/Dossier/Dossier.csproj
DOSSIER_DB=./dossier.db dotnet src/Dossier/bin/Release/net10.0/Dossier.dll init
DOSSIER_DB=./dossier.db bash scripts/seed.sh
DOSSIER_DB=./dossier.db dotnet src/Dossier/bin/Release/net10.0/Dossier.dll dossier compile --subject Memos/Home --depth full --format markdown
```

See `docs/PLAN.md#end-to-end` for the full demo (`bash scripts/e2e.sh`) and the
evaluation harness (`bash scripts/eval.sh`).
