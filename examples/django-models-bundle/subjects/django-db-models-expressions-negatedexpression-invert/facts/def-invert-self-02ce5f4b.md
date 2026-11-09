# Fact 02ce5f4b

Store id: 43405dc6-1e39-4e12-8ae3-fe71dae81d4e

## Text

```text
def __invert__(self)
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
- posted_at: `2026-11-09T22:39:41.6816840+00:00`

## Data

```json
{
  "end_line": 1591,
  "entity_kind": "method",
  "parent": "NegatedExpression",
  "start_line": 1590,
  "symbol": "NegatedExpression.__invert__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1590,"selector":"L1590-L1591","symbol":"NegatedExpression.__invert__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::NegatedExpression.__invert__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1591,
    "entity_kind": "method",
    "parent": "NegatedExpression",
    "start_line": 1590,
    "symbol": "NegatedExpression.__invert__"
  },
  "id": "43405dc6-1e39-4e12-8ae3-fe71dae81d4e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6816840+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1590,
        "selector": "L1590-L1591",
        "symbol": "NegatedExpression.__invert__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "fd89a321-a5c1-452c-b7f6-d1957a01c04a",
  "subject_name": "django/db/models/expressions::NegatedExpression.__invert__",
  "tags": [
    "entity:method"
  ],
  "text": "def __invert__(self)"
}
```
