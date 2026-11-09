# Fact 44968b01

Store id: 1f647fc4-1763-4eba-8c03-688a962764d9

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
- posted_at: `2026-11-09T23:44:48.5261450+00:00`

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
  "id": "1f647fc4-1763-4eba-8c03-688a962764d9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5261450+00:00"
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
  "subject_id": "4835e8da-ae30-4773-bd82-11b2eb154ccb",
  "subject_name": "django/db/models/base::Model.from_db",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def from_db(cls, db, field_names, values, *, fetch_mode=None)"
}
```
