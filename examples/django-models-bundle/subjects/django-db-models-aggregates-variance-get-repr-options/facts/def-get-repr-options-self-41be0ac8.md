# Fact 41be0ac8

Store id: 53fa896c-82b0-47a7-bfc1-35c1d5e60120

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
- posted_at: `2026-11-09T22:39:40.0498530+00:00`

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
  "id": "53fa896c-82b0-47a7-bfc1-35c1d5e60120",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.0498530+00:00"
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
  "subject_id": "b47716b7-3dd1-444c-b4e7-801e064242c0",
  "subject_name": "django/db/models/aggregates::Variance._get_repr_options",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_repr_options(self)"
}
```
