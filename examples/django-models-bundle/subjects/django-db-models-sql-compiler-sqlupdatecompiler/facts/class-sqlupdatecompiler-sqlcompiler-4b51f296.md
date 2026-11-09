# Fact 4b51f296

Store id: a3132ee2-04e0-40da-a51f-51634e72816d

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
- posted_at: `2026-11-09T23:32:06.0608030+00:00`

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
  "id": "a3132ee2-04e0-40da-a51f-51634e72816d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.0608030+00:00"
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
  "subject_id": "a16c62f3-05dc-44e4-9faf-df9680909823",
  "subject_name": "django/db/models/sql/compiler::SQLUpdateCompiler",
  "tags": [
    "entity:class"
  ],
  "text": "class SQLUpdateCompiler(SQLCompiler)"
}
```
