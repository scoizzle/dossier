# Story 5 — resolvable citations in published bundles

Issue: [#20](https://github.com/scoizzle/dossier/issues/20). Tier: T2 (publish output
contract). Depends on: 1 (`#16`), and practically on 3/4 for facts that carry source paths
and a revision. Blocks: none.

## Premise check (`ee9469e1`)

- Publish links only files it generated. `RelativeLink` is computed from two bundle paths
  (`src/Dossier/Publish.cs:971-987`), and every call site passes a generated target.
  Fact text is *not* inspected: on a subject page it is rendered with `Inline(fact.Text)`
  (`Publish.cs:1181`, `:1195`, `:1204`, shards `:1585`, `:1619`); in a fact file it is
  fenced verbatim (`Publish.cs:1279`). So a relative markdown link copied from a source
  file survives into the bundle and points nowhere.
- The bundle README already claims the opposite: "Every link in the bundle is relative to
  the file it is written in and points at a file that exists" (`Publish.cs:2369`, rendered
  into `README.md`). This story makes that sentence true.
- `PublishOptions` has no source-URL or revision field (`Publish.cs:11-107`); the CLI has
  no such flag (`src/Dossier/Program.cs:239-295`).
- Refs already have `rev` (`contract/ref.schema.json:34`), which is where D7's revision
  lands. No new field is needed to know the revision of a fact's source.

## Decisions

### D10 — template tokens

Support `{rev}` and `{path}`. **Preserve the link's own `#Lstart-Lend` fragment** rather
than filling `{start}`/`{end}` from anything else.

Why the deviation from the issue's example: a link's anchor describes *that link's*
target lines (`../src/A.cs#L12-L20`). The fact's own span describes the fact's source
lines, which are wrong for a link to another file, and a link without an anchor has no
range at all — filling `{start}` with 1 or the fact span manufactures a citation that was
never made. Preserving the fragment is mechanical, idempotent, and needs no guessing.

If the owner wants the literal `#L{start}-L{end}` template, add it as a second accepted
form with `{start}`/`{end}` read from the link fragment; a link with no fragment then
degrades with a warning instead of inventing a line. Record either choice in the PR.

Validation: the template must start with `http://` or `https://` and contain `{path}`.
Otherwise publish exits 1 with `invalid_source_url` before writing anything.

### What is rewritten, and what "outside the bundle" means

- Input: `PubFact.Text` and the text of `items` (story 3 writes summaries there). Not
  `data`, tags, names, or the machine record: `docs/publish.md:52` declares the record
  authoritative and the prose a view, so the record keeps the original text.
- Syntax: inline links and images, `[label](target)` / `![alt](target)`. Reference-style
  definitions (`[x]: ../a.cs`) are not rewritten; document that the guarantee covers
  inline links and images only, and add that sentence to `docs/publish.md`.
- A target is *relative* when it has no scheme and does not start with `#`. `http(s)` and
  `mailto:` targets are left alone.
- Resolve a relative target against the **source file's directory**, taken from the fact's
  first `derived_from`/`file` ref (`ref.Target` is the source path as dumped: absolute
  today, `--source-root`-relative after story 4). Normalize `.`/`..` purely lexically
  (never `Path.GetFullPath`, never the disk), split the fragment first. A target that
  climbs above the source root (`../` past the root), or a fact with no file ref, is
  "outside".
- Inside the bundle is not a meaningful case for fact text: the bundle contains generated
  pages and attachments, not the source tree, so any surviving relative target is outside.
  Keep one exception: a `#fragment`-only target stays (it is not outside).
- Output:
  - Template configured **and** a revision is available (or the template has no `{rev}`):
    `https://host/repo/blob/<rev>/<path><fragment>`, with each path segment percent-encoded
    for spaces, `(`, `)`, `#`, `?`, and the fragment passed through after validation.
  - Otherwise: degrade to plain text — the label followed by the target in a code span,
    `[label](../a.cs)` → `` label `../a.cs` `` — and add a warning
    `citation_unresolvable: <path>: <target>`. Degrading is what guarantees "zero relative
    links", and it is visible in `PublishResult.Warnings`.
- Already-absolute links are untouched, so a second publish over the same store is
  byte-identical.

### Where the rewrite runs

One function, applied before rendering, at each site that renders fact-derived text into
markdown: subject page fact lines (`:1181`, `:1195`, `:1204`), shard pages (`:1585`,
`:1619`), gaps (`:1223`), conflicts (`:1263`), and the fenced text block in fact files
(`:1279`). Fact files are fenced, so a target there is not clickable, but rewriting it
keeps any text scan clean and keeps the prose consistent; the machine record keeps the
original. Add a comment at each site: "rewritten for bundle citations; the machine record
keeps the original".

Do not apply the rewrite to `Inline(subject.Name)`, kinds, tags or keys.

## Edits

