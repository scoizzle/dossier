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

# seed.sh is quiet on success, but its failure output is the only clue when the seed attachment
# drifts or a tool is missing, so keep it aside and replay it on stderr when the seed fails.
seed_log="$TMP/seed.log"
seed_status=0
bash "$ROOT/scripts/seed.sh" >"$seed_log" 2>&1 || seed_status=$?
if [ "$seed_status" -ne 0 ]; then
  echo "scripts/seed.sh failed (exit $seed_status); its output follows:" >&2
  cat "$seed_log" >&2
  exit "$seed_status"
fi

# Run from the repo root with a relative --out so the README's recorded command is portable.
cd "$ROOT"
REL_OUT="${OUT#"$ROOT"/}"
dotnet "$DLL" publish --out "$REL_OUT" >/dev/null

count="$(find "$OUT" -type f | wc -l | tr -d ' ')"
bytes="$(find "$OUT" -type f -exec cat {} + | wc -c | tr -d ' ')"
printf 'files=%s\n' "$count"
printf 'bytes=%s\n' "$bytes"
