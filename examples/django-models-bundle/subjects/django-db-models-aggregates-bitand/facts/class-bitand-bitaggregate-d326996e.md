# Fact d326996e

Store id: 915b7e4b-f59c-480e-84e4-9d47575adcb7

## Text

```text
class BitAnd(BitAggregate)
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
- posted_at: `2026-11-09T22:39:40.0423620+00:00`

## Data

```json
{
  "end_line": 282,
  "entity_kind": "class",
  "parent": "aggregates",
  "start_line": 280,
  "symbol": "BitAnd"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":280,"selector":"L280-L282","symbol":"BitAnd"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::BitAnd](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 282,
    "entity_kind": "class",
    "parent": "aggregates",
    "start_line": 280,
    "symbol": "BitAnd"
  },
  "id": "915b7e4b-f59c-480e-84e4-9d47575adcb7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.0423620+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 280,
        "selector": "L280-L282",
        "symbol": "BitAnd"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "39414f5e-0627-4ff4-b3c1-7da7c8d05b4e",
  "subject_name": "django/db/models/aggregates::BitAnd",
  "tags": [
    "entity:class"
  ],
  "text": "class BitAnd(BitAggregate)"
}
```
