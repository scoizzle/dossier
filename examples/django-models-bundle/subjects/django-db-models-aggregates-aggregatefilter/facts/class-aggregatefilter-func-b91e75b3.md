# Fact b91e75b3

Store id: 1ca65010-f7dc-4495-8f24-44612291e64d

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
- posted_at: `2026-11-09T23:31:53.5133290+00:00`

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
  "id": "1ca65010-f7dc-4495-8f24-44612291e64d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.5133290+00:00"
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
  "subject_id": "7f1a263a-5160-425d-8052-61fd06742a0d",
  "subject_name": "django/db/models/aggregates::AggregateFilter",
  "tags": [
    "entity:class"
  ],
  "text": "class AggregateFilter(Func)"
}
```
