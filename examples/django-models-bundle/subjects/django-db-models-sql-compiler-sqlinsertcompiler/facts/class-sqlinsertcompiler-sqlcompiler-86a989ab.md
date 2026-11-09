# Fact 86a989ab

Store id: 8681b983-4911-425b-8da3-fc2a3305bf7b

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
- posted_at: `2026-11-09T22:39:50.6878460+00:00`

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
  "id": "8681b983-4911-425b-8da3-fc2a3305bf7b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.6878460+00:00"
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
  "subject_id": "0e54762b-14c4-4e00-83f7-9c76f48de959",
  "subject_name": "django/db/models/sql/compiler::SQLInsertCompiler",
  "tags": [
    "entity:class"
  ],
  "text": "class SQLInsertCompiler(SQLCompiler)"
}
```
