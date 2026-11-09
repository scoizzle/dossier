# Fact c4df396e

Store id: 5418e3ba-6bfc-493a-b619-cd91b074f145

## Text

```text
def _check_constraints(cls, databases)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class_method`, `decorator:classmethod`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:53.7737440+00:00`

## Data

```json
{
  "end_line": 2522,
  "entity_kind": "class_method",
  "parent": "Model",
  "start_line": 2513,
  "symbol": "Model._check_constraints"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2513,"selector":"L2513-L2522","symbol":"Model._check_constraints"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model._check_constraints](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2522,
    "entity_kind": "class_method",
    "parent": "Model",
    "start_line": 2513,
    "symbol": "Model._check_constraints"
  },
  "id": "5418e3ba-6bfc-493a-b619-cd91b074f145",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7737440+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2513,
        "selector": "L2513-L2522",
        "symbol": "Model._check_constraints"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "ea0bd41c-b902-44b7-8b94-a0879b6cb9ff",
  "subject_name": "django/db/models/base::Model._check_constraints",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _check_constraints(cls, databases)"
}
```
