# Fact 0e68d633

Store id: 536c6cd6-fe9b-4d23-9f19-bfa3d606fbb2

## Text

```text
def as_sqlite(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T23:31:55.7220840+00:00`

## Data

```json
{
  "end_line": 35,
  "entity_kind": "method",
  "parent": "SQLiteNumericMixin",
  "start_line": 28,
  "symbol": "SQLiteNumericMixin.as_sqlite"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":28,"selector":"L28-L35","symbol":"SQLiteNumericMixin.as_sqlite"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::SQLiteNumericMixin.as_sqlite](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 35,
    "entity_kind": "method",
    "parent": "SQLiteNumericMixin",
    "start_line": 28,
    "symbol": "SQLiteNumericMixin.as_sqlite"
  },
  "id": "536c6cd6-fe9b-4d23-9f19-bfa3d606fbb2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.7220840+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 28,
        "selector": "L28-L35",
        "symbol": "SQLiteNumericMixin.as_sqlite"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "9dc82526-08cd-40cf-aa1e-c6bc3374966c",
  "subject_name": "django/db/models/expressions::SQLiteNumericMixin.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection, **extra_context)"
}
```
