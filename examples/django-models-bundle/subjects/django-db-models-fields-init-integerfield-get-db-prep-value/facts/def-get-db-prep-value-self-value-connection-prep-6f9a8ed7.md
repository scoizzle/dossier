# Fact 6f9a8ed7

Store id: cad588a0-77cb-4610-8554-688788a2eb25

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
- posted_at: `2026-11-09T23:31:56.7003950+00:00`

## Data

```json
{
  "end_line": 2215,
  "entity_kind": "method",
  "parent": "IntegerField",
  "start_line": 2213,
  "symbol": "IntegerField.get_db_prep_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2213,"selector":"L2213-L2215","symbol":"IntegerField.get_db_prep_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::IntegerField.get_db_prep_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2215,
    "entity_kind": "method",
    "parent": "IntegerField",
    "start_line": 2213,
    "symbol": "IntegerField.get_db_prep_value"
  },
  "id": "cad588a0-77cb-4610-8554-688788a2eb25",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.7003950+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2213,
        "selector": "L2213-L2215",
        "symbol": "IntegerField.get_db_prep_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "8911af3a-5fb2-456d-82ba-6763152ea047",
  "subject_name": "django/db/models/fields/__init__::IntegerField.get_db_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_prep_value(self, value, connection, prepared=False)"
}
```
