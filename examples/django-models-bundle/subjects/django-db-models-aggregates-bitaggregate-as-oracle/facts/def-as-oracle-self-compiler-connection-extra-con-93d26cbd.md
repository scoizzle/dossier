# Fact 93d26cbd

Store id: c9d83e6f-9ac2-4b08-adb6-ca1b445079f5

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
- posted_at: `2026-11-09T23:44:48.3994930+00:00`

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
  "id": "c9d83e6f-9ac2-4b08-adb6-ca1b445079f5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.3994930+00:00"
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
  "subject_id": "fa80a3f2-c9a4-4a48-b43c-123e1ea610fd",
  "subject_name": "django/db/models/aggregates::BitAggregate.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
