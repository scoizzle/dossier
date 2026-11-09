# Fact 3ba56b44

Store id: 63a4e34d-7279-49a0-afbe-dea4ece5d9f4

## Text

```text
def __repr__(self)
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
- posted_at: `2026-11-09T22:39:41.6763460+00:00`

## Data

```json
{
  "end_line": 1577,
  "entity_kind": "method",
  "parent": "ExpressionWrapper",
  "start_line": 1576,
  "symbol": "ExpressionWrapper.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1576,"selector":"L1576-L1577","symbol":"ExpressionWrapper.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::ExpressionWrapper.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1577,
    "entity_kind": "method",
    "parent": "ExpressionWrapper",
    "start_line": 1576,
    "symbol": "ExpressionWrapper.__repr__"
  },
  "id": "63a4e34d-7279-49a0-afbe-dea4ece5d9f4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6763460+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1576,
        "selector": "L1576-L1577",
        "symbol": "ExpressionWrapper.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "aa58842b-fcc0-4ace-b3cf-7335323d9370",
  "subject_name": "django/db/models/expressions::ExpressionWrapper.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
