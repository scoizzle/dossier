# Fact d3faa96e

Store id: 00f9df2e-5be6-41a8-9848-d454b22131c8

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
- posted_at: `2026-11-09T23:31:55.7905170+00:00`

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
  "id": "00f9df2e-5be6-41a8-9848-d454b22131c8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.7905170+00:00"
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
  "subject_id": "02583a39-040f-4979-a9c9-4f774b72928d",
  "subject_name": "django/db/models/expressions::BaseExpression.get_group_by_cols",
  "tags": [
    "entity:method"
  ],
  "text": "def get_group_by_cols(self)"
}
```
