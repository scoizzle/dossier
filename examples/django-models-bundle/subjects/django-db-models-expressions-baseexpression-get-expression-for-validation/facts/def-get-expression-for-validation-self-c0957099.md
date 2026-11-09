# Fact c0957099

Store id: 1636982d-9cc7-4df7-bd03-2f665062e5ad

## Text

```text
def get_expression_for_validation(self)
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
- posted_at: `2026-11-09T23:44:49.4145330+00:00`

## Data

```json
{
  "end_line": 516,
  "entity_kind": "method",
  "parent": "BaseExpression",
  "start_line": 503,
  "symbol": "BaseExpression.get_expression_for_validation"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":503,"selector":"L503-L516","symbol":"BaseExpression.get_expression_for_validation"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::BaseExpression.get_expression_for_validation](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 516,
    "entity_kind": "method",
    "parent": "BaseExpression",
    "start_line": 503,
    "symbol": "BaseExpression.get_expression_for_validation"
  },
  "id": "1636982d-9cc7-4df7-bd03-2f665062e5ad",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.4145330+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 503,
        "selector": "L503-L516",
        "symbol": "BaseExpression.get_expression_for_validation"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "0fc2958e-8f89-4bd0-b0bf-abe70ac67486",
  "subject_name": "django/db/models/expressions::BaseExpression.get_expression_for_validation",
  "tags": [
    "entity:method"
  ],
  "text": "def get_expression_for_validation(self)"
}
```
