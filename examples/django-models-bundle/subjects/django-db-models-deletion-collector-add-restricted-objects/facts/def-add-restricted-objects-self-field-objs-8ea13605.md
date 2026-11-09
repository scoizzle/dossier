# Fact 8ea13605

Store id: 9467465d-c7a3-45f0-b3b5-3537577e8f8c

## Text

```text
def add_restricted_objects(self, field, objs)
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
- posted_at: `2026-11-09T23:44:48.9116760+00:00`

## Data

```json
{
  "end_line": 183,
  "entity_kind": "method",
  "parent": "Collector",
  "start_line": 180,
  "symbol": "Collector.add_restricted_objects"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/deletion.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":180,"selector":"L180-L183","symbol":"Collector.add_restricted_objects"}`

## Referenced by

None.

## Subject

[django/db/models/deletion::Collector.add_restricted_objects](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 183,
    "entity_kind": "method",
    "parent": "Collector",
    "start_line": 180,
    "symbol": "Collector.add_restricted_objects"
  },
  "id": "9467465d-c7a3-45f0-b3b5-3537577e8f8c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.9116760+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 180,
        "selector": "L180-L183",
        "symbol": "Collector.add_restricted_objects"
      },
      "rel": "derived_from",
      "target": "django/db/models/deletion.py"
    }
  ],
  "status": "live",
  "subject_id": "7577deb0-4398-49ef-95d2-dd4aa0bdb7e3",
  "subject_name": "django/db/models/deletion::Collector.add_restricted_objects",
  "tags": [
    "entity:method"
  ],
  "text": "def add_restricted_objects(self, field, objs)"
}
```
