# Fact e84e3ee5

Store id: acd571f6-66e3-464c-9dcd-0061a77d1c82

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
- posted_at: `2026-11-09T23:31:55.8124810+00:00`

## Data

```json
{
  "end_line": 742,
  "entity_kind": "method",
  "parent": "CombinedExpression",
  "start_line": 741,
  "symbol": "CombinedExpression.get_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":741,"selector":"L741-L742","symbol":"CombinedExpression.get_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::CombinedExpression.get_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 742,
    "entity_kind": "method",
    "parent": "CombinedExpression",
    "start_line": 741,
    "symbol": "CombinedExpression.get_source_expressions"
  },
  "id": "acd571f6-66e3-464c-9dcd-0061a77d1c82",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8124810+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 741,
        "selector": "L741-L742",
        "symbol": "CombinedExpression.get_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "ed5c5535-b524-4707-8506-a851ff2e9405",
  "subject_name": "django/db/models/expressions::CombinedExpression.get_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def get_source_expressions(self)"
}
```
