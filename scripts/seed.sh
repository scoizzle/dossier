#!/usr/bin/env bash
# Seed the Memos demo into $DOSSIER_DB.
#
# A post_facts request carries exactly one subject, so the seed is five valid
# requests: scripts/seed/memos-root.json plus the four screen files, with
# scripts/seed/memos.json holding the 24 Home facts (the eval subject). The root
# is posted first and its returned id becomes the parent of all four children.
set -euo pipefail
set -x

ROOT="$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)"
DLL="$ROOT/src/Dossier/bin/Release/net10.0/Dossier.dll"
export DOSSIER_DB="${DOSSIER_DB:-$ROOT/dossier.db}"

if [ ! -f "$DLL" ]; then
  echo "missing $DLL; build it with: dotnet build -c Release src/Dossier/Dossier.csproj" >&2
  exit 1
fi

subjects_created=0
facts_created=0

record() {
  local label="$1" out="$2" created new
  created="$(printf '%s' "$out" | jq '[.subject.created] | map(select(.)) | length')"
  new="$(printf '%s' "$out" | jq '[.facts[].status] | map(select(. == "new")) | length')"
  subjects_created=$((subjects_created + created))
  facts_created=$((facts_created + new))
  printf 'posted %s: subjects_created=%s facts_new=%s\n' "$label" "$created" "$new" >&2
}

dotnet "$DLL" init >/dev/null

root_out="$(dotnet "$DLL" post --file "$ROOT/scripts/seed/memos-root.json")"
root_id="$(printf '%s' "$root_out" | jq -r '.subject.id')"
if [ -z "$root_id" ] || [ "$root_id" = "null" ]; then
  echo "seed root post returned no subject id" >&2
  exit 1
fi
record memos-root.json "$root_out"

for file in memos-signin.json memos-memodetail.json memos-archived.json memos.json; do
  child_out="$(jq --arg parent "$root_id" '.subject.parent = $parent' "$ROOT/scripts/seed/$file" | dotnet "$DLL" post --file -)"
  record "$file" "$child_out"
done

printf 'subjects_created=%d\n' "$subjects_created"
printf 'facts_created=%d\n' "$facts_created"
