# Fact 6c2b38c2

Store id: 083b48ca-158a-4cbe-b1a0-fcbf185766a8

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
- posted_at: `2026-11-09T23:44:48.4002810+00:00`

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
  "id": "083b48ca-158a-4cbe-b1a0-fcbf185766a8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.4002810+00:00"
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
  "subject_id": "95979ff2-7c62-44e9-8198-21273ff8f6eb",
  "subject_name": "django/db/models/aggregates::BitOr",
  "tags": [
    "entity:class"
  ],
  "text": "class BitOr(BitAggregate)"
}
```
