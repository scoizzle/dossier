# Fact 3a002ad5

Store id: f0f74b69-5af9-40ff-beb4-a9c314cec165

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
- posted_at: `2026-11-09T23:32:01.6755710+00:00`

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
  "id": "f0f74b69-5af9-40ff-beb4-a9c314cec165",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.6755710+00:00"
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
  "subject_id": "f1705cdb-5472-40c6-82c9-61fccb38aea8",
  "subject_name": "django/db/models/functions/math::ATan2.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection, **extra_context)"
}
```
