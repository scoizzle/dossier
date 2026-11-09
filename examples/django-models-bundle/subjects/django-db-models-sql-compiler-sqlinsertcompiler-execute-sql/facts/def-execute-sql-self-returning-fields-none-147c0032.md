# Fact 147c0032

Store id: 6f9311fb-7b5a-43e7-af11-e073d58c32ef

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
- posted_at: `2026-11-09T23:32:05.9854150+00:00`

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
  "id": "6f9311fb-7b5a-43e7-af11-e073d58c32ef",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.9854150+00:00"
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
  "subject_id": "6e58068d-a2ca-41a1-a3a2-59f2319173a9",
  "subject_name": "django/db/models/sql/compiler::SQLInsertCompiler.execute_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def execute_sql(self, returning_fields=None)"
}
```
