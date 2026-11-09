# Fact 99002c47

Store id: 204c4549-31d0-4714-97bc-7adf8e15a7ac

## Text

```text
def relabeled_clone(self, change_map)
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
- posted_at: `2026-11-09T23:44:49.3470670+00:00`

## Data

```json
{
  "end_line": 417,
  "entity_kind": "method",
  "parent": "BaseExpression",
  "start_line": 409,
  "symbol": "BaseExpression.relabeled_clone"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":409,"selector":"L409-L417","symbol":"BaseExpression.relabeled_clone"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::BaseExpression.relabeled_clone](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 417,
    "entity_kind": "method",
    "parent": "BaseExpression",
    "start_line": 409,
    "symbol": "BaseExpression.relabeled_clone"
  },
  "id": "204c4549-31d0-4714-97bc-7adf8e15a7ac",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.3470670+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 409,
        "selector": "L409-L417",
        "symbol": "BaseExpression.relabeled_clone"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "ab62f43f-280d-475f-87a7-1e4c8f0a39f5",
  "subject_name": "django/db/models/expressions::BaseExpression.relabeled_clone",
  "tags": [
    "entity:method"
  ],
  "text": "def relabeled_clone(self, change_map)"
}
```
