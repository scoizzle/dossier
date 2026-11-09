# Fact 5729689b

Store id: 36ac222f-4f6e-4b97-9c07-5a4d8ba2b904

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
- posted_at: `2026-11-09T22:39:46.6255830+00:00`

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
  "id": "36ac222f-4f6e-4b97-9c07-5a4d8ba2b904",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.6255830+00:00"
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
  "subject_id": "0978289a-4d6f-4c36-a66c-07e85ac8ec19",
  "subject_name": "django/db/models/functions/math::Log.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection, **extra_context)"
}
```
