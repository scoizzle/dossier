# Fact a5a4a8a8

Store id: 6e403537-2018-4f29-861d-08e4854a0c7e

## Text

```text
def get_order_by(self)
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
- posted_at: `2026-11-09T23:44:57.4644000+00:00`

## Data

```json
{
  "end_line": 557,
  "entity_kind": "method",
  "parent": "SQLCompiler",
  "start_line": 498,
  "symbol": "SQLCompiler.get_order_by"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":498,"selector":"L498-L557","symbol":"SQLCompiler.get_order_by"}`

## Items

```json
[
  {
    "text": "Return a list of 2-tuples of the form (expr, (sql, params, is_ref)) for the ORDER BY clause.",
    "locator": {
      "line": 499
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler.get_order_by](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 557,
    "entity_kind": "method",
    "parent": "SQLCompiler",
    "start_line": 498,
    "symbol": "SQLCompiler.get_order_by"
  },
  "id": "6e403537-2018-4f29-861d-08e4854a0c7e",
  "items": [
    {
      "locator": {
        "line": 499
      },
      "text": "Return a list of 2-tuples of the form (expr, (sql, params, is_ref)) for the ORDER BY clause."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:57.4644000+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 498,
        "selector": "L498-L557",
        "symbol": "SQLCompiler.get_order_by"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "8d96a181-7fd1-46d3-8df5-4f7fcfac0f6f",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.get_order_by",
  "tags": [
    "entity:method"
  ],
  "text": "def get_order_by(self)"
}
```
