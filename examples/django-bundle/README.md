# Dossier bundle

This is a Dossier bundle: an export of a fact store as plain markdown files, so a reader with no tools (an agent in a repository, or a person) can navigate it by following links. Agents should start with [AGENTS.md](AGENTS.md).

## How it was generated

- Command: `dossier publish --out examples/django-bundle --depth full --budget 1200 --facts none`
- Generated at: `2026-11-09T21:52:29Z`
- Scope: every subject
- Budget per subject: 1200 tokens, depth full
- Fact files: omitted (`--facts none`)
- Assets: attachment bytes copied under `assets/<subject-slug>/`
- The timestamp is kept as-is while the bundle's content is unchanged, so republishing identical inputs rewrites nothing.

## Totals

- Subjects: 1080
- Facts: 50013
- Conflicts: 0
- Gaps: 0
- Subject file tokens, all subjects: 762056

## How to read it

Drill-down path: README.md -> INDEX.md -> index/<group>.md (repeat while the row is a group) -> subjects/<slug>.md -> facts/<slug>-<key>.md

1. [INDEX.md](INDEX.md) lists every subject, or, in a large bundle, the top-level groups, with fact, conflict and gap counts and the token cost of each row's file. A `group` row links to a deeper `index/<group>.md`; each index file is capped at 6000 tokens.
2. `subjects/<slug>.md` is the compiled dossier for one subject; each claim ends in its bracketed fact key.
3. `facts/<slug>-<key>.md` holds one fact in full: text, provenance, data, refs and the facts that reference it.
4. [conflicts.md](conflicts.md) and [gaps.md](gaps.md) collect the disagreements and the unmet needs across subjects.
5. [manifest.json](manifest.json) maps fact keys to store ids and paths, subject ids to paths, and lists every generated file and every asset.

## Assets

Attachment bytes are copied to `assets/<subject-slug>/<sha8>-<file-stem>.<ext>`: `sha8` is the first 8 hex characters of the blob's sha256, the stem is the attachment's file name without extension (slugified, at most 40 characters, `asset` if empty) and the extension is the file's own, else one derived from the mime type, else `bin`. Subject files list their attachments under an `Assets` heading and fact files under `Attachments`; every link is relative to the file it is in, so from `subjects/` and from `facts/` alike it is `../assets/<subject-slug>/<file>`. A blob shared by two subjects is copied once per subject on purpose, so each subject's directory is self-contained. If a blob was missing from the store when the bundle was published, the entry reads `MISSING <sha256>`, no file exists for it and the manifest records `missing: true`.

## Slugs

A subject's file name is its name lowercased, with every run of characters other than `a-z` and `0-9` turned into a single hyphen and leading and trailing hyphens trimmed (at most 80 characters; `subject` if nothing is left). When two subjects produce the same slug, the first in tree order (name, kind, aliases, then id as a last resort) keeps it and the others get `-2`, `-3`, and so on.
