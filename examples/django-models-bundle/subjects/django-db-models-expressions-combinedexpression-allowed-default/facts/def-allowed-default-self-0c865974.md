# Fact 0c865974

Store id: 2f1a960a-bd37-4105-8eb9-8e623c9e5993

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
- posted_at: `2026-11-09T23:31:55.8202310+00:00`

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
  "id": "2f1a960a-bd37-4105-8eb9-8e623c9e5993",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8202310+00:00"
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
  "subject_id": "6e29a94e-06be-41f1-924e-576ef439a2ea",
  "subject_name": "django/db/models/expressions::CombinedExpression.allowed_default",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def allowed_default(self)"
}
```
