# Fact e98afc36

Store id: 8312bf37-1bc2-49ef-a5ca-f68f9d61eb4c

## Text

```text
class Min(Aggregate)
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
- posted_at: `2026-11-09T22:39:40.0449050+00:00`

## Data

```json
{
  "end_line": 337,
  "entity_kind": "class",
  "parent": "aggregates",
  "start_line": 334,
  "symbol": "Min"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":334,"selector":"L334-L337","symbol":"Min"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::Min](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 337,
    "entity_kind": "class",
    "parent": "aggregates",
    "start_line": 334,
    "symbol": "Min"
  },
  "id": "8312bf37-1bc2-49ef-a5ca-f68f9d61eb4c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.0449050+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 334,
        "selector": "L334-L337",
        "symbol": "Min"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "78a6f898-6545-4e1f-b10d-78618ec8767c",
  "subject_name": "django/db/models/aggregates::Min",
  "tags": [
    "entity:class"
  ],
  "text": "class Min(Aggregate)"
}
```
