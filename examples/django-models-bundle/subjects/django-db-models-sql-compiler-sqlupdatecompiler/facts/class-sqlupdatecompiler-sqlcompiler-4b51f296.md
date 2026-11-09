# Fact 4b51f296

Store id: 21821a6e-1db0-4e1b-b7c2-eea277ee8d97

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
- posted_at: `2026-11-09T22:39:50.7282340+00:00`

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
  "id": "21821a6e-1db0-4e1b-b7c2-eea277ee8d97",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.7282340+00:00"
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
  "subject_id": "51bac652-efc8-4697-89a6-d55a545dc993",
  "subject_name": "django/db/models/sql/compiler::SQLUpdateCompiler",
  "tags": [
    "entity:class"
  ],
  "text": "class SQLUpdateCompiler(SQLCompiler)"
}
```
