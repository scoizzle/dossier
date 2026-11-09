# Fact 943214d2

Store id: 66746ad7-8974-4361-84d0-8438a4ae5f98

## Text

```text
def as_sql(self, compiler=None, connection=None)
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
- posted_at: `2026-11-09T23:32:07.7258620+00:00`

## Data

```json
{
  "end_line": 345,
  "entity_kind": "method",
  "parent": "ExtraWhere",
  "start_line": 343,
  "symbol": "ExtraWhere.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/where.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":343,"selector":"L343-L345","symbol":"ExtraWhere.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/sql/where::ExtraWhere.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 345,
    "entity_kind": "method",
    "parent": "ExtraWhere",
    "start_line": 343,
    "symbol": "ExtraWhere.as_sql"
  },
  "id": "66746ad7-8974-4361-84d0-8438a4ae5f98",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.7258620+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 343,
        "selector": "L343-L345",
        "symbol": "ExtraWhere.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/where.py"
    }
  ],
  "status": "live",
  "subject_id": "e43885bc-2f08-4593-a019-964440da7105",
  "subject_name": "django/db/models/sql/where::ExtraWhere.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler=None, connection=None)"
}
```
