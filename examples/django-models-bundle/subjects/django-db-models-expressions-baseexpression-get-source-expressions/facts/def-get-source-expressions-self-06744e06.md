# Fact 06744e06

Store id: e9c5b015-954c-4976-b7c2-76d571f6d584

## Text

```text
def get_source_expressions(self)
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
- posted_at: `2026-11-09T22:39:41.5035230+00:00`

## Data

```json
{
  "end_line": 210,
  "entity_kind": "method",
  "parent": "BaseExpression",
  "start_line": 209,
  "symbol": "BaseExpression.get_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":209,"selector":"L209-L210","symbol":"BaseExpression.get_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::BaseExpression.get_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 210,
    "entity_kind": "method",
    "parent": "BaseExpression",
    "start_line": 209,
    "symbol": "BaseExpression.get_source_expressions"
  },
  "id": "e9c5b015-954c-4976-b7c2-76d571f6d584",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5035230+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 209,
        "selector": "L209-L210",
        "symbol": "BaseExpression.get_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "13495a2c-c05d-4ecb-a74d-ae0645606755",
  "subject_name": "django/db/models/expressions::BaseExpression.get_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def get_source_expressions(self)"
}
```
