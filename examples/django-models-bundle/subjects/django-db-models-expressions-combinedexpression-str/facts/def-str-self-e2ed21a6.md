# Fact e2ed21a6

Store id: 875da5bf-b215-4ffe-8637-461cc08ccc98

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
- posted_at: `2026-11-09T22:39:41.5455650+00:00`

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
  "id": "875da5bf-b215-4ffe-8637-461cc08ccc98",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5455650+00:00"
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
  "subject_id": "5b372c94-83d2-48b4-9c9b-fb74abaf66c7",
  "subject_name": "django/db/models/expressions::CombinedExpression.__str__",
  "tags": [
    "entity:method"
  ],
  "text": "def __str__(self)"
}
```
