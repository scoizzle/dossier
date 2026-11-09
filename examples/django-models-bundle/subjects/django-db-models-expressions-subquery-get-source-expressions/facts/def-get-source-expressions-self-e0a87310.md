# Fact e0a87310

Store id: 0fe85bf1-f8fa-4535-af5d-18584857394e

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
- posted_at: `2026-11-09T22:39:41.7215620+00:00`

## Data

```json
{
  "end_line": 1836,
  "entity_kind": "method",
  "parent": "Subquery",
  "start_line": 1835,
  "symbol": "Subquery.get_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1835,"selector":"L1835-L1836","symbol":"Subquery.get_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Subquery.get_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1836,
    "entity_kind": "method",
    "parent": "Subquery",
    "start_line": 1835,
    "symbol": "Subquery.get_source_expressions"
  },
  "id": "0fe85bf1-f8fa-4535-af5d-18584857394e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7215620+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1835,
        "selector": "L1835-L1836",
        "symbol": "Subquery.get_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "b5087091-b48a-4abd-82af-dff719b8d4f8",
  "subject_name": "django/db/models/expressions::Subquery.get_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def get_source_expressions(self)"
}
```
