# Fact 50de67b3

Store id: 640aecbe-2b5d-4652-95e4-e3ce0294af2d

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
- posted_at: `2026-11-09T23:32:05.6515970+00:00`

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
  "id": "640aecbe-2b5d-4652-95e4-e3ce0294af2d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.6515970+00:00"
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
  "subject_id": "364ed1da-3c95-47cb-bece-b6b90e73ee88",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler",
  "tags": [
    "entity:class"
  ],
  "text": "class SQLCompiler"
}
```
