# Fact de466625

Store id: 53402fc8-08ff-4d1e-a28e-438f802e2332

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
- posted_at: `2026-11-09T23:31:56.5176030+00:00`

## Data

```json
{
  "end_line": 1045,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 1036,
  "symbol": "Field.get_db_prep_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1036,"selector":"L1036-L1045","symbol":"Field.get_db_prep_value"}`

## Items

```json
[
  {
    "text": "Return field's value prepared for interacting with the database backend.",
    "locator": {
      "line": 1037
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.get_db_prep_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1045,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 1036,
    "symbol": "Field.get_db_prep_value"
  },
  "id": "53402fc8-08ff-4d1e-a28e-438f802e2332",
  "items": [
    {
      "locator": {
        "line": 1037
      },
      "text": "Return field's value prepared for interacting with the database backend."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.5176030+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1036,
        "selector": "L1036-L1045",
        "symbol": "Field.get_db_prep_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "48137b4d-9d12-48f9-b9be-077641ccf0b7",
  "subject_name": "django/db/models/fields/__init__::Field.get_db_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_prep_value(self, value, connection, prepared=False)"
}
```
