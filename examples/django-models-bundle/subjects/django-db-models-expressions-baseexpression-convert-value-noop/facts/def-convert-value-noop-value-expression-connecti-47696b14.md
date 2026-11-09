# Fact 47696b14

Store id: 036f3ab1-7ddc-4888-8cf1-8be266a7779c

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
- posted_at: `2026-11-09T22:39:41.5191080+00:00`

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
  "id": "036f3ab1-7ddc-4888-8cf1-8be266a7779c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5191080+00:00"
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
  "subject_id": "3cc1d2f6-b9a0-4692-b738-6361093aa136",
  "subject_name": "django/db/models/expressions::BaseExpression._convert_value_noop",
  "tags": [
    "entity:static_method",
    "decorator:staticmethod"
  ],
  "text": "def _convert_value_noop(value, expression, connection)"
}
```
