# Fact d9ab4203

Store id: e9671333-ab21-4f70-a722-22dcca339720

## Text

```text
def prepare_value(self, field, value)
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
- posted_at: `2026-11-09T23:44:57.6603060+00:00`

## Data

```json
{
  "end_line": 1765,
  "entity_kind": "method",
  "parent": "SQLInsertCompiler",
  "start_line": 1738,
  "symbol": "SQLInsertCompiler.prepare_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1738,"selector":"L1738-L1765","symbol":"SQLInsertCompiler.prepare_value"}`

## Items

```json
[
  {
    "text": "Prepare a value to be used in a query by resolving it if it is an expression and otherwise calling the field's get_db_prep_save().",
    "locator": {
      "line": 1739
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLInsertCompiler.prepare_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1765,
    "entity_kind": "method",
    "parent": "SQLInsertCompiler",
    "start_line": 1738,
    "symbol": "SQLInsertCompiler.prepare_value"
  },
  "id": "e9671333-ab21-4f70-a722-22dcca339720",
  "items": [
    {
      "locator": {
        "line": 1739
      },
      "text": "Prepare a value to be used in a query by resolving it if it is an expression and otherwise calling the field's get_db_prep_save()."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:57.6603060+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1738,
        "selector": "L1738-L1765",
        "symbol": "SQLInsertCompiler.prepare_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "6e170d5a-d837-41de-b1a1-22f8ed325973",
  "subject_name": "django/db/models/sql/compiler::SQLInsertCompiler.prepare_value",
  "tags": [
    "entity:method"
  ],
  "text": "def prepare_value(self, field, value)"
}
```
