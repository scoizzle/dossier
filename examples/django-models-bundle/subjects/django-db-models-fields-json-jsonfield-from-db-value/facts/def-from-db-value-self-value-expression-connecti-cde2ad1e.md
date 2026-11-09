# Fact cde2ad1e

Store id: ee291883-f135-4dff-a4fc-284b51ead5ac

## Text

```text
def from_db_value(self, value, expression, connection)
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
- posted_at: `2026-11-09T23:31:57.8430910+00:00`

## Data

```json
{
  "end_line": 96,
  "entity_kind": "method",
  "parent": "JSONField",
  "start_line": 86,
  "symbol": "JSONField.from_db_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":86,"selector":"L86-L96","symbol":"JSONField.from_db_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::JSONField.from_db_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 96,
    "entity_kind": "method",
    "parent": "JSONField",
    "start_line": 86,
    "symbol": "JSONField.from_db_value"
  },
  "id": "ee291883-f135-4dff-a4fc-284b51ead5ac",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.8430910+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 86,
        "selector": "L86-L96",
        "symbol": "JSONField.from_db_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "ebf3c0dd-f0bf-4902-8bc8-6dabf329b7dc",
  "subject_name": "django/db/models/fields/json::JSONField.from_db_value",
  "tags": [
    "entity:method"
  ],
  "text": "def from_db_value(self, value, expression, connection)"
}
```
