# Fact ccdf3b62

Store id: b01ece9d-00a8-424a-ab62-84467e2c0f69

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
- posted_at: `2026-11-09T23:44:48.4052320+00:00`

## Data

```json
{
  "end_line": 398,
  "entity_kind": "method",
  "parent": "StringAgg",
  "start_line": 383,
  "symbol": "StringAgg.as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":383,"selector":"L383-L398","symbol":"StringAgg.as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::StringAgg.as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 398,
    "entity_kind": "method",
    "parent": "StringAgg",
    "start_line": 383,
    "symbol": "StringAgg.as_oracle"
  },
  "id": "b01ece9d-00a8-424a-ab62-84467e2c0f69",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.4052320+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 383,
        "selector": "L383-L398",
        "symbol": "StringAgg.as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "6fbe6278-60de-406d-9788-a6c73ad5b729",
  "subject_name": "django/db/models/aggregates::StringAgg.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
