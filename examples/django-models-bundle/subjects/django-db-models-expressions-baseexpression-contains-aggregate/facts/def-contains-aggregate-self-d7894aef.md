# Fact d7894aef

Store id: c834ffef-1f00-408d-aebc-249ff6bba6a7

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
- posted_at: `2026-11-09T22:39:41.5088470+00:00`

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
  "id": "c834ffef-1f00-408d-aebc-249ff6bba6a7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5088470+00:00"
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
  "subject_id": "321afeff-45de-4875-8a09-3146f1d091aa",
  "subject_name": "django/db/models/expressions::BaseExpression.contains_aggregate",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def contains_aggregate(self)"
}
```
