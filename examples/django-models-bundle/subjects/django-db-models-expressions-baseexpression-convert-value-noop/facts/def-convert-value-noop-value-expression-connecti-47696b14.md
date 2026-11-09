# Fact 47696b14

Store id: 6e4519b0-1e13-48c9-ba87-e4a9cfd32454

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
- posted_at: `2026-11-09T23:44:49.3368420+00:00`

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
  "id": "6e4519b0-1e13-48c9-ba87-e4a9cfd32454",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.3368420+00:00"
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
  "subject_id": "e4c668cc-c891-4f19-a353-ceea1126b294",
  "subject_name": "django/db/models/expressions::BaseExpression._convert_value_noop",
  "tags": [
    "entity:static_method",
    "decorator:staticmethod"
  ],
  "text": "def _convert_value_noop(value, expression, connection)"
}
```
