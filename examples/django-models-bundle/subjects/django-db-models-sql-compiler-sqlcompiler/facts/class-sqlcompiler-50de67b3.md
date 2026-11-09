# Fact 50de67b3

Store id: 4f94dba9-43cc-4511-ad17-ae7978f06ee3

## Text

```text
class SQLCompiler
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
- posted_at: `2026-11-09T23:44:57.3726360+00:00`

## Data

```json
{
  "end_line": 1698,
  "entity_kind": "class",
  "parent": "compiler",
  "start_line": 42,
  "symbol": "SQLCompiler"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":42,"selector":"L42-L1698","symbol":"SQLCompiler"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1698,
    "entity_kind": "class",
    "parent": "compiler",
    "start_line": 42,
    "symbol": "SQLCompiler"
  },
  "id": "4f94dba9-43cc-4511-ad17-ae7978f06ee3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:57.3726360+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 42,
        "selector": "L42-L1698",
        "symbol": "SQLCompiler"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "3a7f5d2a-e460-4711-8ce2-78af0bd49994",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler",
  "tags": [
    "entity:class"
  ],
  "text": "class SQLCompiler"
}
```
