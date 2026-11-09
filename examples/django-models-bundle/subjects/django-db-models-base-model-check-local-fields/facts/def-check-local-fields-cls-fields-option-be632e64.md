# Fact be632e64

Store id: c8c883ee-8f86-4d7d-bdc2-5c9a2aadafcd

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
- posted_at: `2026-11-09T23:31:53.7677980+00:00`

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
  "id": "c8c883ee-8f86-4d7d-bdc2-5c9a2aadafcd",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7677980+00:00"
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
  "subject_id": "4038af70-1f42-40e6-9e86-08bef65b2c96",
  "subject_name": "django/db/models/base::Model._check_local_fields",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _check_local_fields(cls, fields, option)"
}
```
