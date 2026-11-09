# Fact 624dd770

Store id: c0da8c27-b9fe-4910-be6a-300de9bbf7c4

## Text

```text
def resolve_expression( self, query=None, allow_joins=True, reuse=None, summarize=False, for_save=False )
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
- posted_at: `2026-11-09T23:44:49.6142120+00:00`

## Data

```json
{
  "end_line": 1683,
  "entity_kind": "method",
  "parent": "When",
  "start_line": 1673,
  "symbol": "When.resolve_expression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1673,"selector":"L1673-L1683","symbol":"When.resolve_expression"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::When.resolve_expression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1683,
    "entity_kind": "method",
    "parent": "When",
    "start_line": 1673,
    "symbol": "When.resolve_expression"
  },
  "id": "c0da8c27-b9fe-4910-be6a-300de9bbf7c4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6142120+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1673,
        "selector": "L1673-L1683",
        "symbol": "When.resolve_expression"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "cf65b782-9e68-4b8b-963f-9c87245257f6",
  "subject_name": "django/db/models/expressions::When.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression( self, query=None, allow_joins=True, reuse=None, summarize=False, for_save=False )"
}
```
