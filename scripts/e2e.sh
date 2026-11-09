#!/usr/bin/env bash
# End-to-end demo: seed a temp DB and print every surface of the loop.
set -euo pipefail
set -x

ROOT="$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)"
DLL="$ROOT/src/Dossier/bin/Release/net10.0/Dossier.dll"

TMP="$(mktemp -d "${TMPDIR:-/tmp}/dossier-e2e.XXXXXX")"
export DOSSIER_DB="$TMP/dossier.db"
trap 'rm -rf "$TMP"' EXIT

if [ ! -f "$DLL" ]; then
  echo "missing $DLL; build it with: dotnet build -c Release src/Dossier/Dossier.csproj" >&2
  exit 1
fi

# Count the comma-separated elements of a compact JSON array like ["a","b"] or [].
count_json_array() {
  local arr="$1" count=1 rest
  arr="${arr#\[}"
  arr="${arr%\]}"
  if [ -z "$arr" ]; then
    printf '0'
    return
  fi
  rest="$arr"
  while [ "${rest#*,}" != "$rest" ]; do
    count=$((count + 1))
    rest="${rest#*,}"
  done
  printf '%d' "$count"
}

# Pull the first compact array value for a field out of one-line JSON.
array_field() {
  printf '%s' "$1" | sed -n "s/.*\"$2\":\(\[[^]]*\]\).*/\1/p"
}

# 1. Seed and count subjects/facts from the post_facts responses.
seed_out="$(bash "$ROOT/scripts/seed.sh")"
subjects_created="$(printf '%s\n' "$seed_out" | sed -n 's/^subjects_created=//p')"
facts_created="$(printf '%s\n' "$seed_out" | sed -n 's/^facts_created=//p')"
echo "== subjects created: $subjects_created"
echo "== facts created: $facts_created"

# 2. Compile counts for the root subject, without and with descendants.
plain_json="$(dotnet "$DLL" dossier compile --subject "Memos" --depth full 2>/dev/null)"
plain_facts="$(printf '%s' "$plain_json" | jq '.facts | length')"
descendants_json="$(dotnet "$DLL" dossier compile --subject "Memos" --depth full --descendants 2>/dev/null)"
descendants_facts="$(printf '%s' "$descendants_json" | jq '.facts | length')"
echo "== compile Memos (default budget): facts=$plain_facts"
echo "== compile Memos --descendants: facts=$descendants_facts"
if [ "$descendants_facts" -le "$plain_facts" ]; then
  echo "descendants compile ($descendants_facts) must exceed plain compile ($plain_facts)" >&2
  exit 1
fi

# 3. A search result count for a query.
search_json="$(dotnet "$DLL" search --subject "Memos/Home" --q "composer" --limit 100)"
search_total="$(printf '%s' "$search_json" | sed -n 's/.*"total":\([0-9]*\).*/\1/p')"
echo "== search total for q=composer: $search_total"

# 4. The compiled markdown for Memos/Home at depth full.
markdown="$(dotnet "$DLL" dossier compile --subject "Memos/Home" --depth full --format markdown 2>/dev/null)"
printf '%s\n' "$markdown"

# 5. The conflicts section (three seeded contradictions on Memos/Home).
printf '%s\n' "$markdown" | sed -n '/^## Conflicts/,$p'

# 6. The gaps for two needs that no fact answers.
gaps_md="$(dotnet "$DLL" dossier compile --subject "Memos/Home" --depth full --format markdown --need "billing invoice" --need "webhook signature" 2>/dev/null)"
printf '%s\n' "$gaps_md" | sed -n '/^## Gaps/,$p'

# 7. A dump manifest with created and deduped counts (two identical dumps).
dump_first="$(dotnet "$DLL" dump --source "$ROOT/scripts/seed/notes.md" --subject "Memos" --split heading)"
dump_second="$(dotnet "$DLL" dump --source "$ROOT/scripts/seed/notes.md" --subject "Memos" --split heading)"
echo "== dump first:  created=$(count_json_array "$(array_field "$dump_first" created)") deduped=$(count_json_array "$(array_field "$dump_first" deduped)")"
echo "== dump second: created=$(count_json_array "$(array_field "$dump_second" created)") deduped=$(count_json_array "$(array_field "$dump_second" deduped)")"

# 8. A correlate proposal count.
correlate_json="$(dotnet "$DLL" correlate --subject "Memos/Home")"
correlate_count="$(printf '%s' "$correlate_json" | { grep -o '"fact_id"' || true; } | wc -l | tr -d ' ')"
echo "== correlate proposals: $correlate_count"
