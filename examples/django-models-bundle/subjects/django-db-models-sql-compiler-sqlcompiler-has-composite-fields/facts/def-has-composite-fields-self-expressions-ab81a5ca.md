# Fact ab81a5ca

Store id: 58398ad8-bb45-48ff-b29d-5274e352a211

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
- posted_at: `2026-11-09T23:32:05.8774420+00:00`

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
  "id": "58398ad8-bb45-48ff-b29d-5274e352a211",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.8774420+00:00"
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
  "subject_id": "fc60385f-769e-44ff-884a-aa565cf1f3d7",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.has_composite_fields",
  "tags": [
    "entity:method"
  ],
  "text": "def has_composite_fields(self, expressions)"
}
```
