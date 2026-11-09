# Fact 50cdbeef

Store id: 094b81ab-b1c4-45ec-89c0-697e67b304bb

## Text

```text
def convert_value(self)
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
- posted_at: `2026-11-09T23:31:55.7832800+00:00`

## Data

```json
{
  "end_line": 401,
  "entity_kind": "method",
  "parent": "BaseExpression",
  "start_line": 380,
  "symbol": "BaseExpression.convert_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":380,"selector":"L380-L401","symbol":"BaseExpression.convert_value"}`

## Items

```json
[
  {
    "text": "Expressions provide their own converters because users have the option of manually specifying the output_field which may be a different type from the one the database returns.",
    "locator": {
      "line": 382
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/expressions::BaseExpression.convert_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 401,
    "entity_kind": "method",
    "parent": "BaseExpression",
    "start_line": 380,
    "symbol": "BaseExpression.convert_value"
  },
  "id": "094b81ab-b1c4-45ec-89c0-697e67b304bb",
  "items": [
    {
      "locator": {
        "line": 382
      },
      "text": "Expressions provide their own converters because users have the option of manually specifying the output_field which may be a different type from the one the database returns."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.7832800+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 380,
        "selector": "L380-L401",
        "symbol": "BaseExpression.convert_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "17a3ca11-265d-44f0-a6db-ce67daf8d244",
  "subject_name": "django/db/models/expressions::BaseExpression.convert_value",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def convert_value(self)"
}
```
