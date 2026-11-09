# Fact 15ead89e

Store id: 34cd0fa1-4b78-4776-9036-fb1296f6379a

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
- posted_at: `2026-11-09T23:31:56.4776930+00:00`

## Data

```json
{
  "end_line": 934,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 928,
  "symbol": "Field.rel_db_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":928,"selector":"L928-L934","symbol":"Field.rel_db_type"}`

## Items

```json
[
  {
    "text": "Return the data type that a related field pointing to this field should use. For example, this method is called by ForeignKey and OneToOneField to determine its data type.",
    "locator": {
      "line": 929
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.rel_db_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 934,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 928,
    "symbol": "Field.rel_db_type"
  },
  "id": "34cd0fa1-4b78-4776-9036-fb1296f6379a",
  "items": [
    {
      "locator": {
        "line": 929
      },
      "text": "Return the data type that a related field pointing to this field should use. For example, this method is called by ForeignKey and OneToOneField to determine its data type."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.4776930+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 928,
        "selector": "L928-L934",
        "symbol": "Field.rel_db_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "b30dfcea-41f6-48f1-954b-84b9600f30c9",
  "subject_name": "django/db/models/fields/__init__::Field.rel_db_type",
  "tags": [
    "entity:method"
  ],
  "text": "def rel_db_type(self, connection)"
}
```
