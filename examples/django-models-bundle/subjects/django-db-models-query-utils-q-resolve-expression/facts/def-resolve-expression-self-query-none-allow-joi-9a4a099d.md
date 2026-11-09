# Fact 9a4a099d

Store id: 31a8d307-cd58-4406-a9a1-fd2463832e7b

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
- posted_at: `2026-11-09T22:39:50.0828630+00:00`

## Data

```json
{
  "end_line": 115,
  "entity_kind": "method",
  "parent": "Q",
  "start_line": 101,
  "symbol": "Q.resolve_expression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":101,"selector":"L101-L115","symbol":"Q.resolve_expression"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::Q.resolve_expression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 115,
    "entity_kind": "method",
    "parent": "Q",
    "start_line": 101,
    "symbol": "Q.resolve_expression"
  },
  "id": "31a8d307-cd58-4406-a9a1-fd2463832e7b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.0828630+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 101,
        "selector": "L101-L115",
        "symbol": "Q.resolve_expression"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "b6745132-04ea-451c-898e-1ddce9a5b325",
  "subject_name": "django/db/models/query_utils::Q.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression( self, query=None, allow_joins=True, reuse=None, summarize=False, for_save=False )"
}
```
