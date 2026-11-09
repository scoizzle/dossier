# Fact f847e4c5

Store id: f21c5117-15a8-461d-a77a-eab4c416d4eb

## Text

```text
def set_source_expressions(self, exprs)
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
- posted_at: `2026-11-09T23:44:48.3958180+00:00`

## Data

```json
{
  "end_line": 119,
  "entity_kind": "method",
  "parent": "Aggregate",
  "start_line": 117,
  "symbol": "Aggregate.set_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":117,"selector":"L117-L119","symbol":"Aggregate.set_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::Aggregate.set_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 119,
    "entity_kind": "method",
    "parent": "Aggregate",
    "start_line": 117,
    "symbol": "Aggregate.set_source_expressions"
  },
  "id": "f21c5117-15a8-461d-a77a-eab4c416d4eb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.3958180+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 117,
        "selector": "L117-L119",
        "symbol": "Aggregate.set_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "44f54055-8e30-4a7e-a3f4-e3bcd9458a0e",
  "subject_name": "django/db/models/aggregates::Aggregate.set_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def set_source_expressions(self, exprs)"
}
```
