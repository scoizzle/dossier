# CLI, MCP and web

Reference for the three surfaces over the same core functions: the CLI verbs, the MCP server and the loopback web UI. Back to the [README](../README.md).

## Three verbs

**dump** ingests raw material deterministically into facts: `dossier dump --source <path> --subject <name>`. The input is stored as a content-addressed blob, split by markdown headings (`--split heading`, the default for `.md` and `.markdown`) or kept whole as one fact (`--split file` or `none`, the default for everything else). Any other `--split` value is rejected with `invalid_split` in the manifest's `errors`. The result is a manifest of created, deduped and skipped items. Running it twice is idempotent. Structured facts with declared refs go in through `dossier post --file <request.json>`.

**correlate** proposes refs between facts using deterministic matchers (`same_ref`, `shared_tag`): `dossier correlate [--subject <name>] [--matcher <same_ref|shared_tag>]...`; `--matcher` is repeatable and limits which matchers run (an unknown name is rejected with `invalid_matcher`). Proposals carry basis `derived`, are returned and never written, and are never asserted as truth.

**retrieve** finds facts or compiles a dossier. `dossier search` takes text and filters, including reverse-impact lookup with `--ref-target`. `dossier dossier compile --subject <name> --budget <n>` compiles the cited, budgeted dossier.

## Quick start in full

Needs the .NET 10 SDK, and `jq` and bash for the seed script.

```sh
dotnet build -c Release
export DOSSIER_DB=./dossier.db
dotnet src/Dossier/bin/Release/net10.0/Dossier.dll init
bash scripts/seed.sh
dotnet src/Dossier/bin/Release/net10.0/Dossier.dll dossier compile --subject Memos/Home --depth full --format markdown
```

Output of the last command (ids are GUIDs and differ per database, so `used_tokens` moves by a token or so between runs; the first two lines go to stderr):

```text
token estimator: chars/4
used_tokens: 709
# Memos/Home

- Home composer lets a user type a memo, attach media, and choose visibility. [92dc475f-78ce-40f8-8523-ed5cda0237b6]
- Home header is 64 pixels tall in the first audit and shows the workspace name. [80899598-5e1d-4054-963d-764eba1d50a0]
- Clicking a memo card opens the memo detail screen. [d5f05ca1-6c1c-4ffd-b439-b214abdca764]
... (24 facts in all)

## Conflicts

- composerMaxRows: 12 [8a8aa039-f1a3-4e35-be48-441ff1c368d5]; 6 [1c1cd226-3817-4475-b274-37e4e77473ae]
- headerHeight: 64 [80899598-5e1d-4054-963d-764eba1d50a0]; 72 [3340714d-13c2-4cc0-8ee0-c0b664e4242c]
- saveShortcut: "Cmd+Enter" [55e5a8f6-3d4b-40c4-be9f-93d9c5544e40]; "Ctrl+Enter" [b70c6049-05f9-4fb8-92f7-2efb5de57da9]
```

The seed script prints `subjects_created=5` and `facts_created=32`.

## Surfaces

All three surfaces call the same core functions.

**CLI.** Commands: `init`, `dump`, `post`, `correlate`, `search`, `show`, `retract`, `dossier compile`, `publish`, `import`, `check`, `mcp`, `serve`. Examples against the seeded database (`d` is `dotnet src/Dossier/bin/Release/net10.0/Dossier.dll`):

```text
$ d search --q composer --subject Memos/Home --limit 2     # trimmed
{"total":9,"complete":false,"hits":[
  {"id":"4b2d39e9","kind":"element","text":"Home composer suggests @mentions as the user types a name.","status":"live","score":-1.83},
  {"id":"1c1cd226","kind":"element","text":"Home composer grows to at most 6 rows before it scrolls.","status":"live","score":-1.80}]}

$ d check --subject "memos/home"                            # resolve + what is known, one call
{"subject":{"id":"…","name":"Memos/Home","kind":"screen","aliases":["Home"],"facts":24,"match":"exact_name"},
 "summary":{"facts":24,"conflicts":3,"gaps":0,"top":[{"key":"…","text":"…"}]}}   # top: at most 8, text capped at 120 chars

$ d check --subject "memos home"                            # a different spelling resolves only fuzzily: confirm the name before posting
{"subject":{"id":"…","name":"Memos/Home","kind":"screen","aliases":["Home"],"facts":24,"match":"fuzzy"},
 "summary":{"facts":24,"conflicts":3,"gaps":0,"top":[{"key":"…","text":"…"}]}}

$ d check --subject "memos/home" --drafts drafts.json       # adds a verdict per draft: new|deduped|replaced + advisory near[] (up to 3 ids at Jaccard >= 0.85); writes nothing

$ d post --file payload.json --dry-run                      # same verdicts as a real post, nothing written
$ d search --q composer --subject Memos/Home --brief        # id, kind, status, first 120 chars of text; total/complete/next kept

$ d dossier compile --subject Memos/Home --depth index --budget 300 --need "billing invoice" --format markdown   # tail
## Conflicts
- composerMaxRows: 12 [...]; 6 [...]
- headerHeight: 64 [...]; 72 [...]
- saveShortcut: "Cmd+Enter" [...]; "Ctrl+Enter" [...]

## Gaps
- billing invoice: no fact

$ d dump --source scripts/seed/notes.md --subject Notes/Demo   # first run, then second run
created=4 deduped=0, skipped=[], errors=[]
created=0 deduped=4

$ d correlate --subject Memos/Home                         # 6 proposals, none written
{"proposed":[{"fact_id":"4b2d39e9-...","ref":{"rel":"mentions","kind":"fact","target":"92dc475f-...","basis":"derived"}}, ...
```

