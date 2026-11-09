# Fact 6c2b38c2

Store id: b77f4826-03c7-4db5-93b2-317d60962a72

## Text

```text
class BitOr(BitAggregate)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:40.0428450+00:00`

## Data

```json
{
  "end_line": 287,
  "entity_kind": "class",
  "parent": "aggregates",
  "start_line": 285,
  "symbol": "BitOr"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":285,"selector":"L285-L287","symbol":"BitOr"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::BitOr](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 287,
    "entity_kind": "class",
    "parent": "aggregates",
    "start_line": 285,
    "symbol": "BitOr"
  },
  "id": "b77f4826-03c7-4db5-93b2-317d60962a72",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.0428450+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 285,
        "selector": "L285-L287",
        "symbol": "BitOr"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "b39e10e9-db51-4ed6-b24a-9ffbbba0e3ab",
  "subject_name": "django/db/models/aggregates::BitOr",
  "tags": [
    "entity:class"
  ],
  "text": "class BitOr(BitAggregate)"
}
```
