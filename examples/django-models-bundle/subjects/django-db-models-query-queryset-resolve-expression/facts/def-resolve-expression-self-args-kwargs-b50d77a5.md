# Fact b50d77a5

Store id: cdc98a91-05bc-486c-a15e-39bd3ad06023

## Text

```text
def resolve_expression(self, *args, **kwargs)
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
- posted_at: `2026-11-09T23:32:04.6609540+00:00`

## Data

```json
{
  "end_line": 2327,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 2324,
  "symbol": "QuerySet.resolve_expression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2324,"selector":"L2324-L2327","symbol":"QuerySet.resolve_expression"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.resolve_expression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2327,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 2324,
    "symbol": "QuerySet.resolve_expression"
  },
  "id": "cdc98a91-05bc-486c-a15e-39bd3ad06023",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.6609540+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2324,
        "selector": "L2324-L2327",
        "symbol": "QuerySet.resolve_expression"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "2cb91a8d-65c1-405b-aa92-e70a9fd059c8",
  "subject_name": "django/db/models/query::QuerySet.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression(self, *args, **kwargs)"
}
```
