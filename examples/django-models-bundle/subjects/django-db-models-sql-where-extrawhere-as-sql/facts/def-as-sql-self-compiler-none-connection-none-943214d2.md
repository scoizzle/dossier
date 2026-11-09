# Fact 943214d2

Store id: 75c50df3-94aa-46cd-a937-a68ad6b82877

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
- posted_at: `2026-11-09T23:44:59.8450920+00:00`

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
  "id": "75c50df3-94aa-46cd-a937-a68ad6b82877",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:59.8450920+00:00"
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
  "subject_id": "60012126-6942-49e1-8b08-6cf991eb9bec",
  "subject_name": "django/db/models/sql/where::ExtraWhere.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler=None, connection=None)"
}
```
