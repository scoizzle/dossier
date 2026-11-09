# Fact 1f04e378

Store id: f7ff5b8c-00a4-4d2d-93cd-e4e693504c10

## Text

```text
def _get_parent_klass_info(klass_info)
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
- posted_at: `2026-11-09T23:32:05.8369060+00:00`

## Data

```json
{
  "end_line": 1449,
  "entity_kind": "function",
  "parent": "SQLCompiler.get_select_for_update_of_arguments",
  "start_line": 1432,
  "symbol": "SQLCompiler.get_select_for_update_of_arguments._get_parent_klass_info"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1432,"selector":"L1432-L1449","symbol":"SQLCompiler.get_select_for_update_of_arguments._get_parent_klass_info"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler.get_select_for_update_of_arguments._get_parent_klass_info](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1449,
    "entity_kind": "function",
    "parent": "SQLCompiler.get_select_for_update_of_arguments",
    "start_line": 1432,
    "symbol": "SQLCompiler.get_select_for_update_of_arguments._get_parent_klass_info"
  },
  "id": "f7ff5b8c-00a4-4d2d-93cd-e4e693504c10",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.8369060+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1432,
        "selector": "L1432-L1449",
        "symbol": "SQLCompiler.get_select_for_update_of_arguments._get_parent_klass_info"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "b5f7ccb5-fd59-4069-ab37-1fd130c7f78e",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.get_select_for_update_of_arguments._get_parent_klass_info",
  "tags": [
    "entity:function"
  ],
  "text": "def _get_parent_klass_info(klass_info)"
}
```
