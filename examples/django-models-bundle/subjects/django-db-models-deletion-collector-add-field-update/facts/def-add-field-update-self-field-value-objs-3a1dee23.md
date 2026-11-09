# Fact 3a1dee23

Store id: f80fa959-30d6-46c8-abea-2424ae588282

## Text

```text
def add_field_update(self, field, value, objs)
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
- posted_at: `2026-11-09T23:31:55.1032780+00:00`

## Data

```json
{
  "end_line": 178,
  "entity_kind": "method",
  "parent": "Collector",
  "start_line": 173,
  "symbol": "Collector.add_field_update"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/deletion.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":173,"selector":"L173-L178","symbol":"Collector.add_field_update"}`

## Items

```json
[
  {
    "text": "Schedule a field update. 'objs' must be a homogeneous iterable collection of model instances (e.g. a QuerySet).",
    "locator": {
      "line": 174
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/deletion::Collector.add_field_update](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 178,
    "entity_kind": "method",
    "parent": "Collector",
    "start_line": 173,
    "symbol": "Collector.add_field_update"
  },
  "id": "f80fa959-30d6-46c8-abea-2424ae588282",
  "items": [
    {
      "locator": {
        "line": 174
      },
      "text": "Schedule a field update. 'objs' must be a homogeneous iterable collection of model instances (e.g. a QuerySet)."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.1032780+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 173,
        "selector": "L173-L178",
        "symbol": "Collector.add_field_update"
      },
      "rel": "derived_from",
      "target": "django/db/models/deletion.py"
    }
  ],
  "status": "live",
  "subject_id": "51c08d33-cec9-4d4f-a3cc-0ecf131dcfac",
  "subject_name": "django/db/models/deletion::Collector.add_field_update",
  "tags": [
    "entity:method"
  ],
  "text": "def add_field_update(self, field, value, objs)"
}
```
