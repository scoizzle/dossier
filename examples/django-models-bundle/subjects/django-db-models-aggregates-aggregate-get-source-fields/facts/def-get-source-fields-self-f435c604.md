# Fact f435c604

Store id: 2790bace-02ec-405f-8b4e-9535b8f2ec92

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
- posted_at: `2026-11-09T22:39:40.0346900+00:00`

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
  "id": "2790bace-02ec-405f-8b4e-9535b8f2ec92",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.0346900+00:00"
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
  "subject_id": "b2d8e061-ef50-47b1-970a-130f1dc789ec",
  "subject_name": "django/db/models/aggregates::Aggregate.get_source_fields",
  "tags": [
    "entity:method"
  ],
  "text": "def get_source_fields(self)"
}
```
