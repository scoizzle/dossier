#!/usr/bin/env bash
# Evaluation harness: run the loop on a temp DB, then measure arm A (raw search)
# against arm B (compiled dossier) at budget 1200, depth full, markdown.
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

# Arm B: the compiled dossier at budget 1200, depth full, format markdown.
dotnet "$DLL" dossier compile --subject "$SUBJECT" --budget 1200 --depth full --format markdown > "$OUT/arm-b.md" 2>/dev/null

a_chars="$(wc -c < "$OUT/arm-a.json" | tr -d ' ')"
b_chars="$(wc -c < "$OUT/arm-b.md" | tr -d ' ')"
a_tokens=$(( (a_chars + 3) / 4 ))
b_tokens=$(( (b_chars + 3) / 4 ))
ratio="$(awk -v a="$a_tokens" -v b="$b_tokens" 'BEGIN { if (b == 0) { print "inf" } else { printf "%.2f", a / b } }')"

a_facts="$({ grep -o '"subject_id"' "$OUT/arm-a.json" || true; } | wc -l | tr -d ' ')"
b_facts="$(awk '/^## / { exit } /^- / { n++ } END { print n + 0 }' "$OUT/arm-b.md")"

q_total="$(grep -c '"id":' "$ROOT/scripts/eval/questions.json" || true)"
q_contradiction="$(grep -c '"requires_contradiction": true' "$ROOT/scripts/eval/questions.json" || true)"
q_unanswerable="$(grep -c '"supporting_fragments": \[\]' "$ROOT/scripts/eval/questions.json" || true)"

echo "== arm A (raw search): $OUT/arm-a.json"
echo "   chars: $a_chars"
echo "   tokens (chars/4): $a_tokens"
echo "   facts: $a_facts"
echo "== arm B (compiled dossier): $OUT/arm-b.md"
echo "   chars: $b_chars"
echo "   tokens (chars/4): $b_tokens"
echo "   facts: $b_facts"
echo "== ratio A/B (tokens): $ratio"
echo "== eval questions: $q_total (contradiction: $q_contradiction, unanswerable: $q_unanswerable)"
