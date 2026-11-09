# Fact b91e75b3

Store id: 9687fcd2-c478-4730-83ab-cca9526d7a1e

## Text

```text
class AggregateFilter(Func)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:40.0138850+00:00`

## Data

```json
{
  "end_line": 59,
  "entity_kind": "class",
  "parent": "aggregates",
  "start_line": 40,
  "symbol": "AggregateFilter"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":40,"selector":"L40-L59","symbol":"AggregateFilter"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::AggregateFilter](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 59,
    "entity_kind": "class",
    "parent": "aggregates",
    "start_line": 40,
    "symbol": "AggregateFilter"
  },
  "id": "9687fcd2-c478-4730-83ab-cca9526d7a1e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.0138850+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 40,
        "selector": "L40-L59",
        "symbol": "AggregateFilter"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "3619039d-e4c2-48b4-bcce-3c6c9173de5a",
  "subject_name": "django/db/models/aggregates::AggregateFilter",
  "tags": [
    "entity:class"
  ],
  "text": "class AggregateFilter(Func)"
}
```
