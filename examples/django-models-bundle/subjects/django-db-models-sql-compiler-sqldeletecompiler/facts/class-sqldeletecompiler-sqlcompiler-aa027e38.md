# Fact aa027e38

Store id: 1933e7fe-eba7-437b-a3c1-33ba50f24a82

## Text

```text
class SQLDeleteCompiler(SQLCompiler)
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
- posted_at: `2026-11-09T23:32:05.9987470+00:00`

## Data

```json
{
  "end_line": 2048,
  "entity_kind": "class",
  "parent": "compiler",
  "start_line": 1991,
  "symbol": "SQLDeleteCompiler"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1991,"selector":"L1991-L2048","symbol":"SQLDeleteCompiler"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLDeleteCompiler](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2048,
    "entity_kind": "class",
    "parent": "compiler",
    "start_line": 1991,
    "symbol": "SQLDeleteCompiler"
  },
  "id": "1933e7fe-eba7-437b-a3c1-33ba50f24a82",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.9987470+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1991,
        "selector": "L1991-L2048",
        "symbol": "SQLDeleteCompiler"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "d395a30f-760b-4ddc-90a5-0b7d87622716",
  "subject_name": "django/db/models/sql/compiler::SQLDeleteCompiler",
  "tags": [
    "entity:class"
  ],
  "text": "class SQLDeleteCompiler(SQLCompiler)"
}
```
