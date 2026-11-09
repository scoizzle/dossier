# Fact 63b058fe

Store id: f997adab-4ad5-4222-9abe-84cf6ea92b07

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
- posted_at: `2026-11-09T22:39:43.4448660+00:00`

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
  "id": "f997adab-4ad5-4222-9abe-84cf6ea92b07",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.4448660+00:00"
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
  "subject_id": "7c3f96c0-343b-4ce7-932f-17a17ea888c3",
  "subject_name": "django/db/models/fields/generated::GeneratedField.db_parameters",
  "tags": [
    "entity:method"
  ],
  "text": "def db_parameters(self, connection)"
}
```
