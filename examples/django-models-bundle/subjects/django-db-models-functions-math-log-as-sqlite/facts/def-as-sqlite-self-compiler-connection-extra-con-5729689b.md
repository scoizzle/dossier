# Fact 5729689b

Store id: 9f438ecc-db35-4de8-9cd7-4a9e5846b813

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
- posted_at: `2026-11-09T23:32:01.7205110+00:00`

## Data

```json
{
  "end_line": 123,
  "entity_kind": "method",
  "parent": "Log",
  "start_line": 116,
  "symbol": "Log.as_sqlite"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":116,"selector":"L116-L123","symbol":"Log.as_sqlite"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::Log.as_sqlite](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 123,
    "entity_kind": "method",
    "parent": "Log",
    "start_line": 116,
    "symbol": "Log.as_sqlite"
  },
  "id": "9f438ecc-db35-4de8-9cd7-4a9e5846b813",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.7205110+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 116,
        "selector": "L116-L123",
        "symbol": "Log.as_sqlite"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "b6a7e59b-1905-410a-82f4-dcf40a64eed8",
  "subject_name": "django/db/models/functions/math::Log.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection, **extra_context)"
}
```
