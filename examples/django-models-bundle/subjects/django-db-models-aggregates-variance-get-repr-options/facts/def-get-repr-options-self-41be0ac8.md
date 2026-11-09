# Fact 41be0ac8

Store id: 43fa31f0-3dd2-44a6-a048-4478ca7e16a9

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
- posted_at: `2026-11-09T23:44:48.4073480+00:00`

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
  "id": "43fa31f0-3dd2-44a6-a048-4478ca7e16a9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.4073480+00:00"
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
  "subject_id": "e6e9246a-e291-4439-958d-3615ef1c3611",
  "subject_name": "django/db/models/aggregates::Variance._get_repr_options",
  "tags": [
    "entity:method"
  ],
  "text": "def _get_repr_options(self)"
}
```
