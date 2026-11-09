# Fact 2797cf15

Store id: 387012ab-3ea4-4e7d-8a5d-41b134f0536f

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
- posted_at: `2026-11-09T22:39:40.6994800+00:00`

## Data

```json
{
  "end_line": 44,
  "entity_kind": "method",
  "parent": "BaseConstraint",
  "start_line": 43,
  "symbol": "BaseConstraint.constraint_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":43,"selector":"L43-L44","symbol":"BaseConstraint.constraint_sql"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::BaseConstraint.constraint_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 44,
    "entity_kind": "method",
    "parent": "BaseConstraint",
    "start_line": 43,
    "symbol": "BaseConstraint.constraint_sql"
  },
  "id": "387012ab-3ea4-4e7d-8a5d-41b134f0536f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.6994800+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 43,
        "selector": "L43-L44",
        "symbol": "BaseConstraint.constraint_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "28bce564-3ba0-42f5-91af-e886bc2c7abf",
  "subject_name": "django/db/models/constraints::BaseConstraint.constraint_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def constraint_sql(self, model, schema_editor)"
}
```
