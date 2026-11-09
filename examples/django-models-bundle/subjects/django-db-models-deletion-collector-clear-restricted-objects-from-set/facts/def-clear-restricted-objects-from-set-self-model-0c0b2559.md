# Fact 0c0b2559

Store id: f80b24bc-5f03-47a7-bba9-18f83c97fca7

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
- posted_at: `2026-11-09T23:44:48.9122210+00:00`

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
  "id": "f80b24bc-5f03-47a7-bba9-18f83c97fca7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.9122210+00:00"
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
  "subject_id": "6fa5bd3f-60e7-400e-915a-cc62b68c8dbd",
  "subject_name": "django/db/models/deletion::Collector.clear_restricted_objects_from_set",
  "tags": [
    "entity:method"
  ],
  "text": "def clear_restricted_objects_from_set(self, model, objs)"
}
```
