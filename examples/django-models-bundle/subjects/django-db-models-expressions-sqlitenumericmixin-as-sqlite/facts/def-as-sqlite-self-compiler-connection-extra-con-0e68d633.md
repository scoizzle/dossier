# Fact 0e68d633

Store id: c1396917-b6c8-480a-bd8b-8d5e9527815d

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
- posted_at: `2026-11-09T22:39:41.4693100+00:00`

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
  "id": "c1396917-b6c8-480a-bd8b-8d5e9527815d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.4693100+00:00"
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
  "subject_id": "f9751779-9a75-4e90-bfa8-c78eb47e17d7",
  "subject_name": "django/db/models/expressions::SQLiteNumericMixin.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection, **extra_context)"
}
```
