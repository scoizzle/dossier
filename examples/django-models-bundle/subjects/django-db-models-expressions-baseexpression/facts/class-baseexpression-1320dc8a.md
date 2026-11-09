# Fact 1320dc8a

Store id: 93641084-a4d1-4ed2-95db-87cab8f2c4f8

## Text

```text
class BaseExpression
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
- posted_at: `2026-11-09T23:44:49.2643440+00:00`

## Data

```json
{
  "end_line": 516,
  "entity_kind": "class",
  "parent": "expressions",
  "start_line": 174,
  "symbol": "BaseExpression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":174,"selector":"L174-L516","symbol":"BaseExpression"}`

## Items

```json
[
  {
    "text": "Base class for all query expressions.",
    "locator": {
      "line": 175
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/expressions::BaseExpression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 516,
    "entity_kind": "class",
    "parent": "expressions",
    "start_line": 174,
    "symbol": "BaseExpression"
  },
  "id": "93641084-a4d1-4ed2-95db-87cab8f2c4f8",
  "items": [
    {
      "locator": {
        "line": 175
      },
      "text": "Base class for all query expressions."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.2643440+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 174,
        "selector": "L174-L516",
        "symbol": "BaseExpression"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "2e3773e5-7cc3-47c4-bf65-af996644824a",
  "subject_name": "django/db/models/expressions::BaseExpression",
  "tags": [
    "entity:class"
  ],
  "text": "class BaseExpression"
}
```
