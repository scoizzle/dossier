# Fact cddb8573

Store id: 2847a17b-ad6d-4ed9-b022-09585af9a960

## Text

```text
def is_to_attr_fetched(model, to_attr)
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
- posted_at: `2026-11-09T23:44:56.3180500+00:00`

## Data

```json
{
  "end_line": 2834,
  "entity_kind": "function",
  "parent": "get_prefetcher",
  "start_line": 2821,
  "symbol": "get_prefetcher.is_to_attr_fetched"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2821,"selector":"L2821-L2834","symbol":"get_prefetcher.is_to_attr_fetched"}`

## Referenced by

None.

## Subject

[django/db/models/query::get_prefetcher.is_to_attr_fetched](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2834,
    "entity_kind": "function",
    "parent": "get_prefetcher",
    "start_line": 2821,
    "symbol": "get_prefetcher.is_to_attr_fetched"
  },
  "id": "2847a17b-ad6d-4ed9-b022-09585af9a960",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.3180500+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2821,
        "selector": "L2821-L2834",
        "symbol": "get_prefetcher.is_to_attr_fetched"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "6c9d2c41-d0b4-42c6-9133-903c9582b35e",
  "subject_name": "django/db/models/query::get_prefetcher.is_to_attr_fetched",
  "tags": [
    "entity:function"
  ],
  "text": "def is_to_attr_fetched(model, to_attr)"
}
```
