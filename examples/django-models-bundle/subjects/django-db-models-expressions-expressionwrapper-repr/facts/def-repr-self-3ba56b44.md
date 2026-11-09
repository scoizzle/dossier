# Fact 3ba56b44

Store id: 14794dca-6971-467a-bf94-a007f550bdc0

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
- posted_at: `2026-11-09T23:31:55.9379030+00:00`

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
  "id": "14794dca-6971-467a-bf94-a007f550bdc0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9379030+00:00"
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
  "subject_id": "a9d5b6b5-4af6-4b29-96a1-684fc4d54619",
  "subject_name": "django/db/models/expressions::ExpressionWrapper.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
