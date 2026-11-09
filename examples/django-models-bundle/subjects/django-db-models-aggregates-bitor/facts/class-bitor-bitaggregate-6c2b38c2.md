# Fact 6c2b38c2

Store id: 426fb2e0-608d-44f2-b658-c1bf9977d076

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
- posted_at: `2026-11-09T23:31:53.5383210+00:00`

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
  "id": "426fb2e0-608d-44f2-b658-c1bf9977d076",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.5383210+00:00"
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
  "subject_id": "007d735b-2fc3-4474-9e0d-c6802aa33cc8",
  "subject_name": "django/db/models/aggregates::BitOr",
  "tags": [
    "entity:class"
  ],
  "text": "class BitOr(BitAggregate)"
}
```
