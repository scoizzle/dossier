# Fact 50cdbeef

Store id: 8dd934e2-bf38-4207-878c-9f3b2379cb0d

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
- posted_at: `2026-11-09T23:44:49.3387850+00:00`

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
  "id": "8dd934e2-bf38-4207-878c-9f3b2379cb0d",
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
    "posted_at": "2026-11-09T23:44:49.3387850+00:00"
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
  "subject_id": "94c14215-4113-41e5-85b8-6e15a6a8b506",
  "subject_name": "django/db/models/expressions::BaseExpression.convert_value",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def convert_value(self)"
}
```
