# Fact 1c394c02

Store id: 111bb5b1-a7f6-47fb-b6b3-0f9510b1cbf7

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
- posted_at: `2026-11-09T23:31:55.9668700+00:00`

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
  "id": "111bb5b1-a7f6-47fb-b6b3-0f9510b1cbf7",
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
    "posted_at": "2026-11-09T23:31:55.9668700+00:00"
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
  "subject_id": "63d4e49d-e5ca-4c49-8162-f4530a9d9bf0",
  "subject_name": "django/db/models/expressions::Subquery",
  "tags": [
    "entity:class"
  ],
  "text": "class Subquery(BaseExpression, Combinable)"
}
```
