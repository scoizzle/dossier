# Fact f19b1937

Store id: 128f8ba5-0770-41e1-ac1b-963b1f91d121

## Text

```text
def get_select_for_update_of_arguments(self)
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
- posted_at: `2026-11-09T23:32:05.8329880+00:00`

## Data

```json
{
  "end_line": 1530,
  "entity_kind": "method",
  "parent": "SQLCompiler",
  "start_line": 1426,
  "symbol": "SQLCompiler.get_select_for_update_of_arguments"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1426,"selector":"L1426-L1530","symbol":"SQLCompiler.get_select_for_update_of_arguments"}`

## Items

```json
[
  {
    "text": "Return a quoted list of arguments for the SELECT FOR UPDATE OF part of the query.",
    "locator": {
      "line": 1427
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler.get_select_for_update_of_arguments](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1530,
    "entity_kind": "method",
    "parent": "SQLCompiler",
    "start_line": 1426,
    "symbol": "SQLCompiler.get_select_for_update_of_arguments"
  },
  "id": "128f8ba5-0770-41e1-ac1b-963b1f91d121",
  "items": [
    {
      "locator": {
        "line": 1427
      },
      "text": "Return a quoted list of arguments for the SELECT FOR UPDATE OF part of the query."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.8329880+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1426,
        "selector": "L1426-L1530",
        "symbol": "SQLCompiler.get_select_for_update_of_arguments"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "3fde7788-6e62-4e21-a73f-31f64915f47a",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.get_select_for_update_of_arguments",
  "tags": [
    "entity:method"
  ],
  "text": "def get_select_for_update_of_arguments(self)"
}
```
