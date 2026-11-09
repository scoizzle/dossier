# Fact 8fe7c516

Store id: 8e30261a-097f-4bda-9866-a58ff6488761

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
- posted_at: `2026-11-09T23:31:56.8634720+00:00`

## Data

```json
{
  "end_line": 2798,
  "entity_kind": "method",
  "parent": "BinaryField",
  "start_line": 2794,
  "symbol": "BinaryField.get_db_prep_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2794,"selector":"L2794-L2798","symbol":"BinaryField.get_db_prep_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::BinaryField.get_db_prep_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2798,
    "entity_kind": "method",
    "parent": "BinaryField",
    "start_line": 2794,
    "symbol": "BinaryField.get_db_prep_value"
  },
  "id": "8e30261a-097f-4bda-9866-a58ff6488761",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.8634720+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2794,
        "selector": "L2794-L2798",
        "symbol": "BinaryField.get_db_prep_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "2c9b237a-cd32-482d-8f91-af8e7c7eeb5e",
  "subject_name": "django/db/models/fields/__init__::BinaryField.get_db_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_prep_value(self, value, connection, prepared=False)"
}
```
