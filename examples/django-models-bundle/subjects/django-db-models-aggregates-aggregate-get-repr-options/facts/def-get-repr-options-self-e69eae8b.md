# Fact e69eae8b

Store id: c9522539-dab1-4d8a-a90e-4b770a5a6cff

## Text

```text
def _get_repr_options(self)
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
- posted_at: `2026-11-09T22:39:40.0379560+00:00`

## Data

```json
{
  "end_line": 223,
  "entity_kind": "method",
  "parent": "Aggregate",
  "start_line": 215,
  "symbol": "Aggregate._get_repr_options"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":215,"selector":"L215-L223","symbol":"Aggregate._get_repr_options"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::Aggregate._get_repr_options](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 223,
    "entity_kind": "method",
    "parent": "Aggregate",
    "start_line": 215,
    "symbol": "Aggregate._get_repr_options"
  },
  "id": "c9522539-dab1-4d8a-a90e-4b770a5a6cff",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.0379560+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 215,
        "selector": "L215-L223",
        "symbol": "Aggregate._get_repr_options"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "d8a3fb2f-c53a-4313-9da9-8d3a1c3dc014",
  "subject_name": "django/db/models/aggregates::Aggregate._get_repr_options",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_repr_options(self)"
}
```
