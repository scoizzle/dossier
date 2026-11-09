# Fact 7622a96a

Store id: 46191e2b-3dc8-46d7-8284-25428ef313df

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
- posted_at: `2026-11-09T22:39:41.6705980+00:00`

## Data

```json
{
  "end_line": 1559,
  "entity_kind": "method",
  "parent": "ExpressionWrapper",
  "start_line": 1558,
  "symbol": "ExpressionWrapper.set_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1558,"selector":"L1558-L1559","symbol":"ExpressionWrapper.set_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::ExpressionWrapper.set_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1559,
    "entity_kind": "method",
    "parent": "ExpressionWrapper",
    "start_line": 1558,
    "symbol": "ExpressionWrapper.set_source_expressions"
  },
  "id": "46191e2b-3dc8-46d7-8284-25428ef313df",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6705980+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1558,
        "selector": "L1558-L1559",
        "symbol": "ExpressionWrapper.set_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "8f2ba082-a29f-481a-abed-f30ec62453b2",
  "subject_name": "django/db/models/expressions::ExpressionWrapper.set_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def set_source_expressions(self, exprs)"
}
```
