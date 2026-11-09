# Fact 45fc9fb1

Store id: 9183892f-aa63-425e-a807-2744c4169c33

## Text

```text
def output_field(self)
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
- posted_at: `2026-11-09T23:31:55.7768830+00:00`

## Data

```json
{
  "end_line": 333,
  "entity_kind": "method",
  "parent": "BaseExpression",
  "start_line": 325,
  "symbol": "BaseExpression.output_field"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":325,"selector":"L325-L333","symbol":"BaseExpression.output_field"}`

## Items

```json
[
  {
    "text": "Return the output type of this expressions.",
    "locator": {
      "line": 327
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/expressions::BaseExpression.output_field](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 333,
    "entity_kind": "method",
    "parent": "BaseExpression",
    "start_line": 325,
    "symbol": "BaseExpression.output_field"
  },
  "id": "9183892f-aa63-425e-a807-2744c4169c33",
  "items": [
    {
      "locator": {
        "line": 327
      },
      "text": "Return the output type of this expressions."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.7768830+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 325,
        "selector": "L325-L333",
        "symbol": "BaseExpression.output_field"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "952b16a0-1b80-4424-b053-e36003575c36",
  "subject_name": "django/db/models/expressions::BaseExpression.output_field",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def output_field(self)"
}
```
