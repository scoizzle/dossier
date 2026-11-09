# Fact cfdcb3ca

Store id: 8141870e-7a43-4ba5-8fc7-a83f851631f5

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
- posted_at: `2026-11-09T23:32:05.8541700+00:00`

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
  "id": "8141870e-7a43-4ba5-8fc7-a83f851631f5",
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
    "posted_at": "2026-11-09T23:32:05.8541700+00:00"
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
  "subject_id": "1d1eb445-b133-427b-a3a5-7649d2674cdc",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.get_select_for_update_of_arguments._get_field_choices",
  "tags": [
    "entity:function"
  ],
  "text": "def _get_field_choices()"
}
```
