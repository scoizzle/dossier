# Fact e2e95a61

Store id: 0dc5feeb-cb97-48d4-ba95-ef9d6f88d148

## Text

```text
def conditional(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:55.7742580+00:00`

## Data

```json
{
  "end_line": 319,
  "entity_kind": "method",
  "parent": "BaseExpression",
  "start_line": 317,
  "symbol": "BaseExpression.conditional"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":317,"selector":"L317-L319","symbol":"BaseExpression.conditional"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::BaseExpression.conditional](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 319,
    "entity_kind": "method",
    "parent": "BaseExpression",
    "start_line": 317,
    "symbol": "BaseExpression.conditional"
  },
  "id": "0dc5feeb-cb97-48d4-ba95-ef9d6f88d148",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.7742580+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 317,
        "selector": "L317-L319",
        "symbol": "BaseExpression.conditional"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "d74f61dc-fa60-4405-92f3-0c346212bc74",
  "subject_name": "django/db/models/expressions::BaseExpression.conditional",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def conditional(self)"
}
```
