# Fact 4e068095

Store id: d4aed6ca-ff6b-4daf-bc81-107ba70a70c0

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
- posted_at: `2026-11-09T23:44:53.7657220+00:00`

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
  "id": "d4aed6ca-ff6b-4daf-bc81-107ba70a70c0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.7657220+00:00"
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
  "subject_id": "fed09c0b-cf05-4d43-aaba-bf0aa8475c16",
  "subject_name": "django/db/models/functions/math::Round.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection, **extra_context)"
}
```
