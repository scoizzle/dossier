# Fact 457ef9ff

Store id: 5c7289dc-c363-4cdb-8e49-a50e25e93af6

## Text

```text
def cast_db_type(self, connection)
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
- posted_at: `2026-11-09T23:44:50.0193710+00:00`

## Data

```json
{
  "end_line": 941,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 936,
  "symbol": "Field.cast_db_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":936,"selector":"L936-L941","symbol":"Field.cast_db_type"}`

## Items

```json
[
  {
    "text": "Return the data type to use in the Cast() function.",
    "locator": {
      "line": 937
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.cast_db_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 941,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 936,
    "symbol": "Field.cast_db_type"
  },
  "id": "5c7289dc-c363-4cdb-8e49-a50e25e93af6",
  "items": [
    {
      "locator": {
        "line": 937
      },
      "text": "Return the data type to use in the Cast() function."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.0193710+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 936,
        "selector": "L936-L941",
        "symbol": "Field.cast_db_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "3355a0c4-08f8-4614-8c8b-e86ad8bc5606",
  "subject_name": "django/db/models/fields/__init__::Field.cast_db_type",
  "tags": [
    "entity:method"
  ],
  "text": "def cast_db_type(self, connection)"
}
```
