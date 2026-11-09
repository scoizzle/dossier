# Fact 2003bb8d

Store id: 5429e5a7-3577-42bb-acaa-af20ec4425c8

## Text

```text
def get_select(self, with_col_aliases=False)
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
- posted_at: `2026-11-09T23:32:05.7020290+00:00`

## Data

```json
{
  "end_line": 336,
  "entity_kind": "method",
  "parent": "SQLCompiler",
  "start_line": 240,
  "symbol": "SQLCompiler.get_select"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":240,"selector":"L240-L336","symbol":"SQLCompiler.get_select"}`

## Items

```json
[
  {
    "text": "Return three values: - a list of 3-tuples of (expression, (sql, params), alias) - a klass_info structure, - a dictionary of annotations",
    "locator": {
      "line": 241
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler.get_select](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 336,
    "entity_kind": "method",
    "parent": "SQLCompiler",
    "start_line": 240,
    "symbol": "SQLCompiler.get_select"
  },
  "id": "5429e5a7-3577-42bb-acaa-af20ec4425c8",
  "items": [
    {
      "locator": {
        "line": 241
      },
      "text": "Return three values: - a list of 3-tuples of (expression, (sql, params), alias) - a klass_info structure, - a dictionary of annotations"
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.7020290+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 240,
        "selector": "L240-L336",
        "symbol": "SQLCompiler.get_select"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "3613bdf4-524f-4080-9078-25315bb8d9e5",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.get_select",
  "tags": [
    "entity:method"
  ],
  "text": "def get_select(self, with_col_aliases=False)"
}
```
