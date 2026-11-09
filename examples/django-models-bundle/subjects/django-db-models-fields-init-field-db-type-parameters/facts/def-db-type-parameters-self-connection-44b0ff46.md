# Fact 44b0ff46

Store id: afbfee86-ad7a-453d-b79f-4a4b9613fa3d

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
- posted_at: `2026-11-09T22:39:42.3187110+00:00`

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
  "id": "afbfee86-ad7a-453d-b79f-4a4b9613fa3d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.3187110+00:00"
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
  "subject_id": "8868db13-644d-4ffe-8f50-bde2f8618481",
  "subject_name": "django/db/models/fields/__init__::Field.db_type_parameters",
  "tags": [
    "entity:method"
  ],
  "text": "def db_type_parameters(self, connection)"
}
```
