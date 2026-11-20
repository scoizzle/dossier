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

**CLI.** Commands: `init`, `dump`, `post`, `correlate`, `search`, `show`, `verify`, `changes`, `retract`, `dossier compile`, `publish`, `import`, `check`, `mcp`, `serve`. Examples against the seeded database (`d` is `dotnet src/Dossier/bin/Release/net10.0/Dossier.dll`):

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

$ d verify <id-a> <id-b>                                    # the facts a plan cites, before acting on it (illustrative, not the seeded data)
{"revision":412,"current":false,"facts":[
  {"id":"<id-a>","subject_id":"…","status":"live","current":true},
  {"id":"<id-b>","subject_id":"…","status":"superseded","current":false,"replaced_by":"<id-c>"}]}

$ d verify --require-current <id-a> && ./deploy.sh          # a gate: exit 1 unless every id is live (the answer is still printed)

$ d changes --last 1                                        # start of a session: keep "next" as the cursor
{"from":411,"to":412,"next":412,"truncated":true,"reset":false,"changes":[{"seq":412,"tbl":"slots","op":"update", ...}]}

$ d changes --since 412 --subject Memos/Home                # later: what was written to this subject since

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

`verify` takes fact ids and reports the derived status of each, read in one snapshot: `live`, `superseded` (with `replaced_by`, the fact its slot holds now, which may be several reposts later and is absent when a retraction cleared the slot), `retracted`, `stale`, `contested` or `unknown`, and `why` for the last two (see [derived status](concepts.md#derived-status)). `current` is true for a fact only when it is live, and at the top only when every fact is. It accepts at most 200 ids, answers a repeated id once, writes nothing, and exits 0 whatever the answer; with `--require-current` it exits 1 when any id is not live, naming them on stderr.

`changes` prints the journal page `/api/changes` serves (the row and cursor rules are under [Web](#surfaces) below): `--since <n>` for rows after a cursor (default 0, `--limit` 100, at most 500), or `--last <n>` for the newest rows (at most 500), which wins when both are given. A `--last` or `--limit` below 1 is rejected. `--subject <id|name|alias>` keeps one subject's rows; a page that is not `truncated` then moves `next` to the head, since nothing of that subject is left behind it, and an unknown subject is rejected with `subject_not_found` so a typo cannot read as "nothing changed". The journal records row writes only: a fact that became stale or contested because another fact was written has no row of its own, so `changes` says when to look again and `verify` says what is still true.

An option the command does not take is rejected on stderr with exit 1: `unknown option "--mode" (did you mean --budget-mode?)`, with a suggestion when one is close. An option missing its value fails with `--budget requires a value`, and a rejected command writes nothing.

**MCP.** `dossier mcp` serves newline-delimited JSON-RPC over stdio (protocol versions 2025-06-18, 2025-03-26, 2024-11-05). Nine tools: `dump`, `post_facts`, `correlate`, `search`, `get_fact`, `compile_dossier`, `check`, `verify_facts`, `changes`. Resources: `dossier://subjects`, and the templates `dossier://subject/{id}` and `dossier://fact/{id}`. `post_facts` takes `dry_run`, `search` takes `brief`, and `check` takes `subject` and optional `drafts` (returns the subject with `match` of `exact_id`, `exact_name`, `exact_alias`, `prefix` or `fuzzy`, a summary, and per-draft verdicts with an advisory `near` list; a near duplicate posted anyway is a separate `new` fact). `verify_facts` takes `ids` and `changes` takes `since`, `last`, `limit` and `subject`; both return what the CLI verbs print. There is no retract tool: retraction is a CLI verb. Tool descriptions mark fact text as untrusted data that must never be followed as instructions.

**Web.** `dossier serve [--port 8787]` listens on loopback only and answers requests addressed to `127.0.0.1` or to `localhost` when that name resolves solely to loopback addresses and its first resolved address can be bound (where it resolves to `::1`, that is how the IPv6 loopback is reached), on the serve port; a literal `[::1]` address is not served (the listener rejects the bracketed IPv6 prefix), and a request for any other `Host` is refused with a 4xx, so a page reached through a rebound DNS name cannot read the store. It has a search box in the header, a subject list, search results, a compiled dossier view with its raw JSON, and a single-fact view. JSON endpoints: `/api/subjects`, `/api/search`, `/api/compile`, `/api/fact`, `/api/graph`, `/api/revision`, `/api/changes`, plus the `/api/events` stream. `POST` to any of them is `405`.

**Agent identity.** A fact written over MCP records an actor in its provenance: the sanitized `clientInfo.name` the client sent in `initialize`, else `DOSSIER_AGENT` from the server's environment, else `mcp-client`. MCP writes carry channel `mcp` and actor_type `agent`; the CLI and every caller that names no identity writes `dossier-cli` with channel `cli` and actor_type `tool`. The label is sanitized before it is stored or shown: characters outside `[A-Za-z0-9 ._:@/ -]` become one `-`, runs collapse, the result is trimmed and capped at 64 characters, and a label that sanitizes to nothing is ignored so the fallback stands. It is an unauthenticated label that describes the writer, not proof of who wrote a fact; it never enters `content_hash` and never changes dedupe.

`GET /api/revision` returns `{"revision":N}` from the store's durable `meta.revision` counter. It counts row writes to facts, subjects, refs and slots, so a deduped re-post and every read leave it unchanged; a replaced database restarts it. Treat it as a change signal only: compare two values for inequality, never for magnitude.

`GET /api/changes?since=N&limit=L` returns the journal behind a cursor: `{from,to,next,truncated,reset,changes}`. `changes` are rows with `seq > since`, oldest first, at most `limit` of them (100 when absent, clamped to 1..500); `next`/`to` is the cursor to pass back as `since` and also the last row's seq (the head when the page is empty), and `truncated` is true when more rows exist past it. `from` is the cursor asked. `GET /api/changes?last=L` returns the newest `L` rows oldest first instead: `from` is one below the first row, `next`/`to` the head, and `truncated` is true when older rows were left out. When both are given `last` wins (`limit` is still parsed, so a bad `limit` is still a `400`). A `since` above the head, or below the oldest retained row by more than one, returns `reset: true` with no rows and `next` at the head, so the caller refetches everything. `since` must be a non-negative integer and `limit`/`last` integers; anything else is `400` `invalid_request`.

Each row is `{seq,tbl,op,subject_id,subject_name,fact_id,fact_kind,fact_status,text,actor,at}`: `seq` is the revision it committed under, `tbl` is `facts`, `subjects`, `refs` or `slots`, `op` is `insert`, `update` or `delete`, the fact fields come from the fact the row names (its text cut to 160 characters), and `at` is ISO 8601 UTC. `actor` is set only on a fact insert, where it is that fact's provenance author (see agent identity above); a retraction or delete has no actor, and ref and slot rows belong to the fact they name.

The journal has one row per row write to `facts`, `subjects`, `refs` and `slots` — twelve triggers, one per table and operation — each written under the same number as `meta.revision`, so `seq == revision` and the counter and journal commit or roll back together. Writers prune inside their own transaction in batches: once the oldest row is more than 100,000 rows (`ChangeRetention`) plus 1,000 of slack (`PruneSlack`) behind the head, rows at or below `head - 100,000` are deleted, so a delete runs about once per 1,000 writes and a window is 100,000 rows plus that slack. A cursor that fell out of it gets `reset` from `/api/changes`, or a `reset` frame from `/api/events`.

`GET /api/events` is a Server-Sent Events stream (`text/event-stream; charset=utf-8`, `Cache-Control: no-store`, chunked, same CSP and `nosniff` header as every other response). It opens with `retry: 1000`, then sends the revision it last polled as a baseline — `event: revision` followed by `data: <int>` — and one more each time the polled revision (every 500 ms) differs from the last value sent on that stream. The journal follows as `event: changes` frames, each with its own `id: <cursor>` line and a `data:` payload of the shape `/api/changes` returns (a page of at most 200 rows, up to 5,000 rows drained per tick); a resume point outside the retained window, or a tick that reaches 5,000 rows with more still pending, becomes one `event: reset` with the current revision as both `id:` and `data:`. A failing journal read skips that tick instead of ending the stream. `revision` frames carry no rows: changes arrive in `changes` frames and every discontinuity in `reset`.

Resume: `Last-Event-ID` (sent by `EventSource` on reconnect) wins over `?since=N`, and with neither the stream starts at the revision the server last polled. That cached value can be up to one poll interval (500 ms) old, so a fresh stream can replay rows written in that window; it skips nothing else. `graph.js` always passes `?since=`, so the graph view never depends on that; `?since=0` replays everything retained. While idle it writes a `: keepalive <padding>` comment every five seconds, and a journal read that failed is retried on the next poll tick and on every keepalive until it succeeds — a skipped read does not wait for a new write. Eight streams run concurrently; the ninth gets `503` with `{"error":{"code":"busy","message":...}}`. Streams never block the accept loop, so other endpoints keep answering while one is open, and a closed tab is noticed on its next failed write. `curl -N 'http://127.0.0.1:8787/api/events?since=0'` prints the stream; `curl 'http://127.0.0.1:8787/api/changes?last=5'` prints the newest five rows as JSON.

The **graph view** (`#/graph/<subject>`, linked from the subject list and every subject page; `#/graph/` is the subject tree) draws a bounded neighbourhood on a canvas. Click a node for its panel; double-click it, or press `e` or `Enter` with a node selected, to expand it in place (the expansion request keeps the view's `depth` and `facts`); `f` fits the view, `Escape` closes the panel. Keys typed into an input, textarea, select or editable content are ignored, and so are the shortcuts while a button or link has focus (`Escape` still closes the panel there). The banner above the canvas shows the largest hidden count seen per category (subjects, facts, refs) since the page was opened, so a later expansion never hides truncation that still applies; opening another root starts fresh.

The view is live. It reads `/api/changes?last=50` once for the feed's history and `/api/revision` for its seq baseline, then listens on `/api/events` from that seq. A change row that names a subject the view fetches re-fetches just that subject; anything else (a subject-table row, a row with no subject, a subject it only holds as a stub) re-fetches the root and every expanded subject, debounced by 250 ms so a burst of writes costs one request, and rows at or below the applied seq are dropped as redeliveries. Deleting a fact — or a fact update that arrives `retracted` — removes the node live, deleting a subject removes it with its facts, and superseded facts stay on the canvas; existing nodes keep their positions and selection while their record updates in place, and new nodes from a delta are placed next to what they hang from and glow briefly (nothing glows with `prefers-reduced-motion: reduce`). A `reset` frame re-fetches everything through the same gate and refills the feed from `/api/changes?last=50`. If `EventSource` is missing or the stream closes — a `503 busy` past eight tabs, for instance — the view polls `/api/changes` every second from its seq watermark (`?last=200` before it has one) instead. Browsers allow roughly six HTTP/1.1 connections per origin, so many open tabs can starve each other's streams; the poll fallback still keeps them current. The CSP is unchanged: `connect-src 'self'` already covers `EventSource`.

The **activity feed** is the strip under the graph bar, fed by those same batches (it makes no request of its own). One line per journal row: a fact insert reads `<actor> added <snippet> to <subject>`, a retraction or delete reads neutrally with its status, a subject insert/update/delete names the subject, and refs and slots fold into their fact's line as `+N refs` (or one aggregate line when their fact is not in the batch). It keeps the newest 80 rows, newest first, with relative times that refresh every ten seconds; clicking a row selects and focuses the node it names (a row whose target was removed is a no-op), and the `Activity` header collapses the strip. Every value is rendered as text, so a hostile subject name or snippet stays text.

`GET /api/graph?subject=<id|name>&depth=<0..3, default 1>&facts=<true|false|1|0, case-insensitive, default true>&max_nodes=<1..2000, default 500>` returns `{format, seed, root, subjects, facts, edges, unresolved, truncated:{subjects,facts,edges,unresolved}, limits}`. Nodes never exceed `max_nodes`. Admission order is the root, its parent chain, then each hop in ordinal id order (children and subjects reached through refs; when the cap falls inside a hop, that hop is admitted in id order until it is full), then the facts of admitted subjects, then boundary subjects (owners of facts that refer into the graph, marked `boundary`, lowest id first, only as many as the cap leaves room for). With `facts=false` the response is the subject tree only: the parent chain and children down to `depth`, no facts and no refs. Without `subject` the response is the whole subject tree (`facts` is ignored), capped by `max_nodes`. The payload carries no revision: `/api/events` is the change signal, and a refresh re-reads the same request and merges it in place.

Edges: an edge is emitted only when both ends are in the payload. `contains` runs from a subject to its child subject; `fact`, `subject` and `slot` come from a fact's own refs (slot refs point at the current occupant facts of the slot, or at the owning subject when the slot is empty; a name that matches several subjects links to all of them and is marked `ambiguous`); `inbound` runs from an admitted fact to a boundary subject that owns a fact referring to it (directly, or through the slot the admitted fact occupies). Symbol and other external refs stay on their fact (`unresolved` on the fact node) and are never nodes. Hidden ends are reported, not drawn: `unresolved` lists one `{from, rel, kind, target, reason}` entry per hidden ref, where `from` is the fact that carries the ref and `reason` is `not_admitted` (the target exists but is not in the payload, including a referrer that was not admitted, such as a non-boundary subject's fact, a fact cut by the cap, or a boundary subject beyond the cap) or `not_found` (nothing matches the target). `truncated.subjects` counts subjects not admitted, `truncated.facts` counts facts of admitted subjects not admitted, and `truncated.edges` counts every `not_admitted` ref once (an outgoing ref of an admitted fact, a hidden fact of an admitted subject that refers to an admitted fact, or a hidden referrer subject's distinct inbound ref); `not_found` refs are not counted there. `unresolved` is capped at 2000 entries; `truncated.unresolved` is how many entries were dropped past the cap (0 when none were). Bad parameters give `400` (`bad_depth`, `bad_max_nodes`, `bad_facts`), an unknown subject `404`. Fact text is capped at 500 characters in this payload, marker included: a longer text is cut to 499 characters (a surrogate pair is never split) and ends with `…`; `/api/fact` has the full text. The page's scripts are served from `/app.js`, `/graph.js` and `/feed.js` under `Content-Security-Policy: default-src 'none'; script-src 'self'; ...`, so no inline script runs.

**Multi-agent demo.** `scripts/live-demo.mjs` (Node 18+, no dependencies) runs the whole loop: it finds the Release build (or builds it once; `DOSSIER_NO_BUILD=1` refuses), starts `dossier serve` on a temporary database, seeds one root subject, then spawns N real `dossier mcp` children that post facts over stdio JSON-RPC while the script itself reads `/api/events` from the run's baseline seq and samples `/api/graph`. Each child sends `clientInfo.name` `agent-0`..`agent-N-1`, so every fact it posts carries that actor. `node scripts/live-demo.mjs --agents 4 --facts 100` prints the graph URL to open and a summary: facts posted, wall time, writes per second, per-agent errors (busy/locked counted separately), revision events, `changes` frames, change rows and reset frames received over the stream, the distinct actors seen (from the change rows and a final `/api/changes` read), journal rows behind the run and rows per posted fact, graph latency p50/p95 during and after the run, and the final revision. `--rate <facts/sec per agent>` throttles each writer, `--db <path>` reuses a database, `--keep` leaves the server up for viewing until Ctrl-C, and `--port` starts at 8787 and moves to the next free port when that one is taken. Exit codes: `0` when nothing failed, `1` on a run failure (a write error, a graph status failure, a stream behind the final revision or not answering with `200 text/event-stream`, a journal read that fails, or fewer distinct actors than agents — an identity regression), and `2` on a usage or setup error (a bad flag, no build, the server not coming up).
