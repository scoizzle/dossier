# Fact 3ad13a54

Store id: 3dcc5e31-d785-40ca-ae57-8b5625f28b03

## Text

```text
def pre_save_val(self, field, obj)
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
- posted_at: `2026-11-09T23:44:57.6649550+00:00`

## Data

```json
{
  "end_line": 1774,
  "entity_kind": "method",
  "parent": "SQLInsertCompiler",
  "start_line": 1767,
  "symbol": "SQLInsertCompiler.pre_save_val"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1767,"selector":"L1767-L1774","symbol":"SQLInsertCompiler.pre_save_val"}`

## Items

```json
[
  {
    "text": "Get the given field's value off the given obj. pre_save() is used for things like auto_now on DateTimeField. Skip it if this is a raw query.",
    "locator": {
      "line": 1768
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLInsertCompiler.pre_save_val](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1774,
    "entity_kind": "method",
    "parent": "SQLInsertCompiler",
    "start_line": 1767,
    "symbol": "SQLInsertCompiler.pre_save_val"
  },
  "id": "3dcc5e31-d785-40ca-ae57-8b5625f28b03",
  "items": [
    {
      "locator": {
        "line": 1768
      },
      "text": "Get the given field's value off the given obj. pre_save() is used for things like auto_now on DateTimeField. Skip it if this is a raw query."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:57.6649550+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1767,
        "selector": "L1767-L1774",
        "symbol": "SQLInsertCompiler.pre_save_val"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "9ce9d0a0-a85f-48f1-9cfd-e2d6040bf96f",
  "subject_name": "django/db/models/sql/compiler::SQLInsertCompiler.pre_save_val",
  "tags": [
    "entity:method"
  ],
  "text": "def pre_save_val(self, field, obj)"
}
```
