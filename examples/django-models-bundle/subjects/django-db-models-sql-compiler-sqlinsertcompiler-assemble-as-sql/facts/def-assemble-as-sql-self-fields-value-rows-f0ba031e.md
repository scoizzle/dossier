# Fact f0ba031e

Store id: a19cca1e-2be8-43a5-979a-7205101d1ef6

## Text

```text
def assemble_as_sql(self, fields, value_rows)
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
- posted_at: `2026-11-09T23:44:57.6702780+00:00`

## Data

```json
{
  "end_line": 1817,
  "entity_kind": "method",
  "parent": "SQLInsertCompiler",
  "start_line": 1776,
  "symbol": "SQLInsertCompiler.assemble_as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1776,"selector":"L1776-L1817","symbol":"SQLInsertCompiler.assemble_as_sql"}`

## Items

```json
[
  {
    "text": "Take a sequence of N fields and a sequence of M rows of values, and generate placeholder SQL and parameters for each field and value. Return a pair containing: * a sequence of M rows of N SQL placeholder strings, and * a sequence of M rows of corresponding parameter values.",
    "locator": {
      "line": 1777
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLInsertCompiler.assemble_as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1817,
    "entity_kind": "method",
    "parent": "SQLInsertCompiler",
    "start_line": 1776,
    "symbol": "SQLInsertCompiler.assemble_as_sql"
  },
  "id": "a19cca1e-2be8-43a5-979a-7205101d1ef6",
  "items": [
    {
      "locator": {
        "line": 1777
      },
      "text": "Take a sequence of N fields and a sequence of M rows of values, and generate placeholder SQL and parameters for each field and value. Return a pair containing: * a sequence of M rows of N SQL placeholder strings, and * a sequence of M rows of corresponding parameter values."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:57.6702780+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1776,
        "selector": "L1776-L1817",
        "symbol": "SQLInsertCompiler.assemble_as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "8cb3e403-da3b-48ea-b6ae-bf466af41f18",
  "subject_name": "django/db/models/sql/compiler::SQLInsertCompiler.assemble_as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def assemble_as_sql(self, fields, value_rows)"
}
```
