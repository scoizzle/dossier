# Fact 9927a4c8

Store id: c9434308-9ccb-4d80-8562-2652c747b5fc

## Text

```text
def _expr_refs_base_model(cls, expr, base_model)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class_method`, `decorator:classmethod`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:50.7165220+00:00`

## Data

```json
{
  "end_line": 2007,
  "entity_kind": "class_method",
  "parent": "SQLDeleteCompiler",
  "start_line": 1998,
  "symbol": "SQLDeleteCompiler._expr_refs_base_model"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1998,"selector":"L1998-L2007","symbol":"SQLDeleteCompiler._expr_refs_base_model"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLDeleteCompiler._expr_refs_base_model](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2007,
    "entity_kind": "class_method",
    "parent": "SQLDeleteCompiler",
    "start_line": 1998,
    "symbol": "SQLDeleteCompiler._expr_refs_base_model"
  },
  "id": "c9434308-9ccb-4d80-8562-2652c747b5fc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.7165220+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1998,
        "selector": "L1998-L2007",
        "symbol": "SQLDeleteCompiler._expr_refs_base_model"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "b67f544b-e019-461f-bc98-9debe27f9e07",
  "subject_name": "django/db/models/sql/compiler::SQLDeleteCompiler._expr_refs_base_model",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _expr_refs_base_model(cls, expr, base_model)"
}
```
