# Fact d5b763b6

Store id: 6d4811df-02c0-4a1f-a23d-db24c6df112c

## Text

```text
class Max(Aggregate)
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
- posted_at: `2026-11-09T22:39:40.0445740+00:00`

## Data

```json
{
  "end_line": 331,
  "entity_kind": "class",
  "parent": "aggregates",
  "start_line": 328,
  "symbol": "Max"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":328,"selector":"L328-L331","symbol":"Max"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::Max](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 331,
    "entity_kind": "class",
    "parent": "aggregates",
    "start_line": 328,
    "symbol": "Max"
  },
  "id": "6d4811df-02c0-4a1f-a23d-db24c6df112c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.0445740+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 328,
        "selector": "L328-L331",
        "symbol": "Max"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "104e390d-2d88-480c-b66f-fe42134704fe",
  "subject_name": "django/db/models/aggregates::Max",
  "tags": [
    "entity:class"
  ],
  "text": "class Max(Aggregate)"
}
```
