#!/usr/bin/env bash
# Smoke-test a published (Native AOT) Dossier binary.
#
# Usage: scripts/smoke-aot.sh <binary> <expected-version>
#
# Runs the main verbs against a throwaway database and fails loudly on the
# first problem. Portable on Linux, macOS (bash 3.2) and Git Bash on Windows:
# no jq, no timeout, no sha256sum.
set -euo pipefail

if [ "$#" -ne 2 ]; then
  echo "usage: $0 <binary> <expected-version>" >&2
  exit 2
fi

bin_in="$1"
expected="$2"

if [ ! -f "$bin_in" ]; then
  echo "smoke: binary not found: $bin_in" >&2
  exit 2
fi
BIN="$(cd "$(dirname "$bin_in")" && pwd)/$(basename "$bin_in")"

TMP="$(mktemp -d "${TMPDIR:-/tmp}/dossier-smoke.XXXXXX")"
trap 'rm -rf "$TMP"' EXIT
# Native Windows executables need a Windows-style path; Git Bash has cygpath.
if command -v cygpath >/dev/null 2>&1; then
  TMP_NATIVE="$(cygpath -m "$TMP")"
else
  TMP_NATIVE="$TMP"
fi
export DOSSIER_DB="$TMP_NATIVE/smoke.db"

TOKEN="zyxwvquartz"
SUBJECT="Smoke/Aot"

step() {
  printf '\n== %s\n' "$1"
}

fail() {
  printf 'SMOKE FAILED: %s\n' "$1" >&2
  exit 1
}

# Run the binary, capture stdout in $OUT (CRs stripped) and fail on non-zero.
run() {
  local rc=0
  OUT="$("$BIN" "$@" 2>"$TMP/stderr")" || rc=$?
  OUT="$(printf '%s' "$OUT" | tr -d '\r')"
  if [ "$rc" -ne 0 ]; then
    printf '%s\n' "$OUT"
    cat "$TMP/stderr" >&2
    fail "'$*' exited $rc"
  fi
  printf '%s\n' "$OUT"
}

expect_contains() {
  case "$OUT" in
    *"$1"*) ;;
    *) fail "$2: output does not contain '$1'" ;;
  esac
}

# Like expect_contains, but $1 is an extended regular expression.
expect_match() {
  if ! printf '%s' "$OUT" | grep -Eq "$1"; then
    fail "$2: output does not match /$1/"
  fi
}

step "version"
run version
if [ "$OUT" != "$expected" ]; then
  fail "version is '$OUT', expected '$expected'"
fi

step "init"
run init

step "dump"
printf '# Smoke note\n\nThe %s marker proves dump and search work.\n' "$TOKEN" >"$TMP/note.md"
run dump --source "$TMP_NATIVE/note.md" --subject "$SUBJECT"
expect_match '"created":\["[^"]+"' "dump (created list is empty)"

step "search"
run search --q "$TOKEN" --subject "$SUBJECT"
expect_contains "$TOKEN" "search"

step "check"
run check --subject "$SUBJECT"
expect_contains '"match":"exact_name"' "check"
expect_match '"facts":[1-9]' "check (no facts summarised)"
expect_contains "$TOKEN" "check"

step "post"
printf '{"subject":{"name":"%s"},"facts":[{"kind":"note","key":"smoke-post","text":"The %s posted fact."}]}\n' "$SUBJECT" "$TOKEN" >"$TMP/post.json"
run post --file "$TMP_NATIVE/post.json"
expect_contains '"status":"new"' "post"
FACT_ID="$(printf '%s' "$OUT" | sed -n 's/.*"facts":\[{"id":"\([^"]*\)".*/\1/p')"
if [ -z "$FACT_ID" ]; then
  fail "post: could not read the new fact id"
fi

step "show"
run show "$FACT_ID"
expect_contains "$FACT_ID" "show"
expect_contains "posted fact" "show"

step "compile (json)"
run dossier compile --subject "$SUBJECT" --depth full
expect_contains "$TOKEN" "compile json"

step "compile (markdown)"
run dossier compile --subject "$SUBJECT" --depth full --format markdown
expect_contains "$TOKEN" "compile markdown"

step "mcp session"
{
  printf '%s\n' '{"jsonrpc":"2.0","id":1,"method":"initialize","params":{"protocolVersion":"2025-06-18","capabilities":{},"clientInfo":{"name":"smoke","version":"0"}}}'
  printf '%s\n' '{"jsonrpc":"2.0","method":"notifications/initialized"}'
  printf '%s\n' '{"jsonrpc":"2.0","id":2,"method":"tools/list"}'
  printf '%s\n' "{\"jsonrpc\":\"2.0\",\"id\":3,\"method\":\"tools/call\",\"params\":{\"name\":\"search\",\"arguments\":{\"q\":\"$TOKEN\"}}}"
} >"$TMP/mcp-in.jsonl"
rc=0
"$BIN" mcp <"$TMP/mcp-in.jsonl" >"$TMP/mcp-out.jsonl" 2>"$TMP/stderr" || rc=$?
tr -d '\r' <"$TMP/mcp-out.jsonl" >"$TMP/mcp-out.txt"
cat "$TMP/mcp-out.txt"
if [ "$rc" -ne 0 ]; then
  cat "$TMP/stderr" >&2
  fail "'mcp' exited $rc"
fi
if grep -q '"error"' "$TMP/mcp-out.txt"; then
  fail "mcp session returned an error"
fi
if ! grep -q '"result"' "$TMP/mcp-out.txt"; then
  fail "mcp session returned no result"
fi
if ! grep -q "$TOKEN" "$TMP/mcp-out.txt"; then
  fail "mcp tools/call search did not return the dumped fact"
fi

step "publish"
run publish --out "$TMP_NATIVE/bundle"
expect_match '"facts":[1-9]' "publish (no facts written)"
if [ ! -f "$TMP/bundle/manifest.json" ]; then
  fail "publish: manifest.json missing from the bundle"
fi
fact_files=0
for f in "$TMP"/bundle/subjects/*/facts/*.md; do
  if [ -f "$f" ]; then
    fact_files=$((fact_files + 1))
  fi
done
if [ "$fact_files" -eq 0 ]; then
  fail "publish: no fact files in the bundle"
fi

step "import (into a second, fresh database)"
DOSSIER_DB="$TMP_NATIVE/second.db" run import --from "$TMP_NATIVE/bundle"
expect_match '"facts":[1-9]' "import (no facts imported)"

printf '\nSMOKE OK: %s (%s)\n' "$BIN" "$expected"
