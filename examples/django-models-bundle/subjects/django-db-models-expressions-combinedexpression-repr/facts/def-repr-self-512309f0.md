# Fact 512309f0

Store id: 05792f3f-393d-44d2-ade9-9c10e5d970b9

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
- posted_at: `2026-11-09T23:31:55.8106580+00:00`

## Data

```json
{
  "end_line": 736,
  "entity_kind": "method",
  "parent": "CombinedExpression",
  "start_line": 735,
  "symbol": "CombinedExpression.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":735,"selector":"L735-L736","symbol":"CombinedExpression.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::CombinedExpression.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 736,
    "entity_kind": "method",
    "parent": "CombinedExpression",
    "start_line": 735,
    "symbol": "CombinedExpression.__repr__"
  },
  "id": "05792f3f-393d-44d2-ade9-9c10e5d970b9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8106580+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 735,
        "selector": "L735-L736",
        "symbol": "CombinedExpression.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "389bb506-6732-49e0-87f1-c3ca16d981d7",
  "subject_name": "django/db/models/expressions::CombinedExpression.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
