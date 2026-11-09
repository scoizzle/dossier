# Fact 4e60512f

Store id: d11de603-ce13-4574-b0b9-67a0621f3da6

## Text

```text
def _output_field_or_none(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:55.7799030+00:00`

## Data

```json
{
  "end_line": 344,
  "entity_kind": "method",
  "parent": "BaseExpression",
  "start_line": 335,
  "symbol": "BaseExpression._output_field_or_none"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":335,"selector":"L335-L344","symbol":"BaseExpression._output_field_or_none"}`

## Items

```json
[
  {
    "text": "Return the output field of this expression, or None if _resolve_output_field() didn't return an output type.",
    "locator": {
      "line": 337
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/expressions::BaseExpression._output_field_or_none](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 344,
    "entity_kind": "method",
    "parent": "BaseExpression",
    "start_line": 335,
    "symbol": "BaseExpression._output_field_or_none"
  },
  "id": "d11de603-ce13-4574-b0b9-67a0621f3da6",
  "items": [
    {
      "locator": {
        "line": 337
      },
      "text": "Return the output field of this expression, or None if _resolve_output_field() didn't return an output type."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.7799030+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 335,
        "selector": "L335-L344",
        "symbol": "BaseExpression._output_field_or_none"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "6f617f71-4fa1-4691-904a-926a3f630058",
  "subject_name": "django/db/models/expressions::BaseExpression._output_field_or_none",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def _output_field_or_none(self)"
}
```
