# Fact 001df19c

Store id: 0f3e7a4e-75b7-4472-b7bc-90b1092dce07

## Text

```text
def in_prefetched_cache(instance)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:04.8477940+00:00`

## Data

```json
{
  "end_line": 2868,
  "entity_kind": "function",
  "parent": "get_prefetcher",
  "start_line": 2867,
  "symbol": "get_prefetcher.in_prefetched_cache"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2867,"selector":"L2867-L2868","symbol":"get_prefetcher.in_prefetched_cache"}`

## Referenced by

None.

## Subject

[django/db/models/query::get_prefetcher.in_prefetched_cache](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2868,
    "entity_kind": "function",
    "parent": "get_prefetcher",
    "start_line": 2867,
    "symbol": "get_prefetcher.in_prefetched_cache"
  },
  "id": "0f3e7a4e-75b7-4472-b7bc-90b1092dce07",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.8477940+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2867,
        "selector": "L2867-L2868",
        "symbol": "get_prefetcher.in_prefetched_cache"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "ebc6cbd6-7885-4ac6-9afb-9481117583a7",
  "subject_name": "django/db/models/query::get_prefetcher.in_prefetched_cache",
  "tags": [
    "entity:function"
  ],
  "text": "def in_prefetched_cache(instance)"
}
```
