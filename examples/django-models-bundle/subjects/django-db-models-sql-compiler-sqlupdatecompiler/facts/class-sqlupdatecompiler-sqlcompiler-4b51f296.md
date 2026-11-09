# Fact 4b51f296

Store id: c7e69306-ce2a-49ff-a4fa-c9cb11ffa0aa

## Text

```text
class SQLUpdateCompiler(SQLCompiler)
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
- posted_at: `2026-11-09T23:44:57.7205000+00:00`

## Data

```json
{
  "end_line": 2248,
  "entity_kind": "class",
  "parent": "compiler",
  "start_line": 2051,
  "symbol": "SQLUpdateCompiler"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2051,"selector":"L2051-L2248","symbol":"SQLUpdateCompiler"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLUpdateCompiler](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2248,
    "entity_kind": "class",
    "parent": "compiler",
    "start_line": 2051,
    "symbol": "SQLUpdateCompiler"
  },
  "id": "c7e69306-ce2a-49ff-a4fa-c9cb11ffa0aa",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:57.7205000+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2051,
        "selector": "L2051-L2248",
        "symbol": "SQLUpdateCompiler"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "99cf2853-ee7a-4c68-a2f5-88a0df621528",
  "subject_name": "django/db/models/sql/compiler::SQLUpdateCompiler",
  "tags": [
    "entity:class"
  ],
  "text": "class SQLUpdateCompiler(SQLCompiler)"
}
```
