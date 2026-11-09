# Fact 99002c47

Store id: 3cb07453-20da-4c00-8bed-d55ef978b4bf

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
- posted_at: `2026-11-09T22:39:41.5235320+00:00`

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
  "id": "3cb07453-20da-4c00-8bed-d55ef978b4bf",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5235320+00:00"
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
  "subject_id": "64c9b59a-3638-430b-8727-9697b4f29ec9",
  "subject_name": "django/db/models/expressions::BaseExpression.relabeled_clone",
  "tags": [
    "entity:method"
  ],
  "text": "def relabeled_clone(self, change_map)"
}
```
