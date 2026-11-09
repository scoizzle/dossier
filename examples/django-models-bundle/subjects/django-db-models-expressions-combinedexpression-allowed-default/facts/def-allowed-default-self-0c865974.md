# Fact 0c865974

Store id: fafe1fb2-5176-4eb3-86e6-92fe42ef73a1

## Text

```text
def allowed_default(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:41.5505350+00:00`

## Data

```json
{
  "end_line": 812,
  "entity_kind": "method",
  "parent": "CombinedExpression",
  "start_line": 810,
  "symbol": "CombinedExpression.allowed_default"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":810,"selector":"L810-L812","symbol":"CombinedExpression.allowed_default"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::CombinedExpression.allowed_default](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 812,
    "entity_kind": "method",
    "parent": "CombinedExpression",
    "start_line": 810,
    "symbol": "CombinedExpression.allowed_default"
  },
  "id": "fafe1fb2-5176-4eb3-86e6-92fe42ef73a1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5505350+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 810,
        "selector": "L810-L812",
        "symbol": "CombinedExpression.allowed_default"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "60c59852-d011-40ae-abb4-39ca1f28bb47",
  "subject_name": "django/db/models/expressions::CombinedExpression.allowed_default",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def allowed_default(self)"
}
```
