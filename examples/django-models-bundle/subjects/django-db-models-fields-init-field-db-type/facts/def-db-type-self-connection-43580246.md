# Fact 43580246

Store id: f1f8dbcf-34fd-4604-a12f-fb023483d5b1

## Text

```text
def db_type(self, connection)
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
- posted_at: `2026-11-09T22:39:42.3215970+00:00`

## Data

```json
{
  "end_line": 926,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 897,
  "symbol": "Field.db_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":897,"selector":"L897-L926","symbol":"Field.db_type"}`

## Items

```json
[
  {
    "text": "Return the database column data type for this field, for the provided connection.",
    "locator": {
      "line": 898
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.db_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 926,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 897,
    "symbol": "Field.db_type"
  },
  "id": "f1f8dbcf-34fd-4604-a12f-fb023483d5b1",
  "items": [
    {
      "locator": {
        "line": 898
      },
      "text": "Return the database column data type for this field, for the provided connection."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.3215970+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 897,
        "selector": "L897-L926",
        "symbol": "Field.db_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "b9949c62-f073-4258-831a-09083ac51777",
  "subject_name": "django/db/models/fields/__init__::Field.db_type",
  "tags": [
    "entity:method"
  ],
  "text": "def db_type(self, connection)"
}
```
