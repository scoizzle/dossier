# Fact da4cde82

Store id: 95f7d873-ae00-42dc-8f9b-51c8ad3476e0

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
- posted_at: `2026-11-09T22:39:41.5926220+00:00`

## Data

```json
{
  "end_line": 1203,
  "entity_kind": "method",
  "parent": "Value",
  "start_line": 1193,
  "symbol": "Value.as_sqlite"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1193,"selector":"L1193-L1203","symbol":"Value.as_sqlite"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Value.as_sqlite](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1203,
    "entity_kind": "method",
    "parent": "Value",
    "start_line": 1193,
    "symbol": "Value.as_sqlite"
  },
  "id": "95f7d873-ae00-42dc-8f9b-51c8ad3476e0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5926220+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1193,
        "selector": "L1193-L1203",
        "symbol": "Value.as_sqlite"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "f956872c-f336-47f0-a9d5-d0995fea99d8",
  "subject_name": "django/db/models/expressions::Value.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection, **extra_context)"
}
```
