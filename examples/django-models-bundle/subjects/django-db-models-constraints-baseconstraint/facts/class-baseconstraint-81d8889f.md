# Fact 81d8889f

Store id: 44c9c779-4603-4ed3-8d3c-781b23e90a7f

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
- posted_at: `2026-11-09T23:44:48.7627230+00:00`

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
  "id": "44c9c779-4603-4ed3-8d3c-781b23e90a7f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.7627230+00:00"
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
  "subject_id": "d6f61764-247e-4a52-9324-5862b9a0bb1e",
  "subject_name": "django/db/models/constraints::BaseConstraint",
  "tags": [
    "entity:class"
  ],
  "text": "class BaseConstraint"
}
```
