# Fact b3f36b30

Store id: 990d3daf-201b-4803-9114-48a6d531af8d

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
- posted_at: `2026-11-09T23:44:48.3955580+00:00`

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
  "id": "990d3daf-201b-4803-9114-48a6d531af8d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.3955580+00:00"
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
  "subject_id": "bc225cac-b3f8-4427-9304-5e089f46de10",
  "subject_name": "django/db/models/aggregates::Aggregate.get_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def get_source_expressions(self)"
}
```
