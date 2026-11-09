# Fact f847e4c5

Store id: fb10abc9-30ec-4093-807c-5e63ba711dc9

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
- posted_at: `2026-11-09T23:31:53.5326930+00:00`

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
  "id": "fb10abc9-30ec-4093-807c-5e63ba711dc9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.5326930+00:00"
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
  "subject_id": "8ab7c289-00c2-4928-9c76-64ae50f2a565",
  "subject_name": "django/db/models/aggregates::Aggregate.set_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def set_source_expressions(self, exprs)"
}
```
