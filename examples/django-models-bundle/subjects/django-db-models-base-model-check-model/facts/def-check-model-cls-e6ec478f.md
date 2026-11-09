# Fact e6ec478f

Store id: 28731ebd-8df0-44b0-b329-b45f07473173

## Text

```text
def _check_model(cls)
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
- posted_at: `2026-11-09T23:44:48.5477040+00:00`

## Data

```json
{
  "end_line": 1933,
  "entity_kind": "class_method",
  "parent": "Model",
  "start_line": 1922,
  "symbol": "Model._check_model"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1922,"selector":"L1922-L1933","symbol":"Model._check_model"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model._check_model](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1933,
    "entity_kind": "class_method",
    "parent": "Model",
    "start_line": 1922,
    "symbol": "Model._check_model"
  },
  "id": "28731ebd-8df0-44b0-b329-b45f07473173",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5477040+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1922,
        "selector": "L1922-L1933",
        "symbol": "Model._check_model"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "338d179b-3660-40d8-9068-8f8b6271439f",
  "subject_name": "django/db/models/base::Model._check_model",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _check_model(cls)"
}
```
