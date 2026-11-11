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

# The seed declares one screenshot attachment (the "shot" fact in memos.json) but posting stores no
# bytes. Place it content-addressed at blobs/<sha256> next to the database, so publish copies it into
# subjects/<slug>/assets/ instead of warning "missing blob" and dropping the bytes.
BLOBS="$(dirname "$DOSSIER_DB")/blobs"
SHOT="$ROOT/scripts/seed/shot-1x1.png"
DECLARED_SHA="$(jq -r 'first(.facts[].attachments[]?.sha256) // empty' "$ROOT/scripts/seed/memos.json")"
if [ -z "$DECLARED_SHA" ]; then
  echo "scripts/seed/memos.json declares no attachment sha256" >&2
  exit 1
fi

if command -v shasum >/dev/null 2>&1; then
  sha256_of() { shasum -a 256 "$1" | cut -d' ' -f1; }
elif command -v sha256sum >/dev/null 2>&1; then
  sha256_of() { sha256sum "$1" | cut -d' ' -f1; }
else
  echo "need shasum or sha256sum to verify the seed attachment" >&2
  exit 1
fi

actual_sha="$(sha256_of "$SHOT")"
if [ "$actual_sha" != "$DECLARED_SHA" ]; then
  echo "seed attachment drift: $SHOT hashes to $actual_sha but memos.json declares $DECLARED_SHA" >&2
  exit 1
fi

mkdir -p "$BLOBS"
cp "$SHOT" "$BLOBS/$DECLARED_SHA"

stored_sha="$(sha256_of "$BLOBS/$DECLARED_SHA")"
if [ "$stored_sha" != "$DECLARED_SHA" ]; then
  echo "seed blob drift: $BLOBS/$DECLARED_SHA hashes to $stored_sha but memos.json declares $DECLARED_SHA" >&2
  exit 1
fi

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
