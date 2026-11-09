# Fact dd5e1aa9

Store id: 667e76c8-67d4-4408-a5f7-94fa82ce4f8a

## Text

```text
def can_fast_delete(self, objs, from_field=None)
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
- posted_at: `2026-11-09T23:31:55.1115200+00:00`

## Data

```json
{
  "end_line": 254,
  "entity_kind": "method",
  "parent": "Collector",
  "start_line": 210,
  "symbol": "Collector.can_fast_delete"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/deletion.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":210,"selector":"L210-L254","symbol":"Collector.can_fast_delete"}`

## Items

```json
[
  {
    "text": "Determine if the objects in the given queryset-like or single object can be fast-deleted. This can be done if there are no cascades, no parents and no signal listeners for the object class.",
    "locator": {
      "line": 211
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/deletion::Collector.can_fast_delete](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 254,
    "entity_kind": "method",
    "parent": "Collector",
    "start_line": 210,
    "symbol": "Collector.can_fast_delete"
  },
  "id": "667e76c8-67d4-4408-a5f7-94fa82ce4f8a",
  "items": [
    {
      "locator": {
        "line": 211
      },
      "text": "Determine if the objects in the given queryset-like or single object can be fast-deleted. This can be done if there are no cascades, no parents and no signal listeners for the object class."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.1115200+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 210,
        "selector": "L210-L254",
        "symbol": "Collector.can_fast_delete"
      },
      "rel": "derived_from",
      "target": "django/db/models/deletion.py"
    }
  ],
  "status": "live",
  "subject_id": "701620ed-8088-4b34-b0d7-04748112e73e",
  "subject_name": "django/db/models/deletion::Collector.can_fast_delete",
  "tags": [
    "entity:method"
  ],
  "text": "def can_fast_delete(self, objs, from_field=None)"
}
```
