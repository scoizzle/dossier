# Fact f5d63765

Store id: 9ac366d0-5aaa-4201-9e16-cdb5e97bfa82

## Text

```text
def _check_id_field(cls)
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
- posted_at: `2026-11-09T23:31:53.7642540+00:00`

## Data

```json
{
  "end_line": 2008,
  "entity_kind": "class_method",
  "parent": "Model",
  "start_line": 1991,
  "symbol": "Model._check_id_field"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1991,"selector":"L1991-L2008","symbol":"Model._check_id_field"}`

## Items

```json
[
  {
    "text": "Check if `id` field is a primary key.",
    "locator": {
      "line": 1993
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/base::Model._check_id_field](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2008,
    "entity_kind": "class_method",
    "parent": "Model",
    "start_line": 1991,
    "symbol": "Model._check_id_field"
  },
  "id": "9ac366d0-5aaa-4201-9e16-cdb5e97bfa82",
  "items": [
    {
      "locator": {
        "line": 1993
      },
      "text": "Check if `id` field is a primary key."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7642540+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1991,
        "selector": "L1991-L2008",
        "symbol": "Model._check_id_field"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "995bd660-9387-4c2f-a38b-b9de78e720a1",
  "subject_name": "django/db/models/base::Model._check_id_field",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _check_id_field(cls)"
}
```
