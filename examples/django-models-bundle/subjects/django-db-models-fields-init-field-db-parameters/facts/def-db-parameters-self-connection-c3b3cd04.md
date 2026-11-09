# Fact c3b3cd04

Store id: 502d192f-be8e-41af-87b3-4271fc47594b

## Text

```text
def db_parameters(self, connection)
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
- posted_at: `2026-11-09T23:31:56.4814670+00:00`

## Data

```json
{
  "end_line": 954,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 943,
  "symbol": "Field.db_parameters"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":943,"selector":"L943-L954","symbol":"Field.db_parameters"}`

## Items

```json
[
  {
    "text": "Extension of db_type(), providing a range of different return values (type, checks). This will look at db_type(), allowing custom model fields to override it.",
    "locator": {
      "line": 944
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.db_parameters](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 954,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 943,
    "symbol": "Field.db_parameters"
  },
  "id": "502d192f-be8e-41af-87b3-4271fc47594b",
  "items": [
    {
      "locator": {
        "line": 944
      },
      "text": "Extension of db_type(), providing a range of different return values (type, checks). This will look at db_type(), allowing custom model fields to override it."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.4814670+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 943,
        "selector": "L943-L954",
        "symbol": "Field.db_parameters"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "beb576cd-42c5-4b87-9e92-ce5dcd5a0a0b",
  "subject_name": "django/db/models/fields/__init__::Field.db_parameters",
  "tags": [
    "entity:method"
  ],
  "text": "def db_parameters(self, connection)"
}
```
