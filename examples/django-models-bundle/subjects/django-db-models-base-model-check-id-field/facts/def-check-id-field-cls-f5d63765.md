# Fact f5d63765

Store id: 1417d69f-38b7-4584-9a69-ca71fb301be5

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
- posted_at: `2026-11-09T23:44:48.5492810+00:00`

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
  "id": "1417d69f-38b7-4584-9a69-ca71fb301be5",
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
    "posted_at": "2026-11-09T23:44:48.5492810+00:00"
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
  "subject_id": "5ffe671d-4b15-4cae-83c6-bc26ca76015b",
  "subject_name": "django/db/models/base::Model._check_id_field",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _check_id_field(cls)"
}
```
