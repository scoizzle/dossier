# Fact abd8c538

Store id: 37565bb0-3a57-4d61-aa09-33048405e723

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
- posted_at: `2026-11-09T23:31:56.6517670+00:00`

## Data

```json
{
  "end_line": 1976,
  "entity_kind": "method",
  "parent": "DurationField",
  "start_line": 1975,
  "symbol": "DurationField.get_db_prep_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1975,"selector":"L1975-L1976","symbol":"DurationField.get_db_prep_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DurationField.get_db_prep_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1976,
    "entity_kind": "method",
    "parent": "DurationField",
    "start_line": 1975,
    "symbol": "DurationField.get_db_prep_value"
  },
  "id": "37565bb0-3a57-4d61-aa09-33048405e723",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.6517670+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1975,
        "selector": "L1975-L1976",
        "symbol": "DurationField.get_db_prep_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "79f4c3b8-9e16-47ec-9b9a-5c208f411298",
  "subject_name": "django/db/models/fields/__init__::DurationField.get_db_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_prep_value(self, value, connection, prepared=False)"
}
```
