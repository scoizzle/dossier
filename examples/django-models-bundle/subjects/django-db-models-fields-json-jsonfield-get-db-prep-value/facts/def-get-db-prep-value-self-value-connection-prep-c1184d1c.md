# Fact c1184d1c

Store id: 4dd5b29d-3ed3-45a6-9dcf-6f0b11dee810

## Text

```text
def get_db_prep_value(self, value, connection, prepared=False)
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
- posted_at: `2026-11-09T22:39:43.6116810+00:00`

## Data

```json
{
  "end_line": 104,
  "entity_kind": "method",
  "parent": "JSONField",
  "start_line": 101,
  "symbol": "JSONField.get_db_prep_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":101,"selector":"L101-L104","symbol":"JSONField.get_db_prep_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::JSONField.get_db_prep_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 104,
    "entity_kind": "method",
    "parent": "JSONField",
    "start_line": 101,
    "symbol": "JSONField.get_db_prep_value"
  },
  "id": "4dd5b29d-3ed3-45a6-9dcf-6f0b11dee810",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.6116810+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 101,
        "selector": "L101-L104",
        "symbol": "JSONField.get_db_prep_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "b01ab9fc-e88f-4b9b-bfba-c90b22de08f4",
  "subject_name": "django/db/models/fields/json::JSONField.get_db_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_prep_value(self, value, connection, prepared=False)"
}
```
