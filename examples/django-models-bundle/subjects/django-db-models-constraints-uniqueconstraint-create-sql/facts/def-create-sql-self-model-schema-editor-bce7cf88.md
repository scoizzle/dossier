# Fact bce7cf88

Store id: 7ca7b2e5-7693-4d3a-89db-40e52653a113

## Text

```text
def create_sql(self, model, schema_editor)
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
- posted_at: `2026-11-09T22:39:40.7276200+00:00`

## Data

```json
{
  "end_line": 499,
  "entity_kind": "method",
  "parent": "UniqueConstraint",
  "start_line": 482,
  "symbol": "UniqueConstraint.create_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":482,"selector":"L482-L499","symbol":"UniqueConstraint.create_sql"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::UniqueConstraint.create_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 499,
    "entity_kind": "method",
    "parent": "UniqueConstraint",
    "start_line": 482,
    "symbol": "UniqueConstraint.create_sql"
  },
  "id": "7ca7b2e5-7693-4d3a-89db-40e52653a113",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.7276200+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 482,
        "selector": "L482-L499",
        "symbol": "UniqueConstraint.create_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "3e064cd3-7c62-453d-82df-4f90ed7a3b54",
  "subject_name": "django/db/models/constraints::UniqueConstraint.create_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def create_sql(self, model, schema_editor)"
}
```
