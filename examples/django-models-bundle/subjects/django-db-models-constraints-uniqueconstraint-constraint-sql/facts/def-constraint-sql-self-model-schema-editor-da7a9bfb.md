# Fact da7a9bfb

Store id: dcc17a93-f5bf-481e-af7e-2ad4398d6a58

## Text

```text
def constraint_sql(self, model, schema_editor)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:40.7270130+00:00`

## Data

```json
{
  "end_line": 480,
  "entity_kind": "method",
  "parent": "UniqueConstraint",
  "start_line": 463,
  "symbol": "UniqueConstraint.constraint_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":463,"selector":"L463-L480","symbol":"UniqueConstraint.constraint_sql"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::UniqueConstraint.constraint_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 480,
    "entity_kind": "method",
    "parent": "UniqueConstraint",
    "start_line": 463,
    "symbol": "UniqueConstraint.constraint_sql"
  },
  "id": "dcc17a93-f5bf-481e-af7e-2ad4398d6a58",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.7270130+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 463,
        "selector": "L463-L480",
        "symbol": "UniqueConstraint.constraint_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "d4eccdc0-1c6d-456a-8179-909b8cf79ffd",
  "subject_name": "django/db/models/constraints::UniqueConstraint.constraint_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def constraint_sql(self, model, schema_editor)"
}
```
