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
evaluation harness:

```sh
bash scripts/eval.sh
```

The baseline is primary sources: the original git files and screenshots an agent
would read without Dossier (arm C). Search JSON and plain fact lines are the
product's own output, not baselines. On the current run the dossier is 708 tokens
against at least 6171 for primary sources (a lower bound: three seeded paths do
not resolve upstream, and the screenshot size is declared), while the compile
stage alone is a net loss against plain fact lines at 24 facts. See
`docs/PLAN.md#evaluation`.
