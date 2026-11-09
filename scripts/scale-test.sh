#!/usr/bin/env bash
# Scale test: ingest django/django (pinned tag) through `dossier dump` up to FACT_LIMIT facts,
# measure ingest/compile/publish, and publish a bundle. Only this script touches the network
# (one tarball fetch); the Dossier core makes no network calls. The source tree is extracted under
# $TMPDIR and never enters the repo.
#
#   TAG=6.1.3 FACT_LIMIT=50000 bash scripts/scale-test.sh [outdir]
#
# Needs: curl, tar, jq, awk, dotnet. Prints a key=value report; raw timings go to $WORK.
set -euo pipefail

TAG="${TAG:-6.1.3}"
FACT_LIMIT="${FACT_LIMIT:-50000}"
SEED="${SEED:-42}"
SAMPLE="${SAMPLE:-20}"
FACT_FILE_CAP="${FACT_FILE_CAP:-5000}"

ROOT="$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)"
DLL="$ROOT/src/Dossier/bin/Release/net10.0/Dossier.dll"
OUT="${1:-$ROOT/examples/django-bundle}"
WORK="${WORK:-$(mktemp -d "${TMPDIR:-/tmp}/dossier-scale.XXXXXX")}"
mkdir -p "$WORK"

now() { perl -MTime::HiRes=time -e 'printf "%.3f\n", time'; }
dos() { dotnet "$DLL" "$@"; }

echo "dotnet=$(dotnet --version)"
echo "repo_sha=$(git -C "$ROOT" rev-parse HEAD)"
echo "django_tag=$TAG"
echo "work=$WORK"

# 1. Fetch (the only network call) and extract under $WORK.
if [ ! -d "$WORK/src/django-$TAG" ]; then
  mkdir -p "$WORK/src"
  curl -fsSL "https://codeload.github.com/django/django/tar.gz/refs/tags/$TAG" -o "$WORK/django.tgz"
  tar -xzf "$WORK/django.tgz" -C "$WORK/src"
fi
SRC="$WORK/src/django-$TAG"

# 2. Build and init.
dotnet build -c Release "$ROOT/src/Dossier/Dossier.csproj" 2>&1 | tail -1
export DOSSIER_DB="$WORK/dossier.db"
rm -rf "$DOSSIER_DB" "$WORK/blobs"
dos init >/dev/null

# 3. Deterministic file list (C-locale sort): docs/**/*.txt, django/**/*.py, top-level *.md.
(
  cd "$SRC"
  { find docs -type f -name '*.txt'; find django -type f -name '*.py'; find . -maxdepth 1 -type f -name '*.md' | sed 's|^\./||'; } \
    | LC_ALL=C sort
) > "$WORK/files.txt"
echo "files_total=$(wc -l < "$WORK/files.txt" | tr -d ' ')"

# 4. Ingest. One dump per file; stop when the fact count reaches FACT_LIMIT.
: > "$WORK/times.tsv"   # seconds<TAB>facts<TAB>relpath
: > "$WORK/subjects.tsv" # subject<TAB>facts
total=0
files_used=0
t_start="$(now)"
while IFS= read -r rel; do
  [ "$total" -ge "$FACT_LIMIT" ] && break
  case "$rel" in
    *.py) kind=code ;;
    *)    kind=doc ;;
  esac
  subj="${rel%.*}"
  t0="$(now)"
  out="$(dos dump --source "$SRC/$rel" --subject "$subj" --split paragraph --kind "$kind")"
  t1="$(now)"
  n="$(printf '%s' "$out" | jq '.created | length')"
  total=$((total + n))
  files_used=$((files_used + 1))
  printf '%s\t%s\t%s\n' "$(awk -v a="$t0" -v b="$t1" 'BEGIN{printf "%.3f", b-a}')" "$n" "$rel" >> "$WORK/times.tsv"
  [ "$n" -gt 0 ] && printf '%s\t%s\n' "$subj" "$n" >> "$WORK/subjects.tsv"
done < "$WORK/files.txt"
t_end="$(now)"

ingest_s="$(awk -v a="$t_start" -v b="$t_end" 'BEGIN{printf "%.1f", b-a}')"
echo "facts_total=$total"
echo "subjects_with_facts=$(wc -l < "$WORK/subjects.tsv" | tr -d ' ')"
echo "files_consumed=$files_used"
echo "ingest_seconds=$ingest_s"
echo "mean_ms_per_file=$(awk -v s="$ingest_s" -v n="$files_used" 'BEGIN{printf "%.1f", s*1000/n}')"
echo "db_bytes=$(stat -f %z "$DOSSIER_DB" 2>/dev/null || stat -c %s "$DOSSIER_DB")"
if [ -d "$WORK/blobs" ]; then
  echo "blobs_bytes=$(find "$WORK/blobs" -type f -exec cat {} + | wc -c | tr -d ' ')"
  echo "blobs_files=$(find "$WORK/blobs" -type f | wc -l | tr -d ' ')"
