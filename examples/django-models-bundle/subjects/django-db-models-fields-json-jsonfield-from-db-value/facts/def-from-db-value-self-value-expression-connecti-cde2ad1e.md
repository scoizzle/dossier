# Fact cde2ad1e

Store id: 3da25ebf-2783-4fa7-b072-f48b180974b2

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
- posted_at: `2026-11-09T23:44:50.9396490+00:00`

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
  "id": "3da25ebf-2783-4fa7-b072-f48b180974b2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.9396490+00:00"
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
  "subject_id": "7d026c1b-3c8f-4e2e-9e7a-3c9666731f8f",
  "subject_name": "django/db/models/fields/json::JSONField.from_db_value",
  "tags": [
    "entity:method"
  ],
  "text": "def from_db_value(self, value, expression, connection)"
}
```
