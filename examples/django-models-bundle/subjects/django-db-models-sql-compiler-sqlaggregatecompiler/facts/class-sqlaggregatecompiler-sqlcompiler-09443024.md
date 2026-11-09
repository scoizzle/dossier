# Fact 09443024

Store id: 522d5324-ebee-4ff5-acaf-fa45bf721273

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
- posted_at: `2026-11-09T23:44:57.7534800+00:00`

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
  "id": "522d5324-ebee-4ff5-acaf-fa45bf721273",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:57.7534800+00:00"
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
  "subject_id": "c0070bb6-854b-4a2c-92bc-6e99e3613292",
  "subject_name": "django/db/models/sql/compiler::SQLAggregateCompiler",
  "tags": [
    "entity:class"
  ],
  "text": "class SQLAggregateCompiler(SQLCompiler)"
}
```
