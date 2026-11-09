# Fact eea34a6f

Store id: 05fc9ac9-4708-4b65-93ac-a79298e9fa24

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
- posted_at: `2026-11-09T22:39:50.6740230+00:00`

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
  "id": "05fc9ac9-4708-4b65-93ac-a79298e9fa24",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.6740230+00:00"
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
  "subject_id": "6e14a15b-0aaf-4f62-a58f-d2ac25cbc895",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.composite_fields_to_tuples",
  "tags": [
    "entity:method"
  ],
  "text": "def composite_fields_to_tuples(self, rows, expressions)"
}
```
