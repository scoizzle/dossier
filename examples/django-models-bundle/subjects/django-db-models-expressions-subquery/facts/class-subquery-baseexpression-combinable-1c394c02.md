# Fact 1c394c02

Store id: 5df43202-8785-4f69-af15-0f89727bed7f

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
- posted_at: `2026-11-09T23:44:49.6340480+00:00`

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
  "id": "5df43202-8785-4f69-af15-0f89727bed7f",
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
    "posted_at": "2026-11-09T23:44:49.6340480+00:00"
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
  "subject_id": "3c6e1344-74dd-4839-95bd-9df832f5241c",
  "subject_name": "django/db/models/expressions::Subquery",
  "tags": [
    "entity:class"
  ],
  "text": "class Subquery(BaseExpression, Combinable)"
}
```
