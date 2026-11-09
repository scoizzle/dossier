#!/usr/bin/env bash
# Verify that every git ref in scripts/seed/*.json resolves to a real file at a
# real commit. Each distinct (target, rev) is fetched from raw.githubusercontent.com
# and must answer HTTP 200; anything else fails the script.
#
# Usage: bash scripts/verify-refs.sh
set -euo pipefail

ROOT="$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)"
TMP="$(mktemp -d "${TMPDIR:-/tmp}/dossier-refs.XXXXXX")"
trap 'rm -rf "$TMP"' EXIT

# One tab-separated (target, rev) pair per distinct git ref across all seed files.
refs="$(jq -r '.facts[]?.refs[]? | select(.kind == "git") | [.target, .rev] | @tsv' "$ROOT"/scripts/seed/*.json | sort -u)"

total=0
ok=0
fail=0
: > "$TMP/resolved"

while IFS=$'\t' read -r full rev; do
  [ -z "${full:-}" ] && continue
  [ -z "${rev:-}" ] && continue

  repo="$(printf '%s' "$full" | cut -d/ -f1-2)"
  rel="${full#"$repo"/}"
  url="https://raw.githubusercontent.com/$repo/$rev/$rel"

  total=$((total + 1))
  body="$TMP/ref.$total"
  # %{http_code} and %{size_download} come from curl; a transport error yields 000.
  curl_out="$(curl -sS -m 30 -o "$body" -w '%{http_code} %{size_download}' "$url" 2>/dev/null)" || curl_out="000 0"
  status="${curl_out%% *}"
  bytes="${curl_out##* }"
  if [ "$status" != "200" ]; then
    bytes=0
    fail=$((fail + 1))
  else
    ok=$((ok + 1))
    printf '%s\n' "$full" >> "$TMP/resolved"
  fi

  printf 'status=%s rev=%s bytes=%s path=%s\n' "$status" "${rev:0:10}" "$bytes" "$full"
done <<< "$refs"

distinct_files="$(sort -u "$TMP/resolved" | wc -l | tr -d ' ')"
printf 'refs: %d distinct, %d ok, %d failed; distinct files: %s\n' \
  "$total" "$ok" "$fail" "$distinct_files"

if [ "$total" -eq 0 ]; then
  echo "FAIL: no git refs found in scripts/seed/*.json" >&2
  exit 1
fi

if [ "$fail" -ne 0 ]; then
  echo "FAIL: $fail git ref(s) did not resolve" >&2
  exit 1
fi
