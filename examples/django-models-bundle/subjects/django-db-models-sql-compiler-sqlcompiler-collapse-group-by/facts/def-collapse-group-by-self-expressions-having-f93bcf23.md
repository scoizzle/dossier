# Fact f93bcf23

Store id: 78c733de-dd5f-413d-a097-9237892a171d

## Text

```text
def collapse_group_by(self, expressions, having)
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
- posted_at: `2026-11-09T22:39:50.5784240+00:00`

## Data

```json
{
  "end_line": 231,
  "entity_kind": "method",
  "parent": "SQLCompiler",
  "start_line": 201,
  "symbol": "SQLCompiler.collapse_group_by"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":201,"selector":"L201-L231","symbol":"SQLCompiler.collapse_group_by"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler.collapse_group_by](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 231,
    "entity_kind": "method",
    "parent": "SQLCompiler",
    "start_line": 201,
    "symbol": "SQLCompiler.collapse_group_by"
  },
  "id": "78c733de-dd5f-413d-a097-9237892a171d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.5784240+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 201,
        "selector": "L201-L231",
        "symbol": "SQLCompiler.collapse_group_by"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "57fba03e-4a66-49e4-8cf7-d4c248bb75c1",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.collapse_group_by",
  "tags": [
    "entity:method"
  ],
  "text": "def collapse_group_by(self, expressions, having)"
}
```
