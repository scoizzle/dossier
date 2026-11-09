# Fact be632e64

Store id: dc361da4-fe3e-41e3-a09c-05d9a416b6b0

## Text

```text
def _check_local_fields(cls, fields, option)
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
- posted_at: `2026-11-09T22:39:40.3630850+00:00`

## Data

```json
{
  "end_line": 2283,
  "entity_kind": "class_method",
  "parent": "Model",
  "start_line": 2206,
  "symbol": "Model._check_local_fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2206,"selector":"L2206-L2283","symbol":"Model._check_local_fields"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model._check_local_fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2283,
    "entity_kind": "class_method",
    "parent": "Model",
    "start_line": 2206,
    "symbol": "Model._check_local_fields"
  },
  "id": "dc361da4-fe3e-41e3-a09c-05d9a416b6b0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3630850+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2206,
        "selector": "L2206-L2283",
        "symbol": "Model._check_local_fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "d570f1c2-8701-4523-8e8c-5396710820ff",
  "subject_name": "django/db/models/base::Model._check_local_fields",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _check_local_fields(cls, fields, option)"
}
```
