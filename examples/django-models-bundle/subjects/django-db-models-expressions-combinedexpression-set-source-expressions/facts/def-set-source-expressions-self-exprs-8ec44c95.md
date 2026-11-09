# Fact 8ec44c95

Store id: 292663c7-d7a9-4466-9e0c-c0bd5920e8c0

## Text

```text
def set_source_expressions(self, exprs)
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
- posted_at: `2026-11-09T22:39:41.5469680+00:00`

## Data

```json
{
  "end_line": 745,
  "entity_kind": "method",
  "parent": "CombinedExpression",
  "start_line": 744,
  "symbol": "CombinedExpression.set_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":744,"selector":"L744-L745","symbol":"CombinedExpression.set_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::CombinedExpression.set_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 745,
    "entity_kind": "method",
    "parent": "CombinedExpression",
    "start_line": 744,
    "symbol": "CombinedExpression.set_source_expressions"
  },
  "id": "292663c7-d7a9-4466-9e0c-c0bd5920e8c0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5469680+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 744,
        "selector": "L744-L745",
        "symbol": "CombinedExpression.set_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "7e4c9e64-0256-4564-850d-037b1071cc74",
  "subject_name": "django/db/models/expressions::CombinedExpression.set_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def set_source_expressions(self, exprs)"
}
```
