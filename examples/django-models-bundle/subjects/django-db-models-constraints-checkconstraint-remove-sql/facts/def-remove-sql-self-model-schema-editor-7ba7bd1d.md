# Fact 7ba7bd1d

Store id: df583df8-a05f-4d27-a8d6-6bca0916e3d1

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
- posted_at: `2026-11-09T23:31:54.1909100+00:00`

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
  "id": "df583df8-a05f-4d27-a8d6-6bca0916e3d1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:54.1909100+00:00"
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
  "subject_id": "a5ae139a-56c4-4e02-bc21-60f3c0b72258",
  "subject_name": "django/db/models/constraints::CheckConstraint.remove_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def remove_sql(self, model, schema_editor)"
}
```
