# Fact e615a8ce

Store id: af1aa25c-9a2e-4f52-9e91-c16a5a871f68

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
- posted_at: `2026-11-09T23:44:48.9128090+00:00`

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
  "id": "af1aa25c-9a2e-4f52-9e91-c16a5a871f68",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.9128090+00:00"
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
  "subject_id": "2d92b016-f410-4176-a1cf-78bea8e8859a",
  "subject_name": "django/db/models/deletion::Collector.clear_restricted_objects_from_queryset",
  "tags": [
    "entity:method"
  ],
  "text": "def clear_restricted_objects_from_queryset(self, model, qs)"
}
```
