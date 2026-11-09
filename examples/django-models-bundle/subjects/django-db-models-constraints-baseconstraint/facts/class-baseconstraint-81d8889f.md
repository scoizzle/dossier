# Fact 81d8889f

Store id: 32b9f504-fac8-429e-8f19-6cc538d40309

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
- posted_at: `2026-11-09T22:39:40.6860780+00:00`

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
  "id": "32b9f504-fac8-429e-8f19-6cc538d40309",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.6860780+00:00"
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
  "subject_id": "55b67712-493f-4e5b-b187-c7804ec699d2",
  "subject_name": "django/db/models/constraints::BaseConstraint",
  "tags": [
    "entity:class"
  ],
  "text": "class BaseConstraint"
}
```
