# Fact 64e4ed2e

Store id: 6ac5ce3c-2fdc-4b93-8664-a7d24be70f74

## Text

```text
def _get_first_selected_col_from_model(klass_info)
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
- posted_at: `2026-11-09T23:32:05.8439000+00:00`

## Data

```json
{
  "end_line": 1462,
  "entity_kind": "function",
  "parent": "SQLCompiler.get_select_for_update_of_arguments",
  "start_line": 1451,
  "symbol": "SQLCompiler.get_select_for_update_of_arguments._get_first_selected_col_from_model"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1451,"selector":"L1451-L1462","symbol":"SQLCompiler.get_select_for_update_of_arguments._get_first_selected_col_from_model"}`

## Items

```json
[
  {
    "text": "Find the first selected column from a model. If it doesn't exist, don't lock a model.",
    "locator": {
      "line": 1452
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler.get_select_for_update_of_arguments._get_first_selected_col_from_model](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1462,
    "entity_kind": "function",
    "parent": "SQLCompiler.get_select_for_update_of_arguments",
    "start_line": 1451,
    "symbol": "SQLCompiler.get_select_for_update_of_arguments._get_first_selected_col_from_model"
  },
  "id": "6ac5ce3c-2fdc-4b93-8664-a7d24be70f74",
  "items": [
    {
      "locator": {
        "line": 1452
      },
      "text": "Find the first selected column from a model. If it doesn't exist, don't lock a model."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.8439000+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1451,
        "selector": "L1451-L1462",
        "symbol": "SQLCompiler.get_select_for_update_of_arguments._get_first_selected_col_from_model"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "5f1972d7-0fba-498d-9632-11523abc16da",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.get_select_for_update_of_arguments._get_first_selected_col_from_model",
  "tags": [
    "entity:function"
  ],
  "text": "def _get_first_selected_col_from_model(klass_info)"
}
```
