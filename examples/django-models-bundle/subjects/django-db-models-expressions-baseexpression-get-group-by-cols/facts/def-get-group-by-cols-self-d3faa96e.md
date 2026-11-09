# Fact d3faa96e

Store id: 1bdbadf5-5d66-4834-9d09-0425d3e280da

## Text

```text
def get_group_by_cols(self)
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
- posted_at: `2026-11-09T22:39:41.5285120+00:00`

## Data

```json
{
  "end_line": 466,
  "entity_kind": "method",
  "parent": "BaseExpression",
  "start_line": 460,
  "symbol": "BaseExpression.get_group_by_cols"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":460,"selector":"L460-L466","symbol":"BaseExpression.get_group_by_cols"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::BaseExpression.get_group_by_cols](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 466,
    "entity_kind": "method",
    "parent": "BaseExpression",
    "start_line": 460,
    "symbol": "BaseExpression.get_group_by_cols"
  },
  "id": "1bdbadf5-5d66-4834-9d09-0425d3e280da",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5285120+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 460,
        "selector": "L460-L466",
        "symbol": "BaseExpression.get_group_by_cols"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "4ef94c58-3fe2-4866-91eb-8ca04d214a29",
  "subject_name": "django/db/models/expressions::BaseExpression.get_group_by_cols",
  "tags": [
    "entity:method"
  ],
  "text": "def get_group_by_cols(self)"
}
```
