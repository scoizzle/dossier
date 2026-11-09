# Fact 86a989ab

Store id: 47ce0ef1-e0a4-4eb7-8102-f262cd7a2c5a

## Text

```text
class SQLInsertCompiler(SQLCompiler)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:05.9384320+00:00`

## Data

```json
{
  "end_line": 1988,
  "entity_kind": "class",
  "parent": "compiler",
  "start_line": 1701,
  "symbol": "SQLInsertCompiler"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1701,"selector":"L1701-L1988","symbol":"SQLInsertCompiler"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLInsertCompiler](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1988,
    "entity_kind": "class",
    "parent": "compiler",
    "start_line": 1701,
    "symbol": "SQLInsertCompiler"
  },
  "id": "47ce0ef1-e0a4-4eb7-8102-f262cd7a2c5a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.9384320+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1701,
        "selector": "L1701-L1988",
        "symbol": "SQLInsertCompiler"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "b8470818-59b1-41d5-8d41-a3a1c5e7bf67",
  "subject_name": "django/db/models/sql/compiler::SQLInsertCompiler",
  "tags": [
    "entity:class"
  ],
  "text": "class SQLInsertCompiler(SQLCompiler)"
}
```
