# Fact 253a5ce0

Store id: a304b90d-f8fc-49bc-a206-fc0e3d6f8a81

## Text

```text
def _validate_force_insert(cls, force_insert)
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
- posted_at: `2026-11-09T22:39:40.3390000+00:00`

## Data

```json
{
  "end_line": 948,
  "entity_kind": "class_method",
  "parent": "Model",
  "start_line": 930,
  "symbol": "Model._validate_force_insert"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":930,"selector":"L930-L948","symbol":"Model._validate_force_insert"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model._validate_force_insert](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 948,
    "entity_kind": "class_method",
    "parent": "Model",
    "start_line": 930,
    "symbol": "Model._validate_force_insert"
  },
  "id": "a304b90d-f8fc-49bc-a206-fc0e3d6f8a81",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3390000+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 930,
        "selector": "L930-L948",
        "symbol": "Model._validate_force_insert"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "57a19025-d9a0-4b49-8720-d194e8dd9a20",
  "subject_name": "django/db/models/base::Model._validate_force_insert",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _validate_force_insert(cls, force_insert)"
}
```
