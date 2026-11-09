# Fact 7bbe91d8

Store id: 8456ade9-2b0c-4e61-9424-4f3a71286436

## Text

```text
class ExpressionWrapper(SQLiteNumericMixin, Expression)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`, `decorator:deconstructible`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:55.9328250+00:00`

## Data

```json
{
  "end_line": 1581,
  "entity_kind": "class",
  "parent": "expressions",
  "start_line": 1547,
  "symbol": "ExpressionWrapper"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1547,"selector":"L1547-L1581","symbol":"ExpressionWrapper"}`

## Items

```json
[
  {
    "text": "An expression that can wrap another expression so that it can provide extra context to the inner expression, such as the output_field.",
    "locator": {
      "line": 1549
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/expressions::ExpressionWrapper](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1581,
    "entity_kind": "class",
    "parent": "expressions",
    "start_line": 1547,
    "symbol": "ExpressionWrapper"
  },
  "id": "8456ade9-2b0c-4e61-9424-4f3a71286436",
  "items": [
    {
      "locator": {
        "line": 1549
      },
      "text": "An expression that can wrap another expression so that it can provide extra context to the inner expression, such as the output_field."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9328250+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1547,
        "selector": "L1547-L1581",
        "symbol": "ExpressionWrapper"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "e2f814a6-34f2-4672-8458-38dd487ad931",
  "subject_name": "django/db/models/expressions::ExpressionWrapper",
  "tags": [
    "entity:class",
    "decorator:deconstructible"
  ],
  "text": "class ExpressionWrapper(SQLiteNumericMixin, Expression)"
}
```
