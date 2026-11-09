# Fact c37678b7

Store id: 58f813d4-65fd-4d3a-8f76-5d052035d1c4

## Text

```text
class Count(Aggregate)
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
- posted_at: `2026-11-09T22:39:40.0436040+00:00`

## Data

```json
{
  "end_line": 325,
  "entity_kind": "class",
  "parent": "aggregates",
  "start_line": 295,
  "symbol": "Count"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":295,"selector":"L295-L325","symbol":"Count"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::Count](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 325,
    "entity_kind": "class",
    "parent": "aggregates",
    "start_line": 295,
    "symbol": "Count"
  },
  "id": "58f813d4-65fd-4d3a-8f76-5d052035d1c4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.0436040+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 295,
        "selector": "L295-L325",
        "symbol": "Count"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "9523552e-5bf3-41e9-9520-28b03320621b",
  "subject_name": "django/db/models/aggregates::Count",
  "tags": [
    "entity:class"
  ],
  "text": "class Count(Aggregate)"
}
```
