# Fact 943214d2

Store id: 6bbdbe08-0086-4e34-9eef-3e4e573202c5

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
- posted_at: `2026-11-09T22:39:51.9956690+00:00`

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
  "id": "6bbdbe08-0086-4e34-9eef-3e4e573202c5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.9956690+00:00"
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
  "subject_id": "c0596ff8-181b-40a8-a5cf-b345d83e9ab1",
  "subject_name": "django/db/models/sql/where::ExtraWhere.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler=None, connection=None)"
}
```
