# Fact 0d532a8c

Store id: cff4dd8e-14bb-4caa-a139-8dda9605d2d6

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
- posted_at: `2026-11-09T23:44:49.6398270+00:00`

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
  "id": "cff4dd8e-14bb-4caa-a139-8dda9605d2d6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6398270+00:00"
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
  "subject_id": "af82987e-583a-47a6-bc57-a90eda9649d3",
  "subject_name": "django/db/models/expressions::Subquery.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression(self, *args, **kwargs)"
}
```
