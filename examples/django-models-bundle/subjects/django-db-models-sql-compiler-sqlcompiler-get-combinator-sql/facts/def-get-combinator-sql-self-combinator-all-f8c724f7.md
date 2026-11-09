# Fact f8c724f7

Store id: 83509790-20ec-453f-8eb4-950d1091912a

## Text

```text
def get_combinator_sql(self, combinator, all)
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
- posted_at: `2026-11-09T23:32:05.7396580+00:00`

## Data

```json
{
  "end_line": 651,
  "entity_kind": "method",
  "parent": "SQLCompiler",
  "start_line": 600,
  "symbol": "SQLCompiler.get_combinator_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":600,"selector":"L600-L651","symbol":"SQLCompiler.get_combinator_sql"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler.get_combinator_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 651,
    "entity_kind": "method",
    "parent": "SQLCompiler",
    "start_line": 600,
    "symbol": "SQLCompiler.get_combinator_sql"
  },
  "id": "83509790-20ec-453f-8eb4-950d1091912a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.7396580+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 600,
        "selector": "L600-L651",
        "symbol": "SQLCompiler.get_combinator_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "37724854-dd78-49d7-ac44-ad6d249dae2d",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.get_combinator_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def get_combinator_sql(self, combinator, all)"
}
```
