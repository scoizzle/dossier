# Fact 1c394c02

Store id: 5fd997ec-b57c-4b66-9a0f-d390dd85dc05

## Text

```text
class Subquery(BaseExpression, Combinable)
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
- posted_at: `2026-11-09T22:39:41.7192300+00:00`

## Data

```json
{
  "end_line": 1884,
  "entity_kind": "class",
  "parent": "expressions",
  "start_line": 1816,
  "symbol": "Subquery"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1816,"selector":"L1816-L1884","symbol":"Subquery"}`

## Items

```json
[
  {
    "text": "An explicit subquery. It may contain OuterRef() references to the outer query which will be resolved when it is applied to that query.",
    "locator": {
      "line": 1817
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/expressions::Subquery](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1884,
    "entity_kind": "class",
    "parent": "expressions",
    "start_line": 1816,
    "symbol": "Subquery"
  },
  "id": "5fd997ec-b57c-4b66-9a0f-d390dd85dc05",
  "items": [
    {
      "locator": {
        "line": 1817
      },
      "text": "An explicit subquery. It may contain OuterRef() references to the outer query which will be resolved when it is applied to that query."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7192300+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1816,
        "selector": "L1816-L1884",
        "symbol": "Subquery"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "9cdad3a8-8a40-478d-a35b-9d3ff4b6aa64",
  "subject_name": "django/db/models/expressions::Subquery",
  "tags": [
    "entity:class"
  ],
  "text": "class Subquery(BaseExpression, Combinable)"
}
```
