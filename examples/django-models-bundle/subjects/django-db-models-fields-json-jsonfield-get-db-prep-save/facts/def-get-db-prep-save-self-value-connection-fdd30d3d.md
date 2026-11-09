# Fact fdd30d3d

Store id: 406b2d7b-2c92-452c-b2ff-f363040162c2

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
- posted_at: `2026-11-09T23:31:57.8491160+00:00`

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
  "id": "406b2d7b-2c92-452c-b2ff-f363040162c2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.8491160+00:00"
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
  "subject_id": "ed1ed26b-3f42-40ba-9333-2c98d3c6d0d0",
  "subject_name": "django/db/models/fields/json::JSONField.get_db_prep_save",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_prep_save(self, value, connection)"
}
```
