# Fact 6bb0e69e

Store id: cd04d7bd-183c-4b64-a5ab-f4316dad1030

## Text

```text
def get_extra_select(self, order_by, select)
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
- posted_at: `2026-11-09T22:39:50.5938910+00:00`

## Data

```json
{
  "end_line": 567,
  "entity_kind": "method",
  "parent": "SQLCompiler",
  "start_line": 559,
  "symbol": "SQLCompiler.get_extra_select"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":559,"selector":"L559-L567","symbol":"SQLCompiler.get_extra_select"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler.get_extra_select](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 567,
    "entity_kind": "method",
    "parent": "SQLCompiler",
    "start_line": 559,
    "symbol": "SQLCompiler.get_extra_select"
  },
  "id": "cd04d7bd-183c-4b64-a5ab-f4316dad1030",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.5938910+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 559,
        "selector": "L559-L567",
        "symbol": "SQLCompiler.get_extra_select"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "82ce5418-8d36-4bb1-9dd0-4f2364af2c91",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.get_extra_select",
  "tags": [
    "entity:method"
  ],
  "text": "def get_extra_select(self, order_by, select)"
}
```
