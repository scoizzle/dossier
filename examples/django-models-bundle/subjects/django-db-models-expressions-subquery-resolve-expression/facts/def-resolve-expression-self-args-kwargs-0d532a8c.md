# Fact 0d532a8c

Store id: d32e8138-f16c-4fe5-8ae7-e140c3879d1c

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
- posted_at: `2026-11-09T22:39:41.7252200+00:00`

## Data

```json
{
  "end_line": 1859,
  "entity_kind": "method",
  "parent": "Subquery",
  "start_line": 1844,
  "symbol": "Subquery.resolve_expression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1844,"selector":"L1844-L1859","symbol":"Subquery.resolve_expression"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Subquery.resolve_expression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1859,
    "entity_kind": "method",
    "parent": "Subquery",
    "start_line": 1844,
    "symbol": "Subquery.resolve_expression"
  },
  "id": "d32e8138-f16c-4fe5-8ae7-e140c3879d1c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7252200+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1844,
        "selector": "L1844-L1859",
        "symbol": "Subquery.resolve_expression"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "cb5a057a-decd-472a-bd85-14cc13998e55",
  "subject_name": "django/db/models/expressions::Subquery.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression(self, *args, **kwargs)"
}
```
