# Fact c4df396e

Store id: 2df578e7-7680-4c98-8828-5c98a1b3cc43

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
- posted_at: `2026-11-09T22:39:40.3677970+00:00`

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
  "id": "2df578e7-7680-4c98-8828-5c98a1b3cc43",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3677970+00:00"
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
  "subject_id": "f197b5eb-a4b4-48fe-8366-1b8c0c44dbb1",
  "subject_name": "django/db/models/base::Model._check_constraints",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _check_constraints(cls, databases)"
}
```
