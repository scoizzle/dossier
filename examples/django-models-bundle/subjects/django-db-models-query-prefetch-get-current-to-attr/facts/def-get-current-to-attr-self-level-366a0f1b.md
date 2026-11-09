# Fact 366a0f1b

Store id: 7983dd8d-c0e6-46a6-85d3-17a53c0f4b2e

## Text

```text
def get_current_to_attr(self, level)
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
- posted_at: `2026-11-09T23:32:04.8019770+00:00`

## Data

```json
{
  "end_line": 2615,
  "entity_kind": "method",
  "parent": "Prefetch",
  "start_line": 2611,
  "symbol": "Prefetch.get_current_to_attr"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2611,"selector":"L2611-L2615","symbol":"Prefetch.get_current_to_attr"}`

## Referenced by

None.

## Subject

[django/db/models/query::Prefetch.get_current_to_attr](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2615,
    "entity_kind": "method",
    "parent": "Prefetch",
    "start_line": 2611,
    "symbol": "Prefetch.get_current_to_attr"
  },
  "id": "7983dd8d-c0e6-46a6-85d3-17a53c0f4b2e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.8019770+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2611,
        "selector": "L2611-L2615",
        "symbol": "Prefetch.get_current_to_attr"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "59d2d43b-a79a-4a0d-9c3d-080a38846273",
  "subject_name": "django/db/models/query::Prefetch.get_current_to_attr",
  "tags": [
    "entity:method"
  ],
  "text": "def get_current_to_attr(self, level)"
}
```
