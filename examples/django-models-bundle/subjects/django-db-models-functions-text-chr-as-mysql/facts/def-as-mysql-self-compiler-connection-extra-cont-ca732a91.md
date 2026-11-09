# Fact ca732a91

Store id: e14c347e-9aea-468e-b2bf-ec4a7093fae2

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
- posted_at: `2026-11-09T23:32:02.1399810+00:00`

## Data

```json
{
  "end_line": 54,
  "entity_kind": "method",
  "parent": "Chr",
  "start_line": 47,
  "symbol": "Chr.as_mysql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":47,"selector":"L47-L54","symbol":"Chr.as_mysql"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::Chr.as_mysql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 54,
    "entity_kind": "method",
    "parent": "Chr",
    "start_line": 47,
    "symbol": "Chr.as_mysql"
  },
  "id": "e14c347e-9aea-468e-b2bf-ec4a7093fae2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.1399810+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 47,
        "selector": "L47-L54",
        "symbol": "Chr.as_mysql"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "673746ff-9f32-4a86-919c-7f5487cf88e0",
  "subject_name": "django/db/models/functions/text::Chr.as_mysql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_mysql(self, compiler, connection, **extra_context)"
}
```
