#!/usr/bin/env bash
# Scaling measurement: does the dossier's token cost stay bounded as the corpus grows?
# Builds synthetic corpora of 50, 200 and 1000 distinct facts on one subject in temp
# databases, compiles each at budget 1200, depth full, format markdown, and prints
# plain-facts tokens vs dossier tokens. Output is deterministic (no ids or times printed).
set -euo pipefail

ROOT="$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)"
DLL="$ROOT/src/Dossier/bin/Release/net10.0/Dossier.dll"
SUBJECT="Scaling/Corpus"
BUDGET=1200

if [ ! -f "$DLL" ]; then
  echo "missing $DLL; build it with: dotnet build -c Release src/Dossier/Dossier.csproj" >&2
  exit 1
fi

TMP="$(mktemp -d "${TMPDIR:-/tmp}/dossier-scaling.XXXXXX")"
trap 'rm -rf "$TMP"' EXIT

printf 'budget=%s depth=full format=markdown estimator=chars/4\n' "$BUDGET"
printf '%-6s %-20s %-15s %-14s %s\n' "N" "plain-facts tokens" "dossier tokens" "facts emitted" "ratio plain/dossier"

for n in 50 200 1000; do
  export DOSSIER_DB="$TMP/n$n.db"
  jq -nc --arg s "$SUBJECT" --argjson n "$n" '
    {subject: {name: $s},
     facts: [range(0; $n) | . as $i | ($i | tostring | ("0000" + .)[-4:]) as $p
             | {kind: "note", text: "entry \($p) alpha\($p) beta\($p) gamma\($p) delta\($p)"}]}' \
    > "$TMP/post$n.json"
  dotnet "$DLL" post --file "$TMP/post$n.json" >/dev/null

  jq -r '.facts[].text' "$TMP/post$n.json" > "$TMP/plain$n.txt"
  dotnet "$DLL" dossier compile --subject "$SUBJECT" --budget "$BUDGET" --depth full --format markdown \
    > "$TMP/dossier$n.md" 2>/dev/null

  plain_chars="$(wc -c < "$TMP/plain$n.txt" | tr -d ' ')"
  dossier_chars="$(wc -c < "$TMP/dossier$n.md" | tr -d ' ')"
  plain_tokens=$(( (plain_chars + 3) / 4 ))
  dossier_tokens=$(( (dossier_chars + 3) / 4 ))
  emitted="$(awk '/^## / { exit } /^- / { c++ } END { print c + 0 }' "$TMP/dossier$n.md")"
  ratio="$(awk -v p="$plain_tokens" -v d="$dossier_tokens" 'BEGIN { if (d == 0) { print "n/a" } else { printf "%.2f", p / d } }')"
  printf '%-6s %-20s %-15s %-14s %s\n' "$n" "$plain_tokens" "$dossier_tokens" "$emitted" "$ratio"
done
