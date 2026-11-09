# Fact 25d95599

Store id: 9451f730-1bc6-4372-b2ec-55aa31bfd051

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
- posted_at: `2026-11-09T23:31:54.1764010+00:00`

## Data

```json
{
  "end_line": 203,
  "entity_kind": "method",
  "parent": "CheckConstraint",
  "start_line": 201,
  "symbol": "CheckConstraint.constraint_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":201,"selector":"L201-L203","symbol":"CheckConstraint.constraint_sql"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::CheckConstraint.constraint_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 203,
    "entity_kind": "method",
    "parent": "CheckConstraint",
    "start_line": 201,
    "symbol": "CheckConstraint.constraint_sql"
  },
  "id": "9451f730-1bc6-4372-b2ec-55aa31bfd051",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:54.1764010+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 201,
        "selector": "L201-L203",
        "symbol": "CheckConstraint.constraint_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "6f52a0e0-0bc6-4226-88af-8e79ac093353",
  "subject_name": "django/db/models/constraints::CheckConstraint.constraint_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def constraint_sql(self, model, schema_editor)"
}
```
