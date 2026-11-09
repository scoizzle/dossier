# Fact 0da8adc7

Store id: 88c1d5ee-7ebe-4785-b0b8-c9188917b841

## Text

```text
def desc(self, **kwargs)
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
- posted_at: `2026-11-09T23:44:49.4022290+00:00`

## Data

```json
{
  "end_line": 476,
  "entity_kind": "method",
  "parent": "BaseExpression",
  "start_line": 475,
  "symbol": "BaseExpression.desc"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":475,"selector":"L475-L476","symbol":"BaseExpression.desc"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::BaseExpression.desc](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 476,
    "entity_kind": "method",
    "parent": "BaseExpression",
    "start_line": 475,
    "symbol": "BaseExpression.desc"
  },
  "id": "88c1d5ee-7ebe-4785-b0b8-c9188917b841",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.4022290+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 475,
        "selector": "L475-L476",
        "symbol": "BaseExpression.desc"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "ceedae44-c40a-4a24-92c4-77e06abe001a",
  "subject_name": "django/db/models/expressions::BaseExpression.desc",
  "tags": [
    "entity:method"
  ],
  "text": "def desc(self, **kwargs)"
}
```
