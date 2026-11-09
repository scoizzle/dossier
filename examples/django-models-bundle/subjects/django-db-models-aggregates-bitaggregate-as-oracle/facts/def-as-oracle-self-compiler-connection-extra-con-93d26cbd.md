# Fact 93d26cbd

Store id: e8556fbc-0756-4cbf-9597-e78414050e8f

## Text

```text
def as_oracle(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T22:39:40.0419940+00:00`

## Data

```json
{
  "end_line": 277,
  "entity_kind": "method",
  "parent": "BitAggregate",
  "start_line": 271,
  "symbol": "BitAggregate.as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":271,"selector":"L271-L277","symbol":"BitAggregate.as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::BitAggregate.as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 277,
    "entity_kind": "method",
    "parent": "BitAggregate",
    "start_line": 271,
    "symbol": "BitAggregate.as_oracle"
  },
  "id": "e8556fbc-0756-4cbf-9597-e78414050e8f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.0419940+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 271,
        "selector": "L271-L277",
        "symbol": "BitAggregate.as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "31fdfee4-e016-4f2c-9656-a27f824e0529",
  "subject_name": "django/db/models/aggregates::BitAggregate.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