| File | Change |
| --- | --- |
| `src/Dossier/Links.cs` | New: `LinkContext`, `RewriteCitations(text, context, warnings)`, `TryResolveRelativeTarget`, `AppendFragment`, `PercentEncodePath` |
| `src/Dossier/Publish.cs` | `PublishOptions.SourceUrl`; a per-fact `LinkContext` (source path + rev); apply at the sites above; add warnings to `PublishResult.Warnings` |
| `src/Dossier/Program.cs` | `publish --source-url <template>`; usage (`:239`); `VerbSpec` publish list (`:456-459`) |
| `docs/cli.md` | `publish` paragraph: the flag, tokens, degrade rule |
| `docs/publish.md` | New "Citations" subsection: template, fragment preservation, the inline-only guarantee, degrade-and-warn, machine record keeps the original |
| `tests/Dossier.Tests/PublishCitationTests.cs` | New: rewrite, degrade, validation, bundle scan |
| `tests/Dossier.Tests/BundleLinks.cs` | New test helper: scan a published bundle and report any relative inline link whose target file is outside the root |

Keep `src/Dossier/Publish.cs`'s existing invariant comment (`:2369`) accurate; do not
delete the sentence.

## Tests

Red first. Write a fact whose text contains `[the splitter](../src/Dossier/Dump.cs#L234)`,
seed it with a `derived_from` file ref, publish without `--source-url`, and run the bundle
scan. Today the scan finds a relative link resolving outside the bundle root, so

```sh
dotnet test --solution Dossier.sln -c Release --filter-query "/Publish_BundleHasNoLinksLeavingTheRoot"
```

is red for the right reason. Capture that output.

```csharp
[Test] Publish_SourceUrlRewritesRelativeFactLinks()
[Test] Publish_SourceUrlPreservesTheLinkFragment()
[Test] Publish_SourceUrlPercentEncodesPathSegments()
[Test] Publish_SourceUrlLeavesHttpAndFragmentOnlyTargetsAlone()
[Test] Publish_WithoutSourceUrlDegradesToTextAndWarns()      // no "](target)" left
[Test] Publish_SourceUrlNeedsARevisionOrDegrades()           // {rev} with no ref rev
[Test] Publish_SourceUrlRejectsTemplatesWithoutPathOrScheme() // invalid_source_url, nothing written
[Test] Publish_SourceUrlIsIdempotent()                       // publish twice, same bytes
[Test] Publish_BundleHasNoLinksLeavingTheRoot()              // the issue's pin, markdown + shards + facts
[Test] Publish_MachineRecordKeepsTheOriginalLink()
[Test] Publish_InternalBundleLinksStillResolve()             // the existing invariant, unchanged
```

The scan helper: walk `<out>/**/*.md`, regex inline `!?\[[^\]]*\]\(([^)]+)\)`, skip
`http(s)://`, `mailto:` and `#…`, resolve the rest against the markdown file's directory,
and fail when the path escapes the bundle root or names no file (fragment ignored). Use it
in the last two tests and in the done-when evidence.

Green:

```sh
dotnet test --solution Dossier.sln -c Release --no-build
```

## Done-when evidence

| Claim | Evidence |
| --- | --- |
| Publishing this repository leaves zero relative links outside the bundle | run `dossier dump --source-root . --subject dossier-repo --rev <sha>`, `dossier publish --out /tmp/bundle --source-url https://github.com/scoizzle/dossier/blob/{rev}/{path}`, then the scan helper over `/tmp/bundle`; paste `0 outside` |
| A test pins the rewrite | `Publish_BundleHasNoLinksLeavingTheRoot`, `Publish_SourceUrlRewritesRelativeFactLinks` |
| Nothing else regressed | `PublishTests` (1,735 lines) green; internal-link test green |
| `dotnet test` green | CI command |

## Risks

- **Mutating quoted text.** The prose is a view and the machine record is authoritative
  (`docs/publish.md:52`), but a reader may compare them. Document it once, and keep the
  rewrite mechanical: no label changes, no anchor invention.
- **Two sources of source path.** Until story 4 lands, `derived_from` targets are absolute;
  after, they are root-relative. The resolver must accept both: an absolute path inside
  the repository root becomes root-relative; a path with no root to compare against is
  treated as outside (degrade) rather than guessed. Test both.
- **Percent-encoding.** Encode only the path, never the `https://host` prefix or the
  fragment's `L12-L20`. A test with a space and a `#` in a directory name pins it.
- **Shard mode** renders the same text in different files; the scan must cover
  `shards/*.md` (`Publish_BundleHasNoLinksLeavingTheRoot` runs publish with `--respect-limits` too).
- **`PublishResult.Warnings`** already prints one line per warning to stderr
  (`src/Dossier/Program.cs:301-304`), so the degrade path is visible without new plumbing.

## Size

~220 production lines, ~230 test lines, ~50 doc lines. One PR after story 1.
