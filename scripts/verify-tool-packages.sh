#!/usr/bin/env bash
# Verify the .NET tool packages in a folder feed before they are installed or pushed.
#
# Usage: scripts/verify-tool-packages.sh <feed-dir> <version> <rid>
#
# <rid> is the platform package built on this runner (for example osx-arm64). The script
# checks the pointer package, that RID package and the framework-dependent any package:
# package types, versions, the MCP manifest, the command settings and the absence of
# debug symbols. Portable on Linux, macOS (bash 3.2) and Git Bash on Windows: needs unzip
# (or 7z) and node (or python3) to parse JSON.
set -euo pipefail

if [ "$#" -ne 3 ]; then
  echo "usage: $0 <feed-dir> <version> <rid>" >&2
  exit 2
fi

FEED="$(cd "$1" && pwd)"
VERSION="$2"
RID="$3"

TMP="$(mktemp -d "${TMPDIR:-/tmp}/dossier-verify.XXXXXX")"
trap 'rm -rf "$TMP"' EXIT

fail() {
  printf 'VERIFY FAILED: %s\n' "$1" >&2
  exit 1
}

extract() {
  local nupkg="$1" dest="$2"
  mkdir -p "$dest"
  if command -v unzip >/dev/null 2>&1; then
    unzip -oq "$nupkg" -d "$dest"
  elif command -v 7z >/dev/null 2>&1; then
    # 7z is a native Windows program under Git Bash; give it Windows paths.
    if command -v cygpath >/dev/null 2>&1; then
      7z x -y -o"$(cygpath -w "$dest")" "$(cygpath -w "$nupkg")" >/dev/null
    else
      7z x -y -o"$dest" "$nupkg" >/dev/null
    fi
  elif tar --version 2>/dev/null | grep -qi bsdtar; then
    tar -xf "$nupkg" -C "$dest"
  else
    echo "verify: need unzip, 7z or bsdtar to read a nupkg" >&2
    exit 2
  fi
}

package_type() {
  # Prints the package types of a extracted package, one per line, sorted.
  local dir="$1"
  local nuspec
  nuspec="$(find "$dir" -maxdepth 1 -name '*.nuspec' | head -n 1)"
  [ -n "$nuspec" ] || fail "no .nuspec in package"
  sed -n 's/.*<packageType name="\([^"]*\)".*/\1/p' "$nuspec" | LC_ALL=C sort
}

nuspec_version() {
  local dir="$1" nuspec
  nuspec="$(find "$dir" -maxdepth 1 -name '*.nuspec' | head -n 1)"
  sed -n 's#.*<version>\([^<]*\)</version>.*#\1#p' "$nuspec" | head -n 1
}

extract_and_check_versions() {
  local id="$1" dir="$TMP/$1"
  [ -f "$FEED/$id.$VERSION.nupkg" ] || fail "missing package $id.$VERSION.nupkg in $FEED"
  extract "$FEED/$id.$VERSION.nupkg" "$dir"
  local got
  got="$(nuspec_version "$dir")"
  if [ "$got" != "$VERSION" ]; then
    fail "$id nuspec version is '$got', expected '$VERSION'"
  fi
  # Native AOT leaves a .dSYM bundle on macOS and a .pdb on Windows; neither belongs in a tool package.
  if find "$dir" \( -name '*.pdb' -o -name '*.dSYM' \) -print | grep -q .; then
    fail "$id package contains debug symbols"
  fi
}

# 1. Every expected package exists and carries the release version, without debug symbols.
extract_and_check_versions "Dossier.Cli"
extract_and_check_versions "Dossier.Cli.$RID"
extract_and_check_versions "Dossier.Cli.any"

# 2. Package types: the pointer is DotnetTool + McpServer; the implementation packages are
#    DotnetToolRidPackage and must not be discoverable as tools or MCP servers themselves.
pointer="$TMP/Dossier.Cli"
rid_dir="$TMP/Dossier.Cli.$RID"
any_dir="$TMP/Dossier.Cli.any"

[ "$(package_type "$pointer")" = "$(printf 'DotnetTool\nMcpServer\n')" ] \
  || fail "pointer package types are '$(package_type "$pointer" | tr '\n' ' ')', expected DotnetTool and McpServer"
