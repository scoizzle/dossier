# Fact a2bbc3d0

Store id: 60e43cf6-c002-4080-b8d6-b8c27d03cb20

## Text

```text
def resolve_expression(self, query, reuse, *args, **kwargs)
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
- posted_at: `2026-11-09T22:39:50.1989500+00:00`

## Data

```json
{
  "end_line": 567,
  "entity_kind": "method",
  "parent": "FilteredRelation",
  "start_line": 558,
  "symbol": "FilteredRelation.resolve_expression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":558,"selector":"L558-L567","symbol":"FilteredRelation.resolve_expression"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::FilteredRelation.resolve_expression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 567,
    "entity_kind": "method",
    "parent": "FilteredRelation",
    "start_line": 558,
    "symbol": "FilteredRelation.resolve_expression"
  },
  "id": "60e43cf6-c002-4080-b8d6-b8c27d03cb20",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.1989500+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 558,
        "selector": "L558-L567",
        "symbol": "FilteredRelation.resolve_expression"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "19b5d54f-2896-4e74-8091-dfa91591a6cb",
  "subject_name": "django/db/models/query_utils::FilteredRelation.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression(self, query, reuse, *args, **kwargs)"
}
```
