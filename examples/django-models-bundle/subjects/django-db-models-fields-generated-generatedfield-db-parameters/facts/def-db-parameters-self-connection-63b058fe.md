# Fact 63b058fe

Store id: 220026e3-fe7c-47b4-95c1-4c4999a78240

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
- posted_at: `2026-11-09T23:44:50.8144000+00:00`

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
  "id": "220026e3-fe7c-47b4-95c1-4c4999a78240",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.8144000+00:00"
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
  "subject_id": "9f6decc6-6e75-495e-91f1-320d0a934bcd",
  "subject_name": "django/db/models/fields/generated::GeneratedField.db_parameters",
  "tags": [
    "entity:method"
  ],
  "text": "def db_parameters(self, connection)"
}
```
