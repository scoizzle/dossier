# Fact fdd30d3d

Store id: 7911507a-7ea0-40d9-a82f-c5aceab4490e

## Text

```text
def get_db_prep_save(self, value, connection)
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
- posted_at: `2026-11-09T22:39:43.6144120+00:00`

## Data

```json
{
  "end_line": 120,
  "entity_kind": "method",
  "parent": "JSONField",
  "start_line": 106,
  "symbol": "JSONField.get_db_prep_save"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":106,"selector":"L106-L120","symbol":"JSONField.get_db_prep_save"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::JSONField.get_db_prep_save](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 120,
    "entity_kind": "method",
    "parent": "JSONField",
    "start_line": 106,
    "symbol": "JSONField.get_db_prep_save"
  },
  "id": "7911507a-7ea0-40d9-a82f-c5aceab4490e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.6144120+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 106,
        "selector": "L106-L120",
        "symbol": "JSONField.get_db_prep_save"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "abeb4a46-0fdd-4fb9-9464-b11490c84faf",
  "subject_name": "django/db/models/fields/json::JSONField.get_db_prep_save",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_prep_save(self, value, connection)"
}
```
