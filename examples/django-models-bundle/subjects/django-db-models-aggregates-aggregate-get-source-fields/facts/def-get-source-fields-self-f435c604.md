# Fact f435c604

Store id: bec3b60f-5d26-48b8-ab0a-db23217a8d21

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
- posted_at: `2026-11-09T23:44:48.3952650+00:00`

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
  "id": "bec3b60f-5d26-48b8-ab0a-db23217a8d21",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.3952650+00:00"
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
  "subject_id": "060f02bb-429d-49bc-a034-cce840b17ffc",
  "subject_name": "django/db/models/aggregates::Aggregate.get_source_fields",
  "tags": [
    "entity:method"
  ],
  "text": "def get_source_fields(self)"
}
```
