# Fact 0be840d0

Store id: 64df0c2f-e80d-4c76-b433-465b730fde2e

## Text

```text
def prefix_references(self, prefix)
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
- posted_at: `2026-11-09T23:44:49.3599510+00:00`

## Data

```json
{
  "end_line": 458,
  "entity_kind": "method",
  "parent": "BaseExpression",
  "start_line": 446,
  "symbol": "BaseExpression.prefix_references"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":446,"selector":"L446-L458","symbol":"BaseExpression.prefix_references"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::BaseExpression.prefix_references](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 458,
    "entity_kind": "method",
    "parent": "BaseExpression",
    "start_line": 446,
    "symbol": "BaseExpression.prefix_references"
  },
  "id": "64df0c2f-e80d-4c76-b433-465b730fde2e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.3599510+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 446,
        "selector": "L446-L458",
        "symbol": "BaseExpression.prefix_references"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "fa18e464-8058-4371-a0be-1e4c6c567392",
  "subject_name": "django/db/models/expressions::BaseExpression.prefix_references",
  "tags": [
    "entity:method"
  ],
  "text": "def prefix_references(self, prefix)"
}
```
