# Fact 8d3d325e

Store id: 34da1e6b-a9cc-4ff3-b39d-41f3e1bf614b

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
- posted_at: `2026-11-09T23:44:53.7565320+00:00`

## Data

```json
{
  "end_line": 172,
  "entity_kind": "method",
  "parent": "Random",
  "start_line": 171,
  "symbol": "Random.as_sqlite"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":171,"selector":"L171-L172","symbol":"Random.as_sqlite"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::Random.as_sqlite](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 172,
    "entity_kind": "method",
    "parent": "Random",
    "start_line": 171,
    "symbol": "Random.as_sqlite"
  },
  "id": "34da1e6b-a9cc-4ff3-b39d-41f3e1bf614b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.7565320+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 171,
        "selector": "L171-L172",
        "symbol": "Random.as_sqlite"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "9f7c2753-8e4a-4b67-8a2c-d42e7cddfece",
  "subject_name": "django/db/models/functions/math::Random.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection, **extra_context)"
}
```
