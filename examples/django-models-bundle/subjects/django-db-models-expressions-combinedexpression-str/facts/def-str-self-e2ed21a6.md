# Fact e2ed21a6

Store id: c0a5e0c8-f36b-499c-9f3a-fa3ff9dba078

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
- posted_at: `2026-11-09T23:44:49.4388420+00:00`

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
  "id": "c0a5e0c8-f36b-499c-9f3a-fa3ff9dba078",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.4388420+00:00"
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
  "subject_id": "6de49910-740b-44a5-a241-47d9a71d32f9",
  "subject_name": "django/db/models/expressions::CombinedExpression.__str__",
  "tags": [
    "entity:method"
  ],
  "text": "def __str__(self)"
}
```
