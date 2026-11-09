# Fact 111ad01d

Store id: e5b9b660-28e1-4cc4-8df9-a7ea90074d5c

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
- posted_at: `2026-11-09T22:39:42.7334840+00:00`

## Data

```json
{
  "end_line": 2909,
  "entity_kind": "method",
  "parent": "AutoFieldMixin",
  "start_line": 2908,
  "symbol": "AutoFieldMixin.get_db_prep_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2908,"selector":"L2908-L2909","symbol":"AutoFieldMixin.get_db_prep_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::AutoFieldMixin.get_db_prep_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2909,
    "entity_kind": "method",
    "parent": "AutoFieldMixin",
    "start_line": 2908,
    "symbol": "AutoFieldMixin.get_db_prep_value"
  },
  "id": "e5b9b660-28e1-4cc4-8df9-a7ea90074d5c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.7334840+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2908,
        "selector": "L2908-L2909",
        "symbol": "AutoFieldMixin.get_db_prep_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "31f59f88-f47e-4bd2-9aef-3c7e2ac91a0a",
  "subject_name": "django/db/models/fields/__init__::AutoFieldMixin.get_db_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_prep_value(self, value, connection, prepared=False)"
}
```
