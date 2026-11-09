# Fact ab81a5ca

Store id: ca99dc76-6387-41e8-a6f1-5d59ebaf484d

## Text

```text
def has_composite_fields(self, expressions)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:50.6710030+00:00`

## Data

```json
{
  "end_line": 1568,
  "entity_kind": "method",
  "parent": "SQLCompiler",
  "start_line": 1565,
  "symbol": "SQLCompiler.has_composite_fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1565,"selector":"L1565-L1568","symbol":"SQLCompiler.has_composite_fields"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler.has_composite_fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1568,
    "entity_kind": "method",
    "parent": "SQLCompiler",
    "start_line": 1565,
    "symbol": "SQLCompiler.has_composite_fields"
  },
  "id": "ca99dc76-6387-41e8-a6f1-5d59ebaf484d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.6710030+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1565,
        "selector": "L1565-L1568",
        "symbol": "SQLCompiler.has_composite_fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "f8accbd6-0209-47e1-9b97-6292a4570de6",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.has_composite_fields",
  "tags": [
    "entity:method"
  ],
  "text": "def has_composite_fields(self, expressions)"
}
```
