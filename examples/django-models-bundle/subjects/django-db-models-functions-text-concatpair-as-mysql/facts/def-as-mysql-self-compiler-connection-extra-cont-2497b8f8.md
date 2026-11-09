# Fact 2497b8f8

Store id: f566ba56-3dfb-4e71-b3f9-09e677ff9e98

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
- posted_at: `2026-11-09T22:39:47.0848730+00:00`

## Data

```json
{
  "end_line": 110,
  "entity_kind": "method",
  "parent": "ConcatPair",
  "start_line": 102,
  "symbol": "ConcatPair.as_mysql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":102,"selector":"L102-L110","symbol":"ConcatPair.as_mysql"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::ConcatPair.as_mysql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 110,
    "entity_kind": "method",
    "parent": "ConcatPair",
    "start_line": 102,
    "symbol": "ConcatPair.as_mysql"
  },
  "id": "f566ba56-3dfb-4e71-b3f9-09e677ff9e98",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.0848730+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 102,
        "selector": "L102-L110",
        "symbol": "ConcatPair.as_mysql"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "7d5a03d4-d129-4417-a009-d476424234e0",
  "subject_name": "django/db/models/functions/text::ConcatPair.as_mysql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_mysql(self, compiler, connection, **extra_context)"
}
```
