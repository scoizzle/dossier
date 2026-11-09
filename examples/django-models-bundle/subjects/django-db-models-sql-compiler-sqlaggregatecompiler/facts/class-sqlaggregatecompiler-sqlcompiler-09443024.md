# Fact 09443024

Store id: e192cfde-44f5-4eed-b362-0537f9cd960a

## Text

```text
class SQLAggregateCompiler(SQLCompiler)
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
- posted_at: `2026-11-09T22:39:50.7433240+00:00`

## Data

```json
{
  "end_line": 2273,
  "entity_kind": "class",
  "parent": "compiler",
  "start_line": 2251,
  "symbol": "SQLAggregateCompiler"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2251,"selector":"L2251-L2273","symbol":"SQLAggregateCompiler"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLAggregateCompiler](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2273,
    "entity_kind": "class",
    "parent": "compiler",
    "start_line": 2251,
    "symbol": "SQLAggregateCompiler"
  },
  "id": "e192cfde-44f5-4eed-b362-0537f9cd960a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.7433240+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2251,
        "selector": "L2251-L2273",
        "symbol": "SQLAggregateCompiler"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "e5466d8a-2829-4339-87f6-1b9c81ba212a",
  "subject_name": "django/db/models/sql/compiler::SQLAggregateCompiler",
  "tags": [
    "entity:class"
  ],
  "text": "class SQLAggregateCompiler(SQLCompiler)"
}
```
