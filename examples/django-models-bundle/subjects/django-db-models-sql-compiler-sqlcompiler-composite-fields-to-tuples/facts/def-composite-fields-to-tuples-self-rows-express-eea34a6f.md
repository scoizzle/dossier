# Fact eea34a6f

Store id: e7934f7f-336f-4f0c-abbe-64492dd5460f

## Text

```text
def composite_fields_to_tuples(self, rows, expressions)
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
- posted_at: `2026-11-09T23:32:05.8888450+00:00`

## Data

```json
{
  "end_line": 1581,
  "entity_kind": "method",
  "parent": "SQLCompiler",
  "start_line": 1570,
  "symbol": "SQLCompiler.composite_fields_to_tuples"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1570,"selector":"L1570-L1581","symbol":"SQLCompiler.composite_fields_to_tuples"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler.composite_fields_to_tuples](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1581,
    "entity_kind": "method",
    "parent": "SQLCompiler",
    "start_line": 1570,
    "symbol": "SQLCompiler.composite_fields_to_tuples"
  },
  "id": "e7934f7f-336f-4f0c-abbe-64492dd5460f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.8888450+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1570,
        "selector": "L1570-L1581",
        "symbol": "SQLCompiler.composite_fields_to_tuples"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "a7fe2347-5409-4c8d-bbf7-6cd23082f152",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.composite_fields_to_tuples",
  "tags": [
    "entity:method"
  ],
  "text": "def composite_fields_to_tuples(self, rows, expressions)"
}
```
