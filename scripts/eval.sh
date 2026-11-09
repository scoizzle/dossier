#!/usr/bin/env bash
# Evaluation harness: run the loop on a temp DB, then measure arm C (primary
# sources: what an agent reads with no Dossier) against arm A (raw search JSON),
# arm A2 (plain fact lines) and arm B (compiled dossier, budget 1200, full, markdown).
# Only arm C touches the network, and it is fail-soft.
set -euo pipefail
set -x

ROOT="$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)"
DLL="$ROOT/src/Dossier/bin/Release/net10.0/Dossier.dll"
OUT="${EVAL_OUT:-$ROOT/scripts/eval/artifacts}"
SUBJECT="Memos/Home"

TMP="$(mktemp -d "${TMPDIR:-/tmp}/dossier-eval.XXXXXX")"
export DOSSIER_DB="$TMP/dossier.db"
trap 'rm -rf "$TMP"' EXIT

if [ ! -f "$DLL" ]; then
  echo "missing $DLL; build it with: dotnet build -c Release src/Dossier/Dossier.csproj" >&2
  exit 1
fi

mkdir -p "$OUT"

# Run the whole loop on a clean DB.
bash "$ROOT/scripts/seed.sh" >/dev/null

# Arm A: every live fact for the subject as returned by search with limit 100.
dotnet "$DLL" search --subject "$SUBJECT" --limit 100 > "$OUT/arm-a.json"

# Arm A2: the same live facts as arm A, one bare line of text each: no ids,
# no JSON envelope, no tags. This is the fair raw baseline.
jq -r '.hits[].text' "$OUT/arm-a.json" > "$OUT/arm-a2.txt"

# Arm C: primary sources. Distinct git paths come from the seed refs, never typed.
PRIMARY="$OUT/primary"
mkdir -p "$PRIMARY"
SRC_JSON="$ROOT/scripts/eval/sources.json"
C_REPO="$(jq -r '.repo' "$SRC_JSON")"
C_REV="${EVAL_PRIMARY_REV:-$(jq -r '.rev' "$SRC_JSON")}"
paths="$(jq -r '.facts[]?.refs[]? | select(.kind == "git") | .target' "$ROOT"/scripts/seed/*.json | sort -u)"
c_files=0; c_fetched=0; c_chars=0; c_tokens_files=0
c_rows=""
set +x
while IFS= read -r full; do
  [ -z "$full" ] && continue
  rel="${full#"$C_REPO"/}"
  cache="$PRIMARY/$(printf '%s' "$rel" | tr '/' '_')@$C_REV"
  c_files=$((c_files + 1))
  if curl -fsSL -m 20 -o "$cache.tmp" "https://raw.githubusercontent.com/$C_REPO/$C_REV/$rel" 2>/dev/null; then
    mv "$cache.tmp" "$cache"
  else
    rm -f "$cache.tmp"
    echo "SKIPPED $rel (fetch failed at rev $C_REV)" >&2
  fi
  if [ -f "$cache" ]; then
    fc="$(wc -c < "$cache" | tr -d ' ')"; ft=$(( (fc + 3) / 4 ))
    c_fetched=$((c_fetched + 1)); c_chars=$((c_chars + fc)); c_tokens_files=$((c_tokens_files + ft))
    c_rows="$c_rows$(printf '   %-52s %8s chars %7s tokens' "$rel" "$fc" "$ft")"$'\n'
  else
    c_rows="$c_rows$(printf '   %-52s %8s' "$rel" "SKIPPED")"$'\n'
  fi
done <<< "$paths"
shots="$(jq -r '.screenshots.count' "$SRC_JSON")"
sw="$(jq -r '.screenshots.width' "$SRC_JSON")"
sh_="$(jq -r '.screenshots.height' "$SRC_JSON")"
shot_tokens=$(( shots * sw * sh_ / 750 ))
c_tokens=$(( c_tokens_files + shot_tokens ))
c_artifacts=$(( c_files + shots ))
set -x

# Arm B: the compiled dossier at budget 1200, depth full, format markdown.
dotnet "$DLL" dossier compile --subject "$SUBJECT" --budget 1200 --depth full --format markdown > "$OUT/arm-b.md" 2>/dev/null

