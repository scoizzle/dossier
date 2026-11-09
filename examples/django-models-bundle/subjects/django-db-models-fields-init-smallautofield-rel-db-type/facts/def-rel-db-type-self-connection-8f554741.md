# Fact 8f554741

Store id: 8f19e722-91e9-45cf-a395-7d2cf263bdde

## Text

```text
def rel_db_type(self, connection)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:50.3474290+00:00`

## Data

```json
{
  "end_line": 2984,
  "entity_kind": "method",
  "parent": "SmallAutoField",
  "start_line": 2983,
  "symbol": "SmallAutoField.rel_db_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2983,"selector":"L2983-L2984","symbol":"SmallAutoField.rel_db_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::SmallAutoField.rel_db_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2984,
    "entity_kind": "method",
    "parent": "SmallAutoField",
    "start_line": 2983,
    "symbol": "SmallAutoField.rel_db_type"
  },
  "id": "8f19e722-91e9-45cf-a395-7d2cf263bdde",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.3474290+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2983,
        "selector": "L2983-L2984",
        "symbol": "SmallAutoField.rel_db_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "73793dec-52a0-45bf-9277-4ba38ce0153a",
  "subject_name": "django/db/models/fields/__init__::SmallAutoField.rel_db_type",
  "tags": [
    "entity:method"
  ],
  "text": "def rel_db_type(self, connection)"
}
```
