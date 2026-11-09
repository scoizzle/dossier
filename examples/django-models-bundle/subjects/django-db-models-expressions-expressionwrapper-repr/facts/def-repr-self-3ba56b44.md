# Fact 3ba56b44

Store id: 8eb9bdd6-c2af-4f88-b877-816c0ee16f10

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
- posted_at: `2026-11-09T23:44:49.5990060+00:00`

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
  "id": "8eb9bdd6-c2af-4f88-b877-816c0ee16f10",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5990060+00:00"
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
  "subject_id": "2605509b-d57f-41df-89c2-af61fb7ef37e",
  "subject_name": "django/db/models/expressions::ExpressionWrapper.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
