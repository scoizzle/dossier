# Fact e84e3ee5

Store id: 73a1028a-ac9d-4433-b0ad-aec3c271d071

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
- posted_at: `2026-11-09T23:44:49.4397880+00:00`

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
  "id": "73a1028a-ac9d-4433-b0ad-aec3c271d071",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.4397880+00:00"
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
  "subject_id": "ec6d0b73-85ad-48d0-8508-d0467b51648f",
  "subject_name": "django/db/models/expressions::CombinedExpression.get_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def get_source_expressions(self)"
}
```
