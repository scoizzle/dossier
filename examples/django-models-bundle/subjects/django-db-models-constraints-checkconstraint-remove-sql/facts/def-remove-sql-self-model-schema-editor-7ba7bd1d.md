# Fact 7ba7bd1d

Store id: b75dc110-44db-480d-a2ad-a050fad2e91e

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
- posted_at: `2026-11-09T22:39:40.7128230+00:00`

## Data

```json
{
  "end_line": 210,
  "entity_kind": "method",
  "parent": "CheckConstraint",
  "start_line": 209,
  "symbol": "CheckConstraint.remove_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":209,"selector":"L209-L210","symbol":"CheckConstraint.remove_sql"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::CheckConstraint.remove_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 210,
    "entity_kind": "method",
    "parent": "CheckConstraint",
    "start_line": 209,
    "symbol": "CheckConstraint.remove_sql"
  },
  "id": "b75dc110-44db-480d-a2ad-a050fad2e91e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.7128230+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 209,
        "selector": "L209-L210",
        "symbol": "CheckConstraint.remove_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "371f7154-003a-497b-9f1d-dfd690ac2260",
  "subject_name": "django/db/models/constraints::CheckConstraint.remove_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def remove_sql(self, model, schema_editor)"
}
```
