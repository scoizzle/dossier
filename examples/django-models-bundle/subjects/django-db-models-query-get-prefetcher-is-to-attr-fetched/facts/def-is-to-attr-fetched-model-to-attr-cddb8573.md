# Fact cddb8573

Store id: 44cd1cdd-d8cd-4aef-b09c-a74f406c4219

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
- posted_at: `2026-11-09T23:32:04.8346280+00:00`

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
  "id": "44cd1cdd-d8cd-4aef-b09c-a74f406c4219",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.8346280+00:00"
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
  "subject_id": "b96f3e93-0a91-4e25-b411-463f6d4f426e",
  "subject_name": "django/db/models/query::get_prefetcher.is_to_attr_fetched",
  "tags": [
    "entity:function"
  ],
  "text": "def is_to_attr_fetched(model, to_attr)"
}
```
