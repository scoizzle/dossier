# Fact e69eae8b

Store id: 5794b295-8884-431d-834c-e383e1df8d6e

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
- posted_at: `2026-11-09T23:44:48.3974940+00:00`

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
  "id": "5794b295-8884-431d-834c-e383e1df8d6e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.3974940+00:00"
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
  "subject_id": "5b8a9e3d-7f8d-4ca5-9881-f0c53009ed2c",
  "subject_name": "django/db/models/aggregates::Aggregate._get_repr_options",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_repr_options(self)"
}
```
