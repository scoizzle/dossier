# Fact a2bbc3d0

Store id: 7f4cbfaa-c9f2-4e60-aab1-51a2d1094824

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
- posted_at: `2026-11-09T23:32:05.2202360+00:00`

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
  "id": "7f4cbfaa-c9f2-4e60-aab1-51a2d1094824",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.2202360+00:00"
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
  "subject_id": "f241f94c-d9f8-473b-b739-6fa2178e2961",
  "subject_name": "django/db/models/query_utils::FilteredRelation.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression(self, query, reuse, *args, **kwargs)"
}
```
