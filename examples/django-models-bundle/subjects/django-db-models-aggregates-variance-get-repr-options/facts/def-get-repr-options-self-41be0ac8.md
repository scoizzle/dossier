# Fact 41be0ac8

Store id: e1ed56ce-b27b-4ee0-867d-4dc2406cd6c5

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
- posted_at: `2026-11-09T23:31:53.5501050+00:00`

## Data

```json
{
  "end_line": 468,
  "entity_kind": "method",
  "parent": "Variance",
  "start_line": 467,
  "symbol": "Variance._get_repr_options"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":467,"selector":"L467-L468","symbol":"Variance._get_repr_options"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::Variance._get_repr_options](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 468,
    "entity_kind": "method",
    "parent": "Variance",
    "start_line": 467,
    "symbol": "Variance._get_repr_options"
  },
  "id": "e1ed56ce-b27b-4ee0-867d-4dc2406cd6c5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.5501050+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 467,
        "selector": "L467-L468",
        "symbol": "Variance._get_repr_options"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "c42e438b-0a1c-4640-bb23-a01efe5375ea",
  "subject_name": "django/db/models/aggregates::Variance._get_repr_options",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_repr_options(self)"
}
```
