# Fact 03f2405e

Store id: a9e4b004-1c90-4224-8457-69a242bb77fc

## Text

```text
def get_group_by(self, select, order_by)
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
- posted_at: `2026-11-09T22:39:50.5675070+00:00`

## Data

```json
{
  "end_line": 199,
  "entity_kind": "method",
  "parent": "SQLCompiler",
  "start_line": 98,
  "symbol": "SQLCompiler.get_group_by"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":98,"selector":"L98-L199","symbol":"SQLCompiler.get_group_by"}`

## Items

```json
[
  {
    "text": "Return a list of 2-tuples of form (sql, params).",
    "locator": {
      "line": 99
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler.get_group_by](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 199,
    "entity_kind": "method",
    "parent": "SQLCompiler",
    "start_line": 98,
    "symbol": "SQLCompiler.get_group_by"
  },
  "id": "a9e4b004-1c90-4224-8457-69a242bb77fc",
  "items": [
    {
      "locator": {
        "line": 99
      },
      "text": "Return a list of 2-tuples of form (sql, params)."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.5675070+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 98,
        "selector": "L98-L199",
        "symbol": "SQLCompiler.get_group_by"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "7c88fd12-341e-42ff-83e4-5c5441f2440f",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.get_group_by",
  "tags": [
    "entity:method"
  ],
  "text": "def get_group_by(self, select, order_by)"
}
```
