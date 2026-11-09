# Fact 3d5373de

Store id: 07ba81b3-5ca5-430a-8a4f-6ce0b92feff6

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
- posted_at: `2026-11-09T22:39:41.5512940+00:00`

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
  "id": "07ba81b3-5ca5-430a-8a4f-6ce0b92feff6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5512940+00:00"
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
  "subject_id": "d2079e24-0502-41e9-bd72-484a8f544c01",
  "subject_name": "django/db/models/expressions::DurationExpression",
  "tags": [
    "entity:class"
  ],
  "text": "class DurationExpression(CombinedExpression)"
}
```
