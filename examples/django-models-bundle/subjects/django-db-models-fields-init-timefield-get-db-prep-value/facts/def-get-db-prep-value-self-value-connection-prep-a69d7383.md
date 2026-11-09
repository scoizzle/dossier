# Fact a69d7383

Store id: c79541cc-4e55-438f-bc3d-b5e18bd60fc8

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
- posted_at: `2026-11-09T22:39:42.6733050+00:00`

## Data

```json
{
  "end_line": 2704,
  "entity_kind": "method",
  "parent": "TimeField",
  "start_line": 2700,
  "symbol": "TimeField.get_db_prep_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2700,"selector":"L2700-L2704","symbol":"TimeField.get_db_prep_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::TimeField.get_db_prep_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2704,
    "entity_kind": "method",
    "parent": "TimeField",
    "start_line": 2700,
    "symbol": "TimeField.get_db_prep_value"
  },
  "id": "c79541cc-4e55-438f-bc3d-b5e18bd60fc8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.6733050+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2700,
        "selector": "L2700-L2704",
        "symbol": "TimeField.get_db_prep_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "9310fbd3-a6a3-4f40-9393-af3bbece2436",
  "subject_name": "django/db/models/fields/__init__::TimeField.get_db_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_prep_value(self, value, connection, prepared=False)"
}
```
