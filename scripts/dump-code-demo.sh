#!/usr/bin/env bash
# Code-split demo: fetch django/db/models at a pinned tag, ingest every .py with
# `dossier dump --split code --entity-subjects` into a temp DB, and publish a bundle.
# Only this script touches the network (one tarball fetch); the Dossier core makes no network calls.
# Python only: split=code does not understand other languages.
#
#   TAG=6.1.3 bash scripts/dump-code-demo.sh [outdir]
#
# Needs: curl, tar, jq, dotnet. Prints a key=value report.
set -euo pipefail

TAG="${TAG:-6.1.3}"
ROOT="$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)"
DLL="$ROOT/src/Dossier/bin/Release/net10.0/Dossier.dll"
OUT="${1:-$ROOT/examples/django-models-bundle}"
WORK="${WORK:-$(mktemp -d "${TMPDIR:-/tmp}/dossier-code-demo.XXXXXX")}"
mkdir -p "$WORK"

if [ ! -f "$DLL" ]; then
  echo "missing $DLL; build it with: dotnet build -c Release src/Dossier/Dossier.csproj" >&2
  exit 1
fi
dos() { dotnet "$DLL" "$@"; }

echo "repo_sha=$(git -C "$ROOT" rev-parse HEAD)"
echo "django_tag=$TAG"
echo "work=$WORK"

if [ ! -d "$WORK/src/django-$TAG" ]; then
  mkdir -p "$WORK/src"
  curl -fsSL "https://codeload.github.com/django/django/tar.gz/refs/tags/$TAG" -o "$WORK/django.tgz"
  tar -xzf "$WORK/django.tgz" -C "$WORK/src" "django-$TAG/django/db/models"
fi
SRC="$WORK/src/django-$TAG"

export DOSSIER_DB="$WORK/dossier.db"
rm -rf "$DOSSIER_DB" "$WORK/blobs"
dos init >/dev/null

(cd "$SRC" && find django/db/models -type f -name '*.py' | LC_ALL=C sort) > "$WORK/files.txt"
echo "files=$(wc -l < "$WORK/files.txt" | tr -d ' ')"

# Dump from inside the source tree so the recorded file refs are repo-relative, not temp paths.
created=0; errors=0
cd "$SRC"
while IFS= read -r rel; do
  out="$(dos dump --source "$rel" --subject "${rel%.py}" --kind code --split code --entity-subjects)"
  n="$(printf '%s' "$out" | jq '.created | length')"
  e="$(printf '%s' "$out" | jq '.errors | length')"
  created=$((created + n)); errors=$((errors + e))
done < "$WORK/files.txt"

# Count straight from the store: facts, subjects, entity-kind breakdown.
sql() { sqlite3 "$DOSSIER_DB" "$1"; }
if command -v sqlite3 >/dev/null 2>&1; then
  echo "facts=$(sql "SELECT COUNT(*) FROM facts WHERE status='live'")"
  echo "subjects=$(sql "SELECT COUNT(*) FROM subjects")"
  echo "subject_kinds:"
  sql "SELECT kind, COUNT(*) FROM subjects GROUP BY kind ORDER BY COUNT(*) DESC, kind" | sed 's/|/ /; s/^/  /'
else
  echo "facts_created=$created"
fi
echo "facts_created=$created"
echo "dump_errors=$errors"

cd "$ROOT"
rm -rf "$OUT"
dos publish --out "${OUT#"$ROOT"/}" --depth full --budget 1200 --facts detail >/dev/null
echo "bundle_files=$(find "$OUT" -type f | wc -l | tr -d ' ')"
echo "bundle_bytes=$(find "$OUT" -type f -exec cat {} + | wc -c | tr -d ' ')"
