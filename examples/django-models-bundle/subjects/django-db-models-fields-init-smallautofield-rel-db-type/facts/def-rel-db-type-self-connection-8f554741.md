# Fact 8f554741

Store id: 798aa2ee-697a-46f0-b247-eae5a53f79b9

## Text

```text
def rel_db_type(self, connection)
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
- posted_at: `2026-11-09T23:31:56.9359670+00:00`

## Data

```json
{
  "end_line": 2984,
  "entity_kind": "method",
  "parent": "SmallAutoField",
  "start_line": 2983,
  "symbol": "SmallAutoField.rel_db_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2983,"selector":"L2983-L2984","symbol":"SmallAutoField.rel_db_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::SmallAutoField.rel_db_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2984,
    "entity_kind": "method",
    "parent": "SmallAutoField",
    "start_line": 2983,
    "symbol": "SmallAutoField.rel_db_type"
  },
  "id": "798aa2ee-697a-46f0-b247-eae5a53f79b9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.9359670+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2983,
        "selector": "L2983-L2984",
        "symbol": "SmallAutoField.rel_db_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "0caf8223-3f64-4083-902e-372aa9e3d635",
  "subject_name": "django/db/models/fields/__init__::SmallAutoField.rel_db_type",
  "tags": [
    "entity:method"
  ],
  "text": "def rel_db_type(self, connection)"
}
```
