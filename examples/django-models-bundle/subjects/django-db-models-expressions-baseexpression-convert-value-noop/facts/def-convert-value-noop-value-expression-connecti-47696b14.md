# Fact 47696b14

Store id: fe177f9b-7a07-401b-8ac7-ff84e20d6f3f

## Text

```text
def _convert_value_noop(value, expression, connection)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:static_method`, `decorator:staticmethod`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:55.7821280+00:00`

## Data

```json
{
  "end_line": 378,
  "entity_kind": "static_method",
  "parent": "BaseExpression",
  "start_line": 376,
  "symbol": "BaseExpression._convert_value_noop"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":376,"selector":"L376-L378","symbol":"BaseExpression._convert_value_noop"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::BaseExpression._convert_value_noop](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 378,
    "entity_kind": "static_method",
    "parent": "BaseExpression",
    "start_line": 376,
    "symbol": "BaseExpression._convert_value_noop"
  },
  "id": "fe177f9b-7a07-401b-8ac7-ff84e20d6f3f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.7821280+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 376,
        "selector": "L376-L378",
        "symbol": "BaseExpression._convert_value_noop"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "ffa2f8db-e1b6-4a24-ace4-8ccb0cd229fd",
  "subject_name": "django/db/models/expressions::BaseExpression._convert_value_noop",
  "tags": [
    "entity:static_method",
    "decorator:staticmethod"
  ],
  "text": "def _convert_value_noop(value, expression, connection)"
}
```
