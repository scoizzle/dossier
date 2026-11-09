# Fact 81d8889f

Store id: 60f324ee-a1c9-47d7-b23e-370d73f604f0

## Text

```text
class BaseConstraint
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
- posted_at: `2026-11-09T23:31:54.1022250+00:00`

## Data

```json
{
  "end_line": 132,
  "entity_kind": "class",
  "parent": "constraints",
  "start_line": 21,
  "symbol": "BaseConstraint"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":21,"selector":"L21-L132","symbol":"BaseConstraint"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::BaseConstraint](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 132,
    "entity_kind": "class",
    "parent": "constraints",
    "start_line": 21,
    "symbol": "BaseConstraint"
  },
  "id": "60f324ee-a1c9-47d7-b23e-370d73f604f0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:54.1022250+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 21,
        "selector": "L21-L132",
        "symbol": "BaseConstraint"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "92fbf9bf-4573-42c3-8be9-d5a65afec29a",
  "subject_name": "django/db/models/constraints::BaseConstraint",
  "tags": [
    "entity:class"
  ],
  "text": "class BaseConstraint"
}
```
