# Fact f435c604

Store id: 3e6613d0-c2c9-49c7-bede-a459aea460ca

## Text

```text
def get_source_fields(self)
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
- posted_at: `2026-11-09T23:31:53.5319930+00:00`

## Data

```json
{
  "end_line": 111,
  "entity_kind": "method",
  "parent": "Aggregate",
  "start_line": 108,
  "symbol": "Aggregate.get_source_fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":108,"selector":"L108-L111","symbol":"Aggregate.get_source_fields"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::Aggregate.get_source_fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 111,
    "entity_kind": "method",
    "parent": "Aggregate",
    "start_line": 108,
    "symbol": "Aggregate.get_source_fields"
  },
  "id": "3e6613d0-c2c9-49c7-bede-a459aea460ca",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.5319930+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 108,
        "selector": "L108-L111",
        "symbol": "Aggregate.get_source_fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "02fb6525-3b1d-48f7-8a96-729b5e876e0b",
  "subject_name": "django/db/models/aggregates::Aggregate.get_source_fields",
  "tags": [
    "entity:method"
  ],
  "text": "def get_source_fields(self)"
}
```
