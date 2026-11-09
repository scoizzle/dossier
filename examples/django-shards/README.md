# Dossier bundle

This is a Dossier bundle: an export of a fact store as plain markdown files, so a reader with no tools (an agent in a repository, or a person) can navigate it by following links. Agents should start with [AGENTS.md](AGENTS.md).

## How it was generated

- Command: `dossier publish --out examples/django-shards --profile profiles/copilot-studio.json --respect-limits`
- Generated at: `2026-11-09T22:55:55Z`
- Scope: every subject
- Budget per subject: 1200 tokens, depth full
- Layout: shard mode (`--respect-limits`), 399 documents under `shards/<n>.md`; subjects are anchors inside them
- Fact files: omitted in shard mode; bracketed fact keys are plain citations
- Assets: omitted in shard mode; attachments are listed by sha256 with no link
- The timestamp is kept as-is while the bundle's content is unchanged, so republishing identical inputs rewrites nothing.

## Totals

- Subjects: 1080
- Facts: 12526
- Conflicts: 0
- Gaps: 0
- Subject file tokens, all subjects: 657499

## How to read it

Drill-down path: AGENTS.md -> INDEX.md -> index/<group>.md (repeat while the row is a group) -> shards/<n>.md#<slug>

1. [INDEX.md](INDEX.md) lists every subject, or, in a large bundle, the top-level groups; each subject row links to `shards/<n>.md#<slug>`. Each index file is capped at 6000 tokens.
2. `shards/<n>.md` is a self-contained document: front matter, a table of contents of its subjects, then one section per subject (anchor = slug) holding that subject's compiled dossier, each claim ending in its bracketed fact key.
3. [conflicts.md](conflicts.md) and [gaps.md](gaps.md) collect the disagreements and the unmet needs across subjects; their links point into the shards.
4. [manifest.json](manifest.json) maps subject ids to `shards/<n>.md#<slug>` and lists every generated file and the subjects in each shard.

## Links

A link to a subject is `<n>.md#<slug>` from inside a shard (`#<slug>` when it is in the same shard) and `shards/<n>.md#<slug>` from the bundle root; every target file and anchor exists.

## Slugs

A subject's anchor is its name lowercased, with every run of characters other than `a-z` and `0-9` turned into a single hyphen and leading and trailing hyphens trimmed (at most 80 characters; `subject` if nothing is left); collisions get `-2`, `-3`, and so on in tree order.
