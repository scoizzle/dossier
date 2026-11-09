# Fact e615a8ce

Store id: e3f957b1-eb49-4604-b02a-0a8053011fb2

## Text

```text
def clear_restricted_objects_from_queryset(self, model, qs)
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
- posted_at: `2026-11-09T23:31:55.1092820+00:00`

## Data

```json
{
  "end_line": 203,
  "entity_kind": "method",
  "parent": "Collector",
  "start_line": 192,
  "symbol": "Collector.clear_restricted_objects_from_queryset"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/deletion.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":192,"selector":"L192-L203","symbol":"Collector.clear_restricted_objects_from_queryset"}`

## Referenced by

None.

## Subject

[django/db/models/deletion::Collector.clear_restricted_objects_from_queryset](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 203,
    "entity_kind": "method",
    "parent": "Collector",
    "start_line": 192,
    "symbol": "Collector.clear_restricted_objects_from_queryset"
  },
  "id": "e3f957b1-eb49-4604-b02a-0a8053011fb2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.1092820+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 192,
        "selector": "L192-L203",
        "symbol": "Collector.clear_restricted_objects_from_queryset"
      },
      "rel": "derived_from",
      "target": "django/db/models/deletion.py"
    }
  ],
  "status": "live",
  "subject_id": "36ec2a13-8f59-48ca-b71b-d2531cc77074",
  "subject_name": "django/db/models/deletion::Collector.clear_restricted_objects_from_queryset",
  "tags": [
    "entity:method"
  ],
  "text": "def clear_restricted_objects_from_queryset(self, model, qs)"
}
```
