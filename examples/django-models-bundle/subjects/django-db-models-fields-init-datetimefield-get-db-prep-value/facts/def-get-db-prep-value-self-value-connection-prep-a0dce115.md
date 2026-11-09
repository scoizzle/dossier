# Fact a0dce115

Store id: b6e7979f-acab-4fd0-83c4-94be9a1db4f8

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
- posted_at: `2026-11-09T23:31:56.6007410+00:00`

## Data

```json
{
  "end_line": 1725,
  "entity_kind": "method",
  "parent": "DateTimeField",
  "start_line": 1721,
  "symbol": "DateTimeField.get_db_prep_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1721,"selector":"L1721-L1725","symbol":"DateTimeField.get_db_prep_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DateTimeField.get_db_prep_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1725,
    "entity_kind": "method",
    "parent": "DateTimeField",
    "start_line": 1721,
    "symbol": "DateTimeField.get_db_prep_value"
  },
  "id": "b6e7979f-acab-4fd0-83c4-94be9a1db4f8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.6007410+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1721,
        "selector": "L1721-L1725",
        "symbol": "DateTimeField.get_db_prep_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "1ffad754-157e-42bc-afb4-67ebe99afe2d",
  "subject_name": "django/db/models/fields/__init__::DateTimeField.get_db_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_prep_value(self, value, connection, prepared=False)"
}
```
