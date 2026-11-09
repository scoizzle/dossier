# Fact d7dc311e

Store id: cc334292-93e8-4da6-b1d2-36af1cb22223

## Text

```text
def __str__(self)
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
- posted_at: `2026-11-09T22:39:41.6589550+00:00`

## Data

```json
{
  "end_line": 1498,
  "entity_kind": "method",
  "parent": "ExpressionList",
  "start_line": 1497,
  "symbol": "ExpressionList.__str__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1497,"selector":"L1497-L1498","symbol":"ExpressionList.__str__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::ExpressionList.__str__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1498,
    "entity_kind": "method",
    "parent": "ExpressionList",
    "start_line": 1497,
    "symbol": "ExpressionList.__str__"
  },
  "id": "cc334292-93e8-4da6-b1d2-36af1cb22223",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6589550+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1497,
        "selector": "L1497-L1498",
        "symbol": "ExpressionList.__str__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "9308edd3-d2c4-4a55-b36b-47f2990a328e",
  "subject_name": "django/db/models/expressions::ExpressionList.__str__",
  "tags": [
    "entity:method"
  ],
  "text": "def __str__(self)"
}
```
