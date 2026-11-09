# Fact b05c1987

Store id: 9bd522db-1219-496d-81cf-22d2c011ce16

## Text

```text
def get_group_by_cols(self)
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
- posted_at: `2026-11-09T23:44:48.3968770+00:00`

## Data

```json
{
  "end_line": 172,
  "entity_kind": "method",
  "parent": "Aggregate",
  "start_line": 171,
  "symbol": "Aggregate.get_group_by_cols"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":171,"selector":"L171-L172","symbol":"Aggregate.get_group_by_cols"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::Aggregate.get_group_by_cols](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 172,
    "entity_kind": "method",
    "parent": "Aggregate",
    "start_line": 171,
    "symbol": "Aggregate.get_group_by_cols"
  },
  "id": "9bd522db-1219-496d-81cf-22d2c011ce16",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.3968770+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 171,
        "selector": "L171-L172",
        "symbol": "Aggregate.get_group_by_cols"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "81cca8a7-6d0e-49d4-a803-7e9b5b92ec9b",
  "subject_name": "django/db/models/aggregates::Aggregate.get_group_by_cols",
  "tags": [
    "entity:method"
  ],
  "text": "def get_group_by_cols(self)"
}
```