A need with no matching fact is reported as a gap instead of being silently dropped, and conflicting values for the same slot are listed with both cites; `conflicts[].resolution` is always null.

An option the command does not take is rejected on stderr with exit 1: `unknown option "--mode" (did you mean --budget-mode?)`, with a suggestion when one is close. An option missing its value fails with `--budget requires a value`, and a rejected command writes nothing.

**MCP.** `dossier mcp` serves newline-delimited JSON-RPC over stdio (protocol versions 2025-06-18, 2025-03-26, 2024-11-05). Seven tools: `dump`, `post_facts`, `correlate`, `search`, `get_fact`, `compile_dossier`, `check`. Resources: `dossier://subjects`, and the templates `dossier://subject/{id}` and `dossier://fact/{id}`. `post_facts` takes `dry_run`, `search` takes `brief`, and `check` takes `subject` and optional `drafts` (returns the subject with `match` of `exact_id`, `exact_name`, `exact_alias`, `prefix` or `fuzzy`, a summary, and per-draft verdicts with an advisory `near` list; a near duplicate posted anyway is a separate `new` fact). Tool descriptions mark fact text as untrusted data that must never be followed as instructions.

**Web.** `dossier serve [--port 8787]` listens on loopback only and answers requests addressed to `127.0.0.1` or to `localhost` when that name resolves solely to loopback addresses and its first resolved address can be bound (where it resolves to `::1`, that is how the IPv6 loopback is reached), on the serve port; a literal `[::1]` address is not served (the listener rejects the bracketed IPv6 prefix), and a request for any other `Host` is refused with a 4xx, so a page reached through a rebound DNS name cannot read the store. It has a search box in the header, a subject list, search results, a compiled dossier view with its raw JSON, and a single-fact view. JSON endpoints: `/api/subjects`, `/api/search`, `/api/compile`, `/api/fact`, `/api/graph`.

The **graph view** (`#/graph/<subject>`, linked from the subject list and every subject page; `#/graph/` is the subject tree) draws a bounded neighbourhood on a canvas. Click a node for its panel; double-click it, or press `e` or `Enter` with a node selected, to expand it in place (the expansion request keeps the view's `depth` and `facts`); `f` fits the view, `Escape` closes the panel. Keys typed into an input, textarea, select or editable content are ignored, and so are the shortcuts while a button or link has focus (`Escape` still closes the panel there). The banner above the canvas shows the largest hidden count seen per category (subjects, facts, refs) since the page was opened, so a later expansion never hides truncation that still applies; opening another root starts fresh.

`GET /api/graph?subject=<id|name>&depth=<0..3, default 1>&facts=<true|false|1|0, case-insensitive, default true>&max_nodes=<1..2000, default 500>` returns `{format, seed, root, subjects, facts, edges, unresolved, truncated:{subjects,facts,edges,unresolved}, limits}`. Nodes never exceed `max_nodes`. Admission order is the root, its parent chain, then each hop in ordinal id order (children and subjects reached through refs; when the cap falls inside a hop, that hop is admitted in id order until it is full), then the facts of admitted subjects, then boundary subjects (owners of facts that refer into the graph, marked `boundary`, lowest id first, only as many as the cap leaves room for). With `facts=false` the response is the subject tree only: the parent chain and children down to `depth`, no facts and no refs. Without `subject` the response is the whole subject tree (`facts` is ignored), capped by `max_nodes`.

Edges: an edge is emitted only when both ends are in the payload. `contains` runs from a subject to its child subject; `fact`, `subject` and `slot` come from a fact's own refs (slot refs point at the current occupant facts of the slot, or at the owning subject when the slot is empty; a name that matches several subjects links to all of them and is marked `ambiguous`); `inbound` runs from an admitted fact to a boundary subject that owns a fact referring to it (directly, or through the slot the admitted fact occupies). Symbol and other external refs stay on their fact (`unresolved` on the fact node) and are never nodes. Hidden ends are reported, not drawn: `unresolved` lists one `{from, rel, kind, target, reason}` entry per hidden ref, where `from` is the fact that carries the ref and `reason` is `not_admitted` (the target exists but is not in the payload, including a referrer that was not admitted, such as a non-boundary subject's fact, a fact cut by the cap, or a boundary subject beyond the cap) or `not_found` (nothing matches the target). `truncated.subjects` counts subjects not admitted, `truncated.facts` counts facts of admitted subjects not admitted, and `truncated.edges` counts every `not_admitted` ref once (an outgoing ref of an admitted fact, a hidden fact of an admitted subject that refers to an admitted fact, or a hidden referrer subject's distinct inbound ref); `not_found` refs are not counted there. `unresolved` is capped at 2000 entries; `truncated.unresolved` is how many entries were dropped past the cap (0 when none were). Bad parameters give `400` (`bad_depth`, `bad_max_nodes`, `bad_facts`), an unknown subject `404`. Fact text is capped at 500 characters in this payload, marker included: a longer text is cut to 499 characters (a surrogate pair is never split) and ends with `…`; `/api/fact` has the full text. The page's scripts are served from `/app.js` and `/graph.js` under `Content-Security-Policy: default-src 'none'; script-src 'self'; ...`, so no inline script runs.
