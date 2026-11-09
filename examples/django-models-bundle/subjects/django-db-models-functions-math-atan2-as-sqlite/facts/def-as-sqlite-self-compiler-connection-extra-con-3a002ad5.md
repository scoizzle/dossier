# Fact 3a002ad5

Store id: faed4b79-9fe6-4299-a341-c3bf0170ef0e

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
- posted_at: `2026-11-09T22:39:46.5767480+00:00`

## Data

```json
{
  "end_line": 58,
  "entity_kind": "method",
  "parent": "ATan2",
  "start_line": 37,
  "symbol": "ATan2.as_sqlite"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":37,"selector":"L37-L58","symbol":"ATan2.as_sqlite"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::ATan2.as_sqlite](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 58,
    "entity_kind": "method",
    "parent": "ATan2",
    "start_line": 37,
    "symbol": "ATan2.as_sqlite"
  },
  "id": "faed4b79-9fe6-4299-a341-c3bf0170ef0e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.5767480+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 37,
        "selector": "L37-L58",
        "symbol": "ATan2.as_sqlite"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "0d8a9bc0-078d-4eb4-aa18-aca2a21ead98",
  "subject_name": "django/db/models/functions/math::ATan2.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection, **extra_context)"
}
```
