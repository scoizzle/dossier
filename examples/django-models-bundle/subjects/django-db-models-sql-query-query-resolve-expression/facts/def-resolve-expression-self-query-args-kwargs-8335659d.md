# Fact 8335659d

Store id: 56e43b85-f7f5-45ce-a34b-dcae1c32ec86

## Text

```text
def resolve_expression(self, query, *args, **kwargs)
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
- posted_at: `2026-11-09T22:39:51.3384610+00:00`

## Data

```json
{
  "end_line": 1287,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 1259,
  "symbol": "Query.resolve_expression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1259,"selector":"L1259-L1287","symbol":"Query.resolve_expression"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.resolve_expression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1287,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 1259,
    "symbol": "Query.resolve_expression"
  },
  "id": "56e43b85-f7f5-45ce-a34b-dcae1c32ec86",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.3384610+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1259,
        "selector": "L1259-L1287",
        "symbol": "Query.resolve_expression"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "c9aebcac-6af2-496f-a52a-c3c9e84d3122",
  "subject_name": "django/db/models/sql/query::Query.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression(self, query, *args, **kwargs)"
}
```
