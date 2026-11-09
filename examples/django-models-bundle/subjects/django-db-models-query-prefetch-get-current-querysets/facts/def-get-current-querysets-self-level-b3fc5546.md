# Fact b3fc5546

Store id: 8cb777bb-88ac-4676-aa99-4edab2d3db36

## Text

```text
def get_current_querysets(self, level)
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
- posted_at: `2026-11-09T23:32:04.8059970+00:00`

## Data

```json
{
  "end_line": 2623,
  "entity_kind": "method",
  "parent": "Prefetch",
  "start_line": 2617,
  "symbol": "Prefetch.get_current_querysets"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2617,"selector":"L2617-L2623","symbol":"Prefetch.get_current_querysets"}`

## Referenced by

None.

## Subject

[django/db/models/query::Prefetch.get_current_querysets](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2623,
    "entity_kind": "method",
    "parent": "Prefetch",
    "start_line": 2617,
    "symbol": "Prefetch.get_current_querysets"
  },
  "id": "8cb777bb-88ac-4676-aa99-4edab2d3db36",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.8059970+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2617,
        "selector": "L2617-L2623",
        "symbol": "Prefetch.get_current_querysets"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "85c79610-8a45-4232-8803-e7c751d3d152",
  "subject_name": "django/db/models/query::Prefetch.get_current_querysets",
  "tags": [
    "entity:method"
  ],
  "text": "def get_current_querysets(self, level)"
}
```
