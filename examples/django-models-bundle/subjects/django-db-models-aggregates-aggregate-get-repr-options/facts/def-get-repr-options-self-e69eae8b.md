# Fact e69eae8b

Store id: aa3024ae-35c2-4017-ab66-736525583f85

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
- posted_at: `2026-11-09T23:31:53.5349150+00:00`

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
  "id": "aa3024ae-35c2-4017-ab66-736525583f85",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.5349150+00:00"
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
  "subject_id": "30a65147-b8da-452b-8768-de54d6c23222",
  "subject_name": "django/db/models/aggregates::Aggregate._get_repr_options",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_repr_options(self)"
}
```