fi
echo "slowest_files:"
sort -t$'\t' -k1,1nr "$WORK/times.tsv" | head -10 | sed 's/^/  /'

# 6. Compile latency on SAMPLE subjects chosen with a fixed seed.
awk -v seed="$SEED" 'BEGIN{srand(seed)} {print rand() "\t" $1}' "$WORK/subjects.tsv" \
  | LC_ALL=C sort -k1,1n | head -n "$SAMPLE" | cut -f2 > "$WORK/sample.txt"
: > "$WORK/compile_ms.txt"
while IFS= read -r s; do
  t0="$(now)"
  dos dossier compile --subject "$s" --depth full --budget 1200 --budget-mode strict --format json >/dev/null 2>&1
  t1="$(now)"
  awk -v a="$t0" -v b="$t1" 'BEGIN{printf "%.0f\n", (b-a)*1000}' >> "$WORK/compile_ms.txt"
done < "$WORK/sample.txt"
sort -n "$WORK/compile_ms.txt" | awk -v n="$SAMPLE" '{v[NR]=$1} END{
  p50=v[int((NR-1)*0.50+0.5)+1]; p95=v[int((NR-1)*0.95+0.5)+1];
  printf "compile_p50_ms=%s\ncompile_p95_ms=%s\ncompile_min_ms=%s\ncompile_max_ms=%s\n", p50, p95, v[1], v[NR]}'

# 7. Corpus totals: compile every subject and sum conflicts.
conflicts=0
while IFS=$'\t' read -r s _; do
  c="$(dos dossier compile --subject "$s" --depth full --budget 1200 --budget-mode strict --format json 2>/dev/null | tail -1 | jq '.conflicts | length')"
  conflicts=$((conflicts + c))
done < "$WORK/subjects.tsv"
echo "conflicts_total=$conflicts"
echo "largest_subject=$(sort -t$'\t' -k2,2nr -k1,1 "$WORK/subjects.tsv" | head -1 | tr '\t' ' ')"

# 8. Publish. Count the fact files a detail publish would write; use --facts none above the cap.
PROBE="$WORK/probe-bundle"
rm -rf "$PROBE"
dos publish --out "$PROBE" --depth full --budget 1200 --facts detail >/dev/null
would="$(find "$PROBE/subjects" -path '*/facts/*' -type f 2>/dev/null | wc -l | tr -d ' ')"
echo "fact_files_would_write=$would"
if [ "$would" -gt "$FACT_FILE_CAP" ]; then facts_mode=none; else facts_mode=detail; fi
echo "publish_facts_mode=$facts_mode"
rm -rf "$OUT"
cd "$ROOT"
dos publish --out "${OUT#"$ROOT"/}" --depth full --budget 1200 --facts "$facts_mode" >/dev/null

# 9. Bundle stats.
echo "bundle_files=$(find "$OUT" -type f | wc -l | tr -d ' ')"
echo "bundle_bytes=$(find "$OUT" -type f -exec cat {} + | wc -c | tr -d ' ')"
echo "bundle_index_bytes=$(wc -c < "$OUT/INDEX.md" | tr -d ' ')"
# Coverage: every subject page's "Facts shown" numerator, summed. Complete mode lists every fact,
# so this should equal facts_total; anything less means a page held facts back.
shown="$(grep -h '^- Facts shown: ' "$OUT"/subjects/*/index.md | sed -E 's/^- Facts shown: ([0-9,]+).*/\1/' | tr -d ',' | awk '{s += $1} END {print s + 0}')"
echo "facts_shown=$shown"
echo "facts_coverage=$shown of $total"
# Largest subject page (bytes and chars/4 token estimate) is the worst single read in the bundle.
largest="$(find "$OUT/subjects" -name index.md -type f -exec wc -c {} + | grep -v ' total$' | sort -n | tail -1)"
echo "largest_subject_page_bytes=$(echo "$largest" | awk '{print $1}')"
echo "largest_subject_page_tokens=$(echo "$largest" | awk '{printf "%d", ($1 + 3) / 4}')"
echo "largest_subject_page_path=$(echo "$largest" | awk '{print $2}')"
