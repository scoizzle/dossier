# Fact 935c248c

Store id: ed0a33bb-5220-4677-a347-930b63c21d2f

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
- posted_at: `2026-11-09T23:31:53.5482380+00:00`

## Data

```json
{
  "end_line": 449,
  "entity_kind": "method",
  "parent": "StringAgg",
  "start_line": 422,
  "symbol": "StringAgg.as_sqlite"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":422,"selector":"L422-L449","symbol":"StringAgg.as_sqlite"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::StringAgg.as_sqlite](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 449,
    "entity_kind": "method",
    "parent": "StringAgg",
    "start_line": 422,
    "symbol": "StringAgg.as_sqlite"
  },
  "id": "ed0a33bb-5220-4677-a347-930b63c21d2f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.5482380+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 422,
        "selector": "L422-L449",
        "symbol": "StringAgg.as_sqlite"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "c79203e4-dc26-4940-aff0-1d5334ee8eca",
  "subject_name": "django/db/models/aggregates::StringAgg.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection, **extra_context)"
}
```
