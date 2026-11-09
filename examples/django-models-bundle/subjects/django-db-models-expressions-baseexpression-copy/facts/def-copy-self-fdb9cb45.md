# Fact fdb9cb45

Store id: 3990d334-b5c2-4d0e-83b6-208cbb15a937

## Text

```text
def copy(self)
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
- posted_at: `2026-11-09T22:39:41.5271880+00:00`

## Data

```json
{
  "end_line": 444,
  "entity_kind": "method",
  "parent": "BaseExpression",
  "start_line": 443,
  "symbol": "BaseExpression.copy"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":443,"selector":"L443-L444","symbol":"BaseExpression.copy"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::BaseExpression.copy](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 444,
    "entity_kind": "method",
    "parent": "BaseExpression",
    "start_line": 443,
    "symbol": "BaseExpression.copy"
  },
  "id": "3990d334-b5c2-4d0e-83b6-208cbb15a937",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5271880+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 443,
        "selector": "L443-L444",
        "symbol": "BaseExpression.copy"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "6e42ab72-c0c6-4dc5-b2bf-e1a8b29f6de9",
  "subject_name": "django/db/models/expressions::BaseExpression.copy",
  "tags": [
    "entity:method"
  ],
  "text": "def copy(self)"
}
```
