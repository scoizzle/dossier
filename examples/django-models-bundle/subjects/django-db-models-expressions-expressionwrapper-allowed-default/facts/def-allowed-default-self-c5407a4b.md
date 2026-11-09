# Fact c5407a4b

Store id: 7ed34551-c427-4911-8a62-ad1f125b4dbc

## Text

```text
def allowed_default(self)
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
- posted_at: `2026-11-09T22:39:41.6783370+00:00`

## Data

```json
{
  "end_line": 1581,
  "entity_kind": "method",
  "parent": "ExpressionWrapper",
  "start_line": 1579,
  "symbol": "ExpressionWrapper.allowed_default"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1579,"selector":"L1579-L1581","symbol":"ExpressionWrapper.allowed_default"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::ExpressionWrapper.allowed_default](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1581,
    "entity_kind": "method",
    "parent": "ExpressionWrapper",
    "start_line": 1579,
    "symbol": "ExpressionWrapper.allowed_default"
  },
  "id": "7ed34551-c427-4911-8a62-ad1f125b4dbc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6783370+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1579,
        "selector": "L1579-L1581",
        "symbol": "ExpressionWrapper.allowed_default"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "203e549b-89bc-4846-aed7-8ede94303f17",
  "subject_name": "django/db/models/expressions::ExpressionWrapper.allowed_default",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def allowed_default(self)"
}
```
