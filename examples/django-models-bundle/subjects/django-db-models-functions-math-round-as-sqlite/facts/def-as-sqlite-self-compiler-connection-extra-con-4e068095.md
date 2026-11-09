# Fact 4e068095

Store id: 8da25bd7-15a9-4a46-a4d7-0b707aff2599

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
- posted_at: `2026-11-09T22:39:46.6737400+00:00`

## Data

```json
{
  "end_line": 190,
  "entity_kind": "method",
  "parent": "Round",
  "start_line": 186,
  "symbol": "Round.as_sqlite"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":186,"selector":"L186-L190","symbol":"Round.as_sqlite"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::Round.as_sqlite](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 190,
    "entity_kind": "method",
    "parent": "Round",
    "start_line": 186,
    "symbol": "Round.as_sqlite"
  },
  "id": "8da25bd7-15a9-4a46-a4d7-0b707aff2599",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.6737400+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 186,
        "selector": "L186-L190",
        "symbol": "Round.as_sqlite"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "651a9b10-fa3a-4dbe-a9d4-d2a8852a261b",
  "subject_name": "django/db/models/functions/math::Round.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection, **extra_context)"
}
```
