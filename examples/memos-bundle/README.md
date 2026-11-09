# Dossier bundle

This is a Dossier bundle: an export of a fact store as plain markdown files, so a reader with no tools (an agent in a repository, or a person) can navigate it by following links. Agents should start with [AGENTS.md](AGENTS.md).

## How it was generated

- Command: `dossier publish --out examples/memos-bundle`
- Generated at: `2026-11-09T21:02:25Z`
- Scope: every subject
- Budget per subject: 1200 tokens, depth full
- Fact files: one per fact under `facts/`
- The timestamp is kept as-is while the bundle's content is unchanged, so republishing identical inputs rewrites nothing.

## Totals

- Subjects: 5
- Facts: 32
- Conflicts: 3
- Gaps: 0
- Subject file tokens, all subjects: 1449

## How to read it

Drill-down path: README.md -> INDEX.md -> subjects/<slug>.md -> facts/<shortid>.md

1. [INDEX.md](INDEX.md) lists every subject with its fact, conflict and gap counts and the token cost of its file.
2. `subjects/<slug>.md` is the compiled dossier for one subject; each claim ends in its bracketed fact id.
3. `facts/<shortid>.md` holds one fact in full: text, provenance, data, refs and the facts that reference it.
4. [conflicts.md](conflicts.md) and [gaps.md](gaps.md) collect the disagreements and the unmet needs across subjects.
5. [manifest.json](manifest.json) maps ids to paths and lists every generated file.

## Slugs

A subject's file name is its name lowercased, with every run of characters other than `a-z` and `0-9` turned into a single hyphen and leading and trailing hyphens trimmed (at most 80 characters; `subject` if nothing is left). When two subjects produce the same slug, the first in tree order (name, kind, aliases, then id as a last resort) keeps it and the others get `-2`, `-3`, and so on.
