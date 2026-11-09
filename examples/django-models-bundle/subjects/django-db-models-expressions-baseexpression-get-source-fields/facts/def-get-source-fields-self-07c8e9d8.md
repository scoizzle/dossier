# Fact 07c8e9d8

Store id: a2e0b789-77ce-4449-b1c0-d7114bcb965b

## Text

```text
def get_source_fields(self)
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
- posted_at: `2026-11-09T22:39:41.5293320+00:00`

## Data

```json
{
  "end_line": 470,
  "entity_kind": "method",
  "parent": "BaseExpression",
  "start_line": 468,
  "symbol": "BaseExpression.get_source_fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":468,"selector":"L468-L470","symbol":"BaseExpression.get_source_fields"}`

## Items

```json
[
  {
    "text": "Return the underlying field types used by this aggregate.",
    "locator": {
      "line": 469
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/expressions::BaseExpression.get_source_fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 470,
    "entity_kind": "method",
    "parent": "BaseExpression",
    "start_line": 468,
    "symbol": "BaseExpression.get_source_fields"
  },
  "id": "a2e0b789-77ce-4449-b1c0-d7114bcb965b",
  "items": [
    {
      "locator": {
        "line": 469
      },
      "text": "Return the underlying field types used by this aggregate."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5293320+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 468,
        "selector": "L468-L470",
        "symbol": "BaseExpression.get_source_fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "28b94d76-d2f6-497c-b2ab-3485016be166",
  "subject_name": "django/db/models/expressions::BaseExpression.get_source_fields",
  "tags": [
    "entity:method"
  ],
  "text": "def get_source_fields(self)"
}
```
