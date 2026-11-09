# Fact cddb8573

Store id: 5ee5a5a0-6153-4e37-aa79-7ce93f83336d

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
- posted_at: `2026-11-09T22:39:49.8829380+00:00`

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
  "id": "5ee5a5a0-6153-4e37-aa79-7ce93f83336d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.8829380+00:00"
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
  "subject_id": "35849573-2610-4c13-b916-f934fd3c1264",
  "subject_name": "django/db/models/query::get_prefetcher.is_to_attr_fetched",
  "tags": [
    "entity:function"
  ],
  "text": "def is_to_attr_fetched(model, to_attr)"
}
```
