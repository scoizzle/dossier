# Fact 70cea43a

Store id: 29789d87-9f49-44bf-95d2-5154b7d9f139

## Text

```text
def deconstruct(self)
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
- posted_at: `2026-11-09T23:44:48.7760680+00:00`

## Data

```json
{
  "end_line": 128,
  "entity_kind": "method",
  "parent": "BaseConstraint",
  "start_line": 117,
  "symbol": "BaseConstraint.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":117,"selector":"L117-L128","symbol":"BaseConstraint.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::BaseConstraint.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 128,
    "entity_kind": "method",
    "parent": "BaseConstraint",
    "start_line": 117,
    "symbol": "BaseConstraint.deconstruct"
  },
  "id": "29789d87-9f49-44bf-95d2-5154b7d9f139",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.7760680+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 117,
        "selector": "L117-L128",
        "symbol": "BaseConstraint.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "f6e58e27-64b6-43c9-8d20-fb710972d168",
  "subject_name": "django/db/models/constraints::BaseConstraint.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
