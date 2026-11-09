# Fact 8d3d325e

Store id: 6b432d00-edc2-4769-b0c0-2b0e04904074

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
- posted_at: `2026-11-09T22:39:46.6620430+00:00`

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
  "id": "6b432d00-edc2-4769-b0c0-2b0e04904074",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.6620430+00:00"
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
  "subject_id": "a78a51b6-ec6d-468b-9b5d-953663441a02",
  "subject_name": "django/db/models/functions/math::Random.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection, **extra_context)"
}
```
