# Fact 70cea43a

Store id: e2fd4843-51c6-4659-bb1c-dcbb6d0f747a

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
- posted_at: `2026-11-09T22:39:40.7062810+00:00`

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
  "id": "e2fd4843-51c6-4659-bb1c-dcbb6d0f747a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.7062810+00:00"
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
  "subject_id": "4107eecc-a254-4078-b17b-220c9a4794e8",
  "subject_name": "django/db/models/constraints::BaseConstraint.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
