# Fact 0c0b2559

Store id: 7839fdba-58e9-4930-9410-3a7a1ddd2ad0

## Text

```text
def clear_restricted_objects_from_set(self, model, objs)
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
- posted_at: `2026-11-09T22:39:41.0608000+00:00`

## Data

```json
{
  "end_line": 190,
  "entity_kind": "method",
  "parent": "Collector",
  "start_line": 185,
  "symbol": "Collector.clear_restricted_objects_from_set"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/deletion.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":185,"selector":"L185-L190","symbol":"Collector.clear_restricted_objects_from_set"}`

## Referenced by

None.

## Subject

[django/db/models/deletion::Collector.clear_restricted_objects_from_set](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 190,
    "entity_kind": "method",
    "parent": "Collector",
    "start_line": 185,
    "symbol": "Collector.clear_restricted_objects_from_set"
  },
  "id": "7839fdba-58e9-4930-9410-3a7a1ddd2ad0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.0608000+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 185,
        "selector": "L185-L190",
        "symbol": "Collector.clear_restricted_objects_from_set"
      },
      "rel": "derived_from",
      "target": "django/db/models/deletion.py"
    }
  ],
  "status": "live",
  "subject_id": "bcde97b8-b6aa-4ed2-ba60-d357de0da353",
  "subject_name": "django/db/models/deletion::Collector.clear_restricted_objects_from_set",
  "tags": [
    "entity:method"
  ],
  "text": "def clear_restricted_objects_from_set(self, model, objs)"
}
```
