#!/usr/bin/env bash
# Seed the Memos demo into $DOSSIER_DB.
#
# A post_facts request carries exactly one subject, so the seed is five valid
# requests: scripts/seed/memos-root.json plus the four screen files, with
# scripts/seed/memos.json holding the 24 Home facts (the eval subject).
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

post() {
  local file="$1" out created new
  out="$(dotnet "$DLL" post --file "$ROOT/scripts/seed/$file")"
  created="$(printf '%s' "$out" | { grep -o '"created":true' || true; } | wc -l | tr -d ' ')"
  new="$(printf '%s' "$out" | { grep -o '"status":"new"' || true; } | wc -l | tr -d ' ')"
  subjects_created=$((subjects_created + created))
  facts_created=$((facts_created + new))
  printf 'posted %s: subjects_created=%s facts_new=%s\n' "$file" "$created" "$new" >&2
}

dotnet "$DLL" init >/dev/null

post memos-root.json
post memos-signin.json
post memos-memodetail.json
post memos-archived.json
post memos.json

printf 'subjects_created=%d\n' "$subjects_created"
printf 'facts_created=%d\n' "$facts_created"
