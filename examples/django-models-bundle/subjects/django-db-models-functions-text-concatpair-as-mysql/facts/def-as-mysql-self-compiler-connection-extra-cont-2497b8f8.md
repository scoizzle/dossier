# Fact 2497b8f8

Store id: a022b21d-7377-484f-aec5-63b4eee4729d

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
- posted_at: `2026-11-09T23:32:02.1710490+00:00`

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
  "id": "a022b21d-7377-484f-aec5-63b4eee4729d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.1710490+00:00"
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
  "subject_id": "7d1a98fb-f4c1-4bab-801e-e5e01d020e2e",
  "subject_name": "django/db/models/functions/text::ConcatPair.as_mysql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_mysql(self, compiler, connection, **extra_context)"
}
```
