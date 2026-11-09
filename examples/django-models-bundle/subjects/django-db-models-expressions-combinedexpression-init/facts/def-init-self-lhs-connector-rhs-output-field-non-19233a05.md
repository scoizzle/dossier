# Fact 19233a05

Store id: 513e0900-0995-45a2-92dc-9362c07d9381

## Text

```text
def __init__(self, lhs, connector, rhs, output_field=None)
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
- posted_at: `2026-11-09T23:44:49.4329310+00:00`

## Data

```json
{
  "end_line": 733,
  "entity_kind": "method",
  "parent": "CombinedExpression",
  "start_line": 729,
  "symbol": "CombinedExpression.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":729,"selector":"L729-L733","symbol":"CombinedExpression.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::CombinedExpression.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 733,
    "entity_kind": "method",
    "parent": "CombinedExpression",
    "start_line": 729,
    "symbol": "CombinedExpression.__init__"
  },
  "id": "513e0900-0995-45a2-92dc-9362c07d9381",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.4329310+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 729,
        "selector": "L729-L733",
        "symbol": "CombinedExpression.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "828cc3dc-00a0-4f6c-947b-a103b015b1a4",
  "subject_name": "django/db/models/expressions::CombinedExpression.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, lhs, connector, rhs, output_field=None)"
}
```
