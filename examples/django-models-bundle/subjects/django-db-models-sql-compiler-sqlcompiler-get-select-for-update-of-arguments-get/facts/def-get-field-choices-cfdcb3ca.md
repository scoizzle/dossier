# Fact cfdcb3ca

Store id: 4c055dc4-4c1e-40c7-9b6b-f45fe9670912

## Text

```text
def _get_field_choices()
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:50.6629820+00:00`

## Data

```json
{
  "end_line": 1485,
  "entity_kind": "function",
  "parent": "SQLCompiler.get_select_for_update_of_arguments",
  "start_line": 1464,
  "symbol": "SQLCompiler.get_select_for_update_of_arguments._get_field_choices"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1464,"selector":"L1464-L1485","symbol":"SQLCompiler.get_select_for_update_of_arguments._get_field_choices"}`

## Items

```json
[
  {
    "text": "Yield all allowed field paths in breadth-first search order.",
    "locator": {
      "line": 1465
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler.get_select_for_update_of_arguments._get_field_choices](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1485,
    "entity_kind": "function",
    "parent": "SQLCompiler.get_select_for_update_of_arguments",
    "start_line": 1464,
    "symbol": "SQLCompiler.get_select_for_update_of_arguments._get_field_choices"
  },
  "id": "4c055dc4-4c1e-40c7-9b6b-f45fe9670912",
  "items": [
    {
      "locator": {
        "line": 1465
      },
      "text": "Yield all allowed field paths in breadth-first search order."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.6629820+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1464,
        "selector": "L1464-L1485",
        "symbol": "SQLCompiler.get_select_for_update_of_arguments._get_field_choices"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "af9fc537-8022-4d4a-bda5-30b0245b44d8",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.get_select_for_update_of_arguments._get_field_choices",
  "tags": [
    "entity:function"
  ],
  "text": "def _get_field_choices()"
}
```
