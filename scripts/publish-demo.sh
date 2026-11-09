#!/usr/bin/env bash
# Seed a temp DB with the Memos demo and publish it to examples/memos-bundle.
set -euo pipefail

ROOT="$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)"
DLL="$ROOT/src/Dossier/bin/Release/net10.0/Dossier.dll"
OUT="${1:-$ROOT/examples/memos-bundle}"

if [ ! -f "$DLL" ]; then
  echo "missing $DLL; build it with: dotnet build -c Release src/Dossier/Dossier.csproj" >&2
  exit 1
fi

TMP="$(mktemp -d "${TMPDIR:-/tmp}/dossier-publish.XXXXXX")"
export DOSSIER_DB="$TMP/dossier.db"
trap 'rm -rf "$TMP"' EXIT

bash "$ROOT/scripts/seed.sh" >/dev/null 2>&1

# The seed records one screenshot attachment but posting does not store bytes; place the blob
# (content-addressed at blobs/<sha256> next to the database) so publish can copy it into subjects/<slug>/assets/.
SHOT="$ROOT/scripts/seed/shot-1x1.png"
SHA="$(shasum -a 256 "$SHOT" | cut -d' ' -f1)"
mkdir -p "$TMP/blobs"
cp "$SHOT" "$TMP/blobs/$SHA"

# Run from the repo root with a relative --out so the README's recorded command is portable.
cd "$ROOT"
REL_OUT="${OUT#"$ROOT"/}"
dotnet "$DLL" publish --out "$REL_OUT" >/dev/null

count="$(find "$OUT" -type f | wc -l | tr -d ' ')"
bytes="$(find "$OUT" -type f -exec cat {} + | wc -c | tr -d ' ')"
printf 'files=%s\n' "$count"
printf 'bytes=%s\n' "$bytes"
