# Fact 3d5373de

Store id: 4b791bf6-2daa-4f22-8215-3877b515b75a

## Text

```text
class DurationExpression(CombinedExpression)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:55.8209530+00:00`

## Data

```json
{
  "end_line": 863,
  "entity_kind": "class",
  "parent": "expressions",
  "start_line": 815,
  "symbol": "DurationExpression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":815,"selector":"L815-L863","symbol":"DurationExpression"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::DurationExpression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 863,
    "entity_kind": "class",
    "parent": "expressions",
    "start_line": 815,
    "symbol": "DurationExpression"
  },
  "id": "4b791bf6-2daa-4f22-8215-3877b515b75a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8209530+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 815,
        "selector": "L815-L863",
        "symbol": "DurationExpression"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "3d9d6d5c-4241-4517-b9f3-da11d9791830",
  "subject_name": "django/db/models/expressions::DurationExpression",
  "tags": [
    "entity:class"
  ],
  "text": "class DurationExpression(CombinedExpression)"
}
```
