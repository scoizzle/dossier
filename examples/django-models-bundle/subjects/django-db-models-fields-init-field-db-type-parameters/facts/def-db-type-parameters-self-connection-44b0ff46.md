# Fact 44b0ff46

Store id: 668ac4e0-9b74-4005-804b-f8a6552c445b

## Text

```text
def db_type_parameters(self, connection)
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
- posted_at: `2026-11-09T23:44:50.0135180+00:00`

## Data

```json
{
  "end_line": 881,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 880,
  "symbol": "Field.db_type_parameters"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":880,"selector":"L880-L881","symbol":"Field.db_type_parameters"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.db_type_parameters](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 881,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 880,
    "symbol": "Field.db_type_parameters"
  },
  "id": "668ac4e0-9b74-4005-804b-f8a6552c445b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.0135180+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 880,
        "selector": "L880-L881",
        "symbol": "Field.db_type_parameters"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "4164195d-6322-40f0-a04c-6b8f9279c6ab",
  "subject_name": "django/db/models/fields/__init__::Field.db_type_parameters",
  "tags": [
    "entity:method"
  ],
  "text": "def db_type_parameters(self, connection)"
}
```
