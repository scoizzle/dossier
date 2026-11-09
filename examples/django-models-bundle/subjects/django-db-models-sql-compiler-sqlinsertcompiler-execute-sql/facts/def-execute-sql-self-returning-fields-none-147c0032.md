# Fact 147c0032

Store id: da05c5c7-3531-44aa-96b6-49503394ff77

## Text

```text
def execute_sql(self, returning_fields=None)
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
- posted_at: `2026-11-09T23:44:57.6839310+00:00`

## Data

```json
{
  "end_line": 1988,
  "entity_kind": "method",
  "parent": "SQLInsertCompiler",
  "start_line": 1943,
  "symbol": "SQLInsertCompiler.execute_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1943,"selector":"L1943-L1988","symbol":"SQLInsertCompiler.execute_sql"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLInsertCompiler.execute_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1988,
    "entity_kind": "method",
    "parent": "SQLInsertCompiler",
    "start_line": 1943,
    "symbol": "SQLInsertCompiler.execute_sql"
  },
  "id": "da05c5c7-3531-44aa-96b6-49503394ff77",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:57.6839310+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1943,
        "selector": "L1943-L1988",
        "symbol": "SQLInsertCompiler.execute_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "4849722f-929b-44b6-aedf-65d6c900c023",
  "subject_name": "django/db/models/sql/compiler::SQLInsertCompiler.execute_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def execute_sql(self, returning_fields=None)"
}
```
