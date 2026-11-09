# Fact f5d63765

Store id: 1e88345d-db82-4898-a0ad-97544bfca1e9

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
- posted_at: `2026-11-09T22:39:40.3590850+00:00`

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
  "id": "1e88345d-db82-4898-a0ad-97544bfca1e9",
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
    "posted_at": "2026-11-09T22:39:40.3590850+00:00"
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
  "subject_id": "1a7d1d41-12c2-4a34-a3ca-5dfd4651c957",
  "subject_name": "django/db/models/base::Model._check_id_field",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _check_id_field(cls)"
}
```
