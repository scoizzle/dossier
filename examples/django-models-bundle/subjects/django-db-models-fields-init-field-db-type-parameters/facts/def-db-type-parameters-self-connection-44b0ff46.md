# Fact 44b0ff46

Store id: a6c95733-853e-4e3c-9032-eeda817008b9

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
- posted_at: `2026-11-09T23:31:56.4725620+00:00`

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
  "id": "a6c95733-853e-4e3c-9032-eeda817008b9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.4725620+00:00"
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
  "subject_id": "6cf2c737-fe1b-4ea8-af89-c484e0dd5e3c",
  "subject_name": "django/db/models/fields/__init__::Field.db_type_parameters",
  "tags": [
    "entity:method"
  ],
  "text": "def db_type_parameters(self, connection)"
}
```
