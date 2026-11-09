# Fact db4aae6c

Store id: 1a461575-d955-4012-bc33-6087150dd48a

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
- posted_at: `2026-11-09T23:31:56.6398720+00:00`

## Data

```json
{
  "end_line": 1919,
  "entity_kind": "method",
  "parent": "DecimalField",
  "start_line": 1915,
  "symbol": "DecimalField.get_db_prep_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1915,"selector":"L1915-L1919","symbol":"DecimalField.get_db_prep_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DecimalField.get_db_prep_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1919,
    "entity_kind": "method",
    "parent": "DecimalField",
    "start_line": 1915,
    "symbol": "DecimalField.get_db_prep_value"
  },
  "id": "1a461575-d955-4012-bc33-6087150dd48a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.6398720+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1915,
        "selector": "L1915-L1919",
        "symbol": "DecimalField.get_db_prep_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "1c3269ce-b458-491a-b48a-f7aafcb418ed",
  "subject_name": "django/db/models/fields/__init__::DecimalField.get_db_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_prep_value(self, value, connection, prepared=False)"
}
```
