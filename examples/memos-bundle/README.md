# Dossier bundle

This is a Dossier bundle: an export of a fact store as plain markdown files, so a reader with no tools (an agent in a repository, or a person) can navigate it by following links. Agents should start with [AGENTS.md](AGENTS.md).

## How it was generated

- Command: `dossier publish --out examples/memos-bundle`
- Generated at: `2026-11-09T22:05:39Z`
- Scope: every subject
- Budget per subject: 1200 tokens, depth full
- Fact files: one per fact under `subjects/<slug>/facts/`
- Assets: attachment bytes copied under `subjects/<slug>/assets/`
- The timestamp is kept as-is while the bundle's content is unchanged, so republishing identical inputs rewrites nothing.

## Totals

- Subjects: 5
- Facts: 32
- Conflicts: 3
- Gaps: 0
- Subject file tokens, all subjects: 1543

## How to read it

Drill-down path: AGENTS.md -> INDEX.md -> index/<group>.md (repeat while the row is a group) -> subjects/<slug>/index.md -> subjects/<slug>/facts/<key>.md

1. [INDEX.md](INDEX.md) lists every subject, or, in a large bundle, the top-level groups, with fact, conflict and gap counts and the token cost of each row's file. A `group` row links to a deeper `index/<group>.md`; each index file is capped at 6000 tokens.
2. `subjects/<slug>/index.md` is the compiled dossier for one subject; each claim ends in its bracketed fact key.
3. `subjects/<slug>/facts/<words>-<key>.md` holds one fact in full: text, provenance, data, refs and the facts that reference it. A fact file links onward to the facts and subjects it depends on, so the bundle is a graph to walk.
4. [conflicts.md](conflicts.md) and [gaps.md](gaps.md) collect the disagreements and the unmet needs across subjects.
5. [manifest.json](manifest.json) maps fact keys to store ids and paths, subject ids to paths, and lists every generated file and every asset.

## Assets

Attachment bytes are copied to `subjects/<slug>/assets/<sha8>-<file-stem>.<ext>`: `sha8` is the first 8 hex characters of the blob's sha256, the stem is the attachment's file name without extension (slugified, at most 40 characters, `asset` if empty) and the extension is the file's own, else one derived from the mime type, else `bin`. Subject files list their attachments under an `Assets` heading and fact files under `Attachments`; every link is relative to the file it is in: `assets/<file>` from the subject's index.md and `../assets/<file>` from one of its fact files. A blob shared by two subjects is copied once per subject on purpose, so each subject's directory is self-contained. If a blob was missing from the store when the bundle was published, the entry reads `MISSING <sha256>`, no file exists for it and the manifest records `missing: true`.

## Links

Every link in the bundle is relative to the file it is written in and points at a file that exists. Within a subject a fact file links to a sibling as `<file>`; to a fact in another subject as `../../<other-slug>/facts/<file>`; to a subject's index as `../../<other-slug>/index.md` (`../<other-slug>/index.md` from an index.md). A ref whose target is not in the bundle (outside a `--subject` scope, or no longer live) is shown as text, never as a link.

## Slugs

A subject's directory name is its name lowercased, with every run of characters other than `a-z` and `0-9` turned into a single hyphen and leading and trailing hyphens trimmed (at most 80 characters; `subject` if nothing is left). When two subjects produce the same slug, the first in tree order (name, kind, aliases, then id as a last resort) keeps it and the others get `-2`, `-3`, and so on.
