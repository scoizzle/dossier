# Fact 111ad01d

Store id: 6caec15a-3da1-49d9-8c06-632059e0e5bd

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
- posted_at: `2026-11-09T23:31:56.9015340+00:00`

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
  "id": "6caec15a-3da1-49d9-8c06-632059e0e5bd",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.9015340+00:00"
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
  "subject_id": "62afe0c3-1b48-48f5-9b13-f38fb27341db",
  "subject_name": "django/db/models/fields/__init__::AutoFieldMixin.get_db_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_prep_value(self, value, connection, prepared=False)"
}
```
