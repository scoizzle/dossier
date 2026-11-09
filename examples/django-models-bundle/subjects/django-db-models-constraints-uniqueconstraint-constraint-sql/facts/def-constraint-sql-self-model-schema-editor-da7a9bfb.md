# Fact da7a9bfb

Store id: 94b37523-262f-4131-a40b-9c8b5cf2cc38

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
- posted_at: `2026-11-09T23:31:54.2422580+00:00`

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
  "id": "94b37523-262f-4131-a40b-9c8b5cf2cc38",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:54.2422580+00:00"
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
  "subject_id": "9d72fe6f-0d54-4790-8189-5eef7dc364be",
  "subject_name": "django/db/models/constraints::UniqueConstraint.constraint_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def constraint_sql(self, model, schema_editor)"
}
```