[ "$(package_type "$rid_dir")" = "DotnetToolRidPackage" ] \
  || fail "$RID package types are '$(package_type "$rid_dir" | tr '\n' ' ')', expected only DotnetToolRidPackage"
[ "$(package_type "$any_dir")" = "DotnetToolRidPackage" ] \
  || fail "any package types are '$(package_type "$any_dir" | tr '\n' ' ')', expected only DotnetToolRidPackage"

# 3. The pointer package carries the icon, the readme, the MCP manifest and the license.
for file in README.md icon.png LICENSE THIRD-PARTY-NOTICES.md .mcp/server.json tools/any/any/DotnetToolSettings.xml; do
  [ -f "$pointer/$file" ] || fail "pointer package is missing $file"
done

# The MIT license and third-party notices must travel with every binary, as in the archives, and
# a Native AOT package links the .NET runtime statically, so it ships that runtime's notices too.
for dir in "$pointer" "$rid_dir" "$any_dir"; do
  for file in LICENSE THIRD-PARTY-NOTICES.md; do
    [ -f "$dir/$file" ] || fail "$(basename "$dir") package is missing $file"
  done
done
[ -f "$rid_dir/dotnet-runtime-THIRD-PARTY-NOTICES.TXT" ] \
  || fail "$RID package is missing dotnet-runtime-THIRD-PARTY-NOTICES.TXT"

# 4. The command settings name the command and every RID package the pointer advertises.
settings="$pointer/tools/any/any/DotnetToolSettings.xml"
grep -q '<Command Name="dossier"' "$settings" || fail "tool command is not 'dossier'"
ids="$(sed -n 's/.*Id="\([^"]*\)".*/\1/p' "$settings" | LC_ALL=C sort | tr '\n' ' ')"
expected_ids="$(printf 'Dossier.Cli.any\nDossier.Cli.linux-arm64\nDossier.Cli.linux-x64\nDossier.Cli.osx-arm64\nDossier.Cli.win-x64\n' | LC_ALL=C sort | tr '\n' ' ')"
[ "$ids" = "$expected_ids" ] || fail "pointer settings list '$ids', expected '$expected_ids'"

# 5. The MCP manifest is valid JSON, names the package, and matches the package version.
manifest="$pointer/.mcp/server.json"
if command -v node >/dev/null 2>&1; then
  node -e '
    const fs = require("fs");
    const d = JSON.parse(fs.readFileSync(process.argv[1], "utf8"));
    const v = process.argv[2];
    const errors = [];
    if (d.version !== v) errors.push(`top-level version ${d.version} != ${v}`);
    const p = (d.packages || [])[0] || {};
    if (p.version !== v) errors.push(`package version ${p.version} != ${v}`);
    if (p.identifier !== "Dossier.Cli") errors.push(`identifier ${p.identifier} != Dossier.Cli`);
    if (!p.transport || p.transport.type !== "stdio") errors.push("transport is not stdio");
    if (errors.length) { console.error(errors.join("; ")); process.exit(1); }
  ' "$manifest" "$VERSION" || fail "MCP manifest is invalid or out of date"
elif command -v python3 >/dev/null 2>&1; then
  python3 - "$manifest" "$VERSION" <<'PY' || fail "MCP manifest is invalid or out of date"
import json, sys
doc = json.load(open(sys.argv[1]))
v = sys.argv[2]
package = (doc.get("packages") or [{}])[0]
problems = []
if doc.get("version") != v:
    problems.append(f"top-level version {doc.get('version')} != {v}")
if package.get("version") != v:
    problems.append(f"package version {package.get('version')} != {v}")
if package.get("identifier") != "Dossier.Cli":
    problems.append(f"identifier {package.get('identifier')} != Dossier.Cli")
if (package.get("transport") or {}).get("type") != "stdio":
    problems.append("transport is not stdio")
if problems:
    print("; ".join(problems), file=sys.stderr)
    sys.exit(1)
PY
else
  fail "need node or python3 to validate the MCP manifest"
fi

printf 'VERIFY OK: Dossier.Cli %s with %s and any packages in %s\n' "$VERSION" "$RID" "$FEED"
