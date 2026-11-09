# Fact 2c34d042

Store id: 0f90d7a2-c875-45dc-8b03-81c55dd2b0ab

## Text

```text
def compile(self, side, compiler, connection)
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
- posted_at: `2026-11-09T22:39:41.5520510+00:00`

## Data

```json
{
  "end_line": 825,
  "entity_kind": "method",
  "parent": "DurationExpression",
  "start_line": 816,
  "symbol": "DurationExpression.compile"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":816,"selector":"L816-L825","symbol":"DurationExpression.compile"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::DurationExpression.compile](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 825,
    "entity_kind": "method",
    "parent": "DurationExpression",
    "start_line": 816,
    "symbol": "DurationExpression.compile"
  },
  "id": "0f90d7a2-c875-45dc-8b03-81c55dd2b0ab",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5520510+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 816,
        "selector": "L816-L825",
        "symbol": "DurationExpression.compile"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "36b83070-a994-48c8-bf60-898decae46fe",
  "subject_name": "django/db/models/expressions::DurationExpression.compile",
  "tags": [
    "entity:method"
  ],
  "text": "def compile(self, side, compiler, connection)"
}
```
