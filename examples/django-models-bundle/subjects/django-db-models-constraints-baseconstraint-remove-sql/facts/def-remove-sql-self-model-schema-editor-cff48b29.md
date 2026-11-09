# Fact cff48b29

Store id: 74e114ef-d71a-4da4-890f-50758c0abe36

## Text

```text
def remove_sql(self, model, schema_editor)
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
- posted_at: `2026-11-09T23:31:54.1438250+00:00`

## Data

```json
{
  "end_line": 50,
  "entity_kind": "method",
  "parent": "BaseConstraint",
  "start_line": 49,
  "symbol": "BaseConstraint.remove_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":49,"selector":"L49-L50","symbol":"BaseConstraint.remove_sql"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::BaseConstraint.remove_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 50,
    "entity_kind": "method",
    "parent": "BaseConstraint",
    "start_line": 49,
    "symbol": "BaseConstraint.remove_sql"
  },
  "id": "74e114ef-d71a-4da4-890f-50758c0abe36",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:54.1438250+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 49,
        "selector": "L49-L50",
        "symbol": "BaseConstraint.remove_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "1ea8c3d8-8fe7-4ea0-9786-37f3a5db2e36",
  "subject_name": "django/db/models/constraints::BaseConstraint.remove_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def remove_sql(self, model, schema_editor)"
}
```
