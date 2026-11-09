# Fact 8ec44c95

Store id: 4a0fa2c5-2174-4082-9241-2b9fcd6a039b

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
- posted_at: `2026-11-09T23:44:49.4437140+00:00`

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
  "id": "4a0fa2c5-2174-4082-9241-2b9fcd6a039b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.4437140+00:00"
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
  "subject_id": "cd5e1a1e-e145-4c95-b9fe-1d06991ad41e",
  "subject_name": "django/db/models/expressions::CombinedExpression.set_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def set_source_expressions(self, exprs)"
}
```
