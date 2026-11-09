# Fact fcfe82dc

Store id: 5b237ce2-8edb-4fea-b989-d3c6ac13515a

## Text

```text
def as_postgresql(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T22:39:47.0820450+00:00`

## Data

```json
{
  "end_line": 100,
  "entity_kind": "method",
  "parent": "ConcatPair",
  "start_line": 88,
  "symbol": "ConcatPair.as_postgresql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":88,"selector":"L88-L100","symbol":"ConcatPair.as_postgresql"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::ConcatPair.as_postgresql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 100,
    "entity_kind": "method",
    "parent": "ConcatPair",
    "start_line": 88,
    "symbol": "ConcatPair.as_postgresql"
  },
  "id": "5b237ce2-8edb-4fea-b989-d3c6ac13515a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.0820450+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 88,
        "selector": "L88-L100",
        "symbol": "ConcatPair.as_postgresql"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "f10c652b-e194-4dd9-a6c1-48a56d67d047",
  "subject_name": "django/db/models/functions/text::ConcatPair.as_postgresql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_postgresql(self, compiler, connection, **extra_context)"
}
```
