# Fact 8ea13605

Store id: 255fbaac-91ca-4674-8909-5ce256e5d4c4

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
- posted_at: `2026-11-09T23:31:55.1065120+00:00`

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
  "id": "255fbaac-91ca-4674-8909-5ce256e5d4c4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.1065120+00:00"
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
  "subject_id": "7ec22b70-de93-45e4-89ac-9b2efc3a7ce5",
  "subject_name": "django/db/models/deletion::Collector.add_restricted_objects",
  "tags": [
    "entity:method"
  ],
  "text": "def add_restricted_objects(self, field, objs)"
}
```
