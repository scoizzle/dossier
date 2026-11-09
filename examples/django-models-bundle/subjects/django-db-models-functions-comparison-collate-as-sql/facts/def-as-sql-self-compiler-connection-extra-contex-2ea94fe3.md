# Fact 2ea94fe3

Store id: c613a28c-df10-42c7-82c2-7cabf9beebf2

## Text

```text
def as_sql(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T23:44:53.1637580+00:00`

## Data

```json
{
  "end_line": 120,
  "entity_kind": "method",
  "parent": "Collate",
  "start_line": 118,
  "symbol": "Collate.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/comparison.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":118,"selector":"L118-L120","symbol":"Collate.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/functions/comparison::Collate.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 120,
    "entity_kind": "method",
    "parent": "Collate",
    "start_line": 118,
    "symbol": "Collate.as_sql"
  },
  "id": "c613a28c-df10-42c7-82c2-7cabf9beebf2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.1637580+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 118,
        "selector": "L118-L120",
        "symbol": "Collate.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/comparison.py"
    }
  ],
  "status": "live",
  "subject_id": "f902a1f9-fbdc-4575-b4ae-781c87984002",
  "subject_name": "django/db/models/functions/comparison::Collate.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection, **extra_context)"
}
```
