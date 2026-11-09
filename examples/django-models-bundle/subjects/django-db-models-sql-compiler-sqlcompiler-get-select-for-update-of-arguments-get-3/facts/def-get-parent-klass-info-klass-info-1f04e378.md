# Fact 1f04e378

Store id: 1b187c25-38cb-4f3a-9cb1-fe4061f4d0d9

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
- posted_at: `2026-11-09T23:44:57.5839190+00:00`

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
  "id": "1b187c25-38cb-4f3a-9cb1-fe4061f4d0d9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:57.5839190+00:00"
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
  "subject_id": "9e19d113-fe95-4391-921b-31f5d6f4601b",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.get_select_for_update_of_arguments._get_parent_klass_info",
  "tags": [
    "entity:function"
  ],
  "text": "def _get_parent_klass_info(klass_info)"
}
```