a_chars="$(wc -c < "$OUT/arm-a.json" | tr -d ' ')"
a2_chars="$(wc -c < "$OUT/arm-a2.txt" | tr -d ' ')"
b_chars="$(wc -c < "$OUT/arm-b.md" | tr -d ' ')"
a_tokens=$(( (a_chars + 3) / 4 ))
a2_tokens=$(( (a2_chars + 3) / 4 ))
b_tokens=$(( (b_chars + 3) / 4 ))
ratio_ab="$(awk -v a="$a_tokens" -v b="$b_tokens" 'BEGIN { if (b == 0) { print "inf" } else { printf "%.2f", a / b } }')"
ratio_a2b="$(awk -v a="$a2_tokens" -v b="$b_tokens" 'BEGIN { if (b == 0) { print "inf" } else { printf "%.2f", a / b } }')"
b_pct_a2="$(awk -v a2="$a2_tokens" -v b="$b_tokens" 'BEGIN { if (a2 == 0) { print "inf" } else { printf "%.1f", (b / a2) * 100 } }')"

a_facts="$({ grep -o '"subject_id"' "$OUT/arm-a.json" || true; } | wc -l | tr -d ' ')"
a2_facts="$(wc -l < "$OUT/arm-a2.txt" | tr -d ' ')"
b_facts="$(awk '/^## / { exit } /^- / { n++ } END { print n + 0 }' "$OUT/arm-b.md")"

q_total="$(grep -c '"id":' "$ROOT/scripts/eval/questions.json" || true)"
q_contradiction="$(grep -c '"requires_contradiction": true' "$ROOT/scripts/eval/questions.json" || true)"
q_unanswerable="$(grep -c '"supporting_fragments": \[\]' "$ROOT/scripts/eval/questions.json" || true)"

ratio() { awk -v n="$1" -v d="$2" 'BEGIN { if (d == 0) { print "n/a" } else { printf "%.2f", n / d } }'; }
echo "== arm C (primary sources): repo $C_REPO rev $C_REV, cache $PRIMARY"
printf '%s' "$c_rows"
echo "   fetched files: $c_fetched of $c_files (missing files count as 0 tokens)"
echo "   file chars: $c_chars  file tokens: $c_tokens_files"
echo "   screenshots: $shots at ${sw}x${sh_} = $shot_tokens tokens (pixels/750, declared)"
echo "   arm C total tokens: $c_tokens"
echo "== arm A (raw search JSON): $OUT/arm-a.json"
echo "   chars: $a_chars"
echo "   tokens (chars/4): $a_tokens"
echo "   facts: $a_facts"
echo "== arm A2 (raw plain text): $OUT/arm-a2.txt"
echo "   chars: $a2_chars"
echo "   tokens (chars/4): $a2_tokens"
echo "   facts: $a2_facts"
echo "== arm B (compiled dossier): $OUT/arm-b.md"
echo "   chars: $b_chars"
echo "   tokens (chars/4): $b_tokens"
echo "   facts: $b_facts"
echo "== ratio A/B (tokens): $ratio_ab"
echo "== ratio A2/B (tokens): $ratio_a2b"
echo "== B as a percentage of A2 (tokens): $b_pct_a2%"
echo
echo "| Arm | Context | Tokens |"
echo "| --- | --- | --- |"
echo "| C | primary sources ($c_fetched of $c_files files + $shots screenshots) | $c_tokens |"
echo "| A | search JSON | $a_tokens |"
echo "| A2 | plain fact lines | $a2_tokens |"
echo "| B | compiled dossier | $b_tokens |"
echo "ratio B/C: $(ratio "$b_tokens" "$c_tokens")   ratio B/A: $(ratio "$b_tokens" "$a_tokens")   ratio B/A2: $(ratio "$b_tokens" "$a2_tokens")"
echo "arm C distinct primary artifacts (read operations before answering): $c_artifacts ($c_files files + $shots screenshots)"
if [ "$c_fetched" -lt "$c_files" ]; then echo "WARNING: arm C incomplete ($((c_files - c_fetched)) file(s) SKIPPED); B/C is not valid"; fi
echo "== eval questions: $q_total (contradiction: $q_contradiction, unanswerable: $q_unanswerable)"
