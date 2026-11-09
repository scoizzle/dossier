# Fact 2797cf15

Store id: 3d80d613-b956-4d80-8cd4-d1078a3aeb99

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
- posted_at: `2026-11-09T23:44:48.7718600+00:00`

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
  "id": "3d80d613-b956-4d80-8cd4-d1078a3aeb99",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.7718600+00:00"
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
  "subject_id": "c4daff7a-36d2-4653-a941-99bcd724466b",
  "subject_name": "django/db/models/constraints::BaseConstraint.constraint_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def constraint_sql(self, model, schema_editor)"
}
```
