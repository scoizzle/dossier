# Fact d166e144

Store id: af9ca6ff-a93f-4c2a-8390-33b91b0e2198

## Text

```text
def contains_self_reference_subquery(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:57.7055020+00:00`

## Data

```json
{
  "end_line": 2016,
  "entity_kind": "method",
  "parent": "SQLDeleteCompiler",
  "start_line": 2009,
  "symbol": "SQLDeleteCompiler.contains_self_reference_subquery"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2009,"selector":"L2009-L2016","symbol":"SQLDeleteCompiler.contains_self_reference_subquery"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLDeleteCompiler.contains_self_reference_subquery](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2016,
    "entity_kind": "method",
    "parent": "SQLDeleteCompiler",
    "start_line": 2009,
    "symbol": "SQLDeleteCompiler.contains_self_reference_subquery"
  },
  "id": "af9ca6ff-a93f-4c2a-8390-33b91b0e2198",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:57.7055020+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2009,
        "selector": "L2009-L2016",
        "symbol": "SQLDeleteCompiler.contains_self_reference_subquery"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "89b3fd2a-6023-4442-8a34-5bb2ab5b349c",
  "subject_name": "django/db/models/sql/compiler::SQLDeleteCompiler.contains_self_reference_subquery",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def contains_self_reference_subquery(self)"
}
```
