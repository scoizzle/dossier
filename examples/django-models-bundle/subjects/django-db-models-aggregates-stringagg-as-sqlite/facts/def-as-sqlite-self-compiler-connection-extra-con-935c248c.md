# Fact 935c248c

Store id: fde359f0-a689-49f1-8739-f494f94d2662

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
- posted_at: `2026-11-09T22:39:40.0485230+00:00`

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
  "id": "fde359f0-a689-49f1-8739-f494f94d2662",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.0485230+00:00"
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
  "subject_id": "b2c21b93-e99b-4e90-a84a-5cebf651c1b5",
  "subject_name": "django/db/models/aggregates::StringAgg.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection, **extra_context)"
}
```
