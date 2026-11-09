# Fact 4e60512f

Store id: d001edc3-47e4-4397-9b36-2fd8f8271d15

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
- posted_at: `2026-11-09T23:44:49.3328560+00:00`

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
  "id": "d001edc3-47e4-4397-9b36-2fd8f8271d15",
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
    "posted_at": "2026-11-09T23:44:49.3328560+00:00"
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
  "subject_id": "dc22df3e-1f99-474d-accb-aa3895f3d522",
  "subject_name": "django/db/models/expressions::BaseExpression._output_field_or_none",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def _output_field_or_none(self)"
}
```
