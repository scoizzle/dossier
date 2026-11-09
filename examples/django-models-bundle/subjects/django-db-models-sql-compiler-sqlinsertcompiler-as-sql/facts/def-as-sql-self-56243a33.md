# Fact 56243a33

Store id: 4563ab23-5af6-453d-badb-b97cb7008ed9

## Text

```text
def as_sql(self)
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
- posted_at: `2026-11-09T22:39:50.7029400+00:00`

## Data

```json
{
  "end_line": 1941,
  "entity_kind": "method",
  "parent": "SQLInsertCompiler",
  "start_line": 1819,
  "symbol": "SQLInsertCompiler.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1819,"selector":"L1819-L1941","symbol":"SQLInsertCompiler.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLInsertCompiler.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1941,
    "entity_kind": "method",
    "parent": "SQLInsertCompiler",
    "start_line": 1819,
    "symbol": "SQLInsertCompiler.as_sql"
  },
  "id": "4563ab23-5af6-453d-badb-b97cb7008ed9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.7029400+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1819,
        "selector": "L1819-L1941",
        "symbol": "SQLInsertCompiler.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "451510f2-cd61-49cb-9650-52b4c30cdd3e",
  "subject_name": "django/db/models/sql/compiler::SQLInsertCompiler.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self)"
}
```
