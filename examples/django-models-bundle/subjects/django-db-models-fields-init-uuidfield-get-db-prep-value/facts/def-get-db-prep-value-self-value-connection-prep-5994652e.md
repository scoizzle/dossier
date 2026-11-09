# Fact 5994652e

Store id: 9e745a6a-00fe-43f0-9e55-109334862818

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
- posted_at: `2026-11-09T23:44:50.3057290+00:00`

## Data

```json
{
  "end_line": 2850,
  "entity_kind": "method",
  "parent": "UUIDField",
  "start_line": 2842,
  "symbol": "UUIDField.get_db_prep_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2842,"selector":"L2842-L2850","symbol":"UUIDField.get_db_prep_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::UUIDField.get_db_prep_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2850,
    "entity_kind": "method",
    "parent": "UUIDField",
    "start_line": 2842,
    "symbol": "UUIDField.get_db_prep_value"
  },
  "id": "9e745a6a-00fe-43f0-9e55-109334862818",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.3057290+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2842,
        "selector": "L2842-L2850",
        "symbol": "UUIDField.get_db_prep_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "7e58114e-2546-4a7b-b66c-16aa7396ae86",
  "subject_name": "django/db/models/fields/__init__::UUIDField.get_db_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_prep_value(self, value, connection, prepared=False)"
}
```
