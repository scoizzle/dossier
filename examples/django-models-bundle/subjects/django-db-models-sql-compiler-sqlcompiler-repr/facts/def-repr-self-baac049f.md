# Fact baac049f

Store id: 161b6b54-3390-4261-a666-f0290f1f200b

## Text

```text
def __repr__(self)
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
- posted_at: `2026-11-09T23:32:05.6626900+00:00`

## Data

```json
{
  "end_line": 72,
  "entity_kind": "method",
  "parent": "SQLCompiler",
  "start_line": 67,
  "symbol": "SQLCompiler.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":67,"selector":"L67-L72","symbol":"SQLCompiler.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 72,
    "entity_kind": "method",
    "parent": "SQLCompiler",
    "start_line": 67,
    "symbol": "SQLCompiler.__repr__"
  },
  "id": "161b6b54-3390-4261-a666-f0290f1f200b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.6626900+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 67,
        "selector": "L67-L72",
        "symbol": "SQLCompiler.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "acd752a6-17a8-4a2e-964c-8249aef09fd6",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
