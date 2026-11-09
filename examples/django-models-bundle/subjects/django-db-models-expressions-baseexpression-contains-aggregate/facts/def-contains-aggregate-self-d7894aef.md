# Fact d7894aef

Store id: 636fde50-d2e3-4dd2-a9b5-8733f70a9348

## Text

```text
def contains_aggregate(self)
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
- posted_at: `2026-11-09T23:31:55.7666390+00:00`

## Data

```json
{
  "end_line": 257,
  "entity_kind": "method",
  "parent": "BaseExpression",
  "start_line": 253,
  "symbol": "BaseExpression.contains_aggregate"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":253,"selector":"L253-L257","symbol":"BaseExpression.contains_aggregate"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::BaseExpression.contains_aggregate](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 257,
    "entity_kind": "method",
    "parent": "BaseExpression",
    "start_line": 253,
    "symbol": "BaseExpression.contains_aggregate"
  },
  "id": "636fde50-d2e3-4dd2-a9b5-8733f70a9348",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.7666390+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 253,
        "selector": "L253-L257",
        "symbol": "BaseExpression.contains_aggregate"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "bb9438b0-541d-4ec2-92fc-1e177f1c2b35",
  "subject_name": "django/db/models/expressions::BaseExpression.contains_aggregate",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def contains_aggregate(self)"
}
```
