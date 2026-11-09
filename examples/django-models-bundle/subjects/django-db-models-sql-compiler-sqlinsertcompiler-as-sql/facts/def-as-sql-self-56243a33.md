# Fact 56243a33

Store id: 054f27b0-5c63-4e0b-b499-2dfdf1f3778f

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
- posted_at: `2026-11-09T23:32:05.9776600+00:00`

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
  "id": "054f27b0-5c63-4e0b-b499-2dfdf1f3778f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.9776600+00:00"
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
  "subject_id": "2988fb2c-f51d-41c1-afb5-3dd380c977e7",
  "subject_name": "django/db/models/sql/compiler::SQLInsertCompiler.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self)"
}
```
