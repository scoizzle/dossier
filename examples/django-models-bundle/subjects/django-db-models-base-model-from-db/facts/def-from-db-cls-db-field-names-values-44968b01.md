# Fact 44968b01

Store id: f047c452-c1f9-49ef-9802-0c2704cba9e5

## Text

```text
def from_db(cls, db, field_names, values, *, fetch_mode=None)
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
- posted_at: `2026-11-09T22:39:40.3319760+00:00`

## Data

```json
{
  "end_line": 630,
  "entity_kind": "class_method",
  "parent": "Model",
  "start_line": 617,
  "symbol": "Model.from_db"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":617,"selector":"L617-L630","symbol":"Model.from_db"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model.from_db](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 630,
    "entity_kind": "class_method",
    "parent": "Model",
    "start_line": 617,
    "symbol": "Model.from_db"
  },
  "id": "f047c452-c1f9-49ef-9802-0c2704cba9e5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3319760+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 617,
        "selector": "L617-L630",
        "symbol": "Model.from_db"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "d2c47845-c55b-446e-8ea9-5ee7c0fa28a1",
  "subject_name": "django/db/models/base::Model.from_db",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def from_db(cls, db, field_names, values, *, fetch_mode=None)"
}
```
