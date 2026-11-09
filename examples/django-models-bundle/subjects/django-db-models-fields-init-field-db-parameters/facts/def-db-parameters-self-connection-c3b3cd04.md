# Fact c3b3cd04

Store id: 3202c387-db47-4620-86ad-31d5d304c78e

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
- posted_at: `2026-11-09T22:39:42.3261880+00:00`

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
  "id": "3202c387-db47-4620-86ad-31d5d304c78e",
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
    "posted_at": "2026-11-09T22:39:42.3261880+00:00"
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
  "subject_id": "6032aab0-a571-4d70-b2aa-dd8d20b3a91f",
  "subject_name": "django/db/models/fields/__init__::Field.db_parameters",
  "tags": [
    "entity:method"
  ],
  "text": "def db_parameters(self, connection)"
}
```
