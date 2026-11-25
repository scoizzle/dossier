# Self-map: Dossier documenting Dossier

This directory builds a Dossier store that maps this repository: one subject per file, type, method,
CLI verb, MCP tool, table, schema, doc, test file and script, and one-claim facts about each, every
fact carrying a git ref pinned to one commit, with the line, a GitHub permalink and the blob hash.
It is the project's own answer to "what does an agent need to know about Dossier, and where can it
check each thing".

```sh
dotnet build src/Dossier/Dossier.csproj -c Release
node scripts/self-map/build.mjs --plan            # what would be built: subjects, facts, conflicts
node scripts/self-map/build.mjs --db out/self-map/dossier.db --out out/self-map/bundle
```

The build reads the repository at the commit in `slices.json` (override with `--rev`), posts through
`dossier mcp` so every fact carries the writer that produced it, and can publish a JSONL bundle.
`out/` is gitignored; the store is a build product, not a committed artifact.

## The three layers

| Layer | Actor | Files | How it is checked |
| --- | --- | --- | --- |
| extracted | `self-map-extractor` | `build.mjs` | parsed straight from the files at the pinned commit |
| written | `self-map-author` | `knowledge/*.json` | each fact cites `[file, phrase]`, and the phrase must occur in that file |
| swarm | `swarm-<slice>` | `swarm/*.json` | `agent.mjs submit` checks the citation lies in the agent's slice, its numbers occur near the cited line, and it is not a near duplicate |

`knowledge/` holds what no parser can find: concepts, guarantees, decisions, gaps, research and the
evaluation numbers. `swarm/` holds what delegated agents submitted, one file per agent, replayed in
file order so a rebuild gives the same graph.

## The swarm

`slices.json` gives each delegated agent a disjoint set of files (or line ranges of one long file)
and the lines it may cite. `agent.mjs` is how an agent works:

```sh
node scripts/self-map/agent.mjs brief  --agent <slice>   # what to read, what is already recorded
node scripts/self-map/agent.mjs submit --agent <slice> --file drafts.json
```

`submit` rejects a fact whose citation is outside the agent's slice, whose numbers do not occur
within 25 lines of the cited line, whose identifiers are not in the slice, or which duplicates
something on the same subject. It cannot tell a true claim from a false one that reuses the right
words, so `audit.json` records the facts a person read next to their cited lines, and
`agent.mjs sample --per 4` prints that sample.

## What the map is not

- It describes one commit. A ref to a branch name would rot; every ref here is pinned and carries
  the blob hash, and `--rev` is how a later commit is mapped.
- A swarm fact is a lead, not a verified claim: each carries confidence 0.8, and the ones a person
  read are listed in `audit.json`.
- `dump` stores the source path as given, so the raw text of each doc lives under `<doc path>/raw`
  with a `file` ref to the repository path.
