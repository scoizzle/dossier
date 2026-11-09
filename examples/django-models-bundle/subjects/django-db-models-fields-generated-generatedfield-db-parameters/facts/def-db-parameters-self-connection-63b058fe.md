# Fact 63b058fe

Store id: 125ac6e0-98ea-4087-9246-131522766f68

## Text

```text
def db_parameters(self, connection)
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
- posted_at: `2026-11-09T23:31:57.6452110+00:00`

## Data

```json
{
  "end_line": 204,
  "entity_kind": "method",
  "parent": "GeneratedField",
  "start_line": 203,
  "symbol": "GeneratedField.db_parameters"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/generated.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":203,"selector":"L203-L204","symbol":"GeneratedField.db_parameters"}`

## Referenced by

None.

## Subject

[django/db/models/fields/generated::GeneratedField.db_parameters](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 204,
    "entity_kind": "method",
    "parent": "GeneratedField",
    "start_line": 203,
    "symbol": "GeneratedField.db_parameters"
  },
  "id": "125ac6e0-98ea-4087-9246-131522766f68",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.6452110+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 203,
        "selector": "L203-L204",
        "symbol": "GeneratedField.db_parameters"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/generated.py"
    }
  ],
  "status": "live",
  "subject_id": "9c059fe2-943f-4dbc-b7ea-399924875a65",
  "subject_name": "django/db/models/fields/generated::GeneratedField.db_parameters",
  "tags": [
    "entity:method"
  ],
  "text": "def db_parameters(self, connection)"
}
```
