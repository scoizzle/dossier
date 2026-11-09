# Fact b3f36b30

Store id: 0cdbdf5d-3b72-413f-9da9-4a9b95392ba8

## Text

```text
def get_source_expressions(self)
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
- posted_at: `2026-11-09T22:39:40.0351040+00:00`

## Data

```json
{
  "end_line": 115,
  "entity_kind": "method",
  "parent": "Aggregate",
  "start_line": 113,
  "symbol": "Aggregate.get_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":113,"selector":"L113-L115","symbol":"Aggregate.get_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::Aggregate.get_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 115,
    "entity_kind": "method",
    "parent": "Aggregate",
    "start_line": 113,
    "symbol": "Aggregate.get_source_expressions"
  },
  "id": "0cdbdf5d-3b72-413f-9da9-4a9b95392ba8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.0351040+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 113,
        "selector": "L113-L115",
        "symbol": "Aggregate.get_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "84f48bd2-a285-4521-8553-97113bd1ee58",
  "subject_name": "django/db/models/aggregates::Aggregate.get_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def get_source_expressions(self)"
}
```
