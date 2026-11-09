# Fact e2ed21a6

Store id: f3a116c0-7f7a-40db-b0b9-1ea78c2f3c5d

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
- posted_at: `2026-11-09T23:31:55.8115600+00:00`

## Data

```json
{
  "end_line": 739,
  "entity_kind": "method",
  "parent": "CombinedExpression",
  "start_line": 738,
  "symbol": "CombinedExpression.__str__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":738,"selector":"L738-L739","symbol":"CombinedExpression.__str__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::CombinedExpression.__str__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 739,
    "entity_kind": "method",
    "parent": "CombinedExpression",
    "start_line": 738,
    "symbol": "CombinedExpression.__str__"
  },
  "id": "f3a116c0-7f7a-40db-b0b9-1ea78c2f3c5d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8115600+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 738,
        "selector": "L738-L739",
        "symbol": "CombinedExpression.__str__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "e151418b-3e0e-4b43-aea2-2b19df9e8231",
  "subject_name": "django/db/models/expressions::CombinedExpression.__str__",
  "tags": [
    "entity:method"
  ],
  "text": "def __str__(self)"
}
```
