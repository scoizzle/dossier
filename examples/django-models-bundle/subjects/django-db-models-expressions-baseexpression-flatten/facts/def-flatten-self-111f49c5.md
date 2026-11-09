# Fact 111f49c5

Store id: 0a560918-c586-4601-9981-e1e7986ae1dd

## Text

```text
def flatten(self)
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
- posted_at: `2026-11-09T23:31:55.7947030+00:00`

## Data

```json
{
  "end_line": 492,
  "entity_kind": "method",
  "parent": "BaseExpression",
  "start_line": 481,
  "symbol": "BaseExpression.flatten"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":481,"selector":"L481-L492","symbol":"BaseExpression.flatten"}`

## Items

```json
[
  {
    "text": "Recursively yield this expression and all subexpressions, in depth-first order.",
    "locator": {
      "line": 482
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/expressions::BaseExpression.flatten](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 492,
    "entity_kind": "method",
    "parent": "BaseExpression",
    "start_line": 481,
    "symbol": "BaseExpression.flatten"
  },
  "id": "0a560918-c586-4601-9981-e1e7986ae1dd",
  "items": [
    {
      "locator": {
        "line": 482
      },
      "text": "Recursively yield this expression and all subexpressions, in depth-first order."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.7947030+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 481,
        "selector": "L481-L492",
        "symbol": "BaseExpression.flatten"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "f98c13f2-5bfb-4498-85a0-ae1920d55f67",
  "subject_name": "django/db/models/expressions::BaseExpression.flatten",
  "tags": [
    "entity:method"
  ],
  "text": "def flatten(self)"
}
```
