# Fact c034629e

Store id: 748e31cd-24c8-4e19-92e5-06e794e584e5

## Text

```text
def as_mysql(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T22:39:40.0481970+00:00`

## Data

```json
{
  "end_line": 420,
  "entity_kind": "method",
  "parent": "StringAgg",
  "start_line": 400,
  "symbol": "StringAgg.as_mysql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":400,"selector":"L400-L420","symbol":"StringAgg.as_mysql"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::StringAgg.as_mysql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 420,
    "entity_kind": "method",
    "parent": "StringAgg",
    "start_line": 400,
    "symbol": "StringAgg.as_mysql"
  },
  "id": "748e31cd-24c8-4e19-92e5-06e794e584e5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.0481970+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 400,
        "selector": "L400-L420",
        "symbol": "StringAgg.as_mysql"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "ac022536-d830-4319-9b12-8bb054d0c2f9",
  "subject_name": "django/db/models/aggregates::StringAgg.as_mysql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_mysql(self, compiler, connection, **extra_context)"
}
```
