# Fact 5d9d3fd0

Store id: d7db0ea0-4d04-4299-8351-83ccf90d903e

## Text

```text
def collect( self, objs, source=None, nullable=False, collect_related=True, source_attr=None, reverse_dependency=False, keep_parents=False, fail_on_restricted=True, )
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
- posted_at: `2026-11-09T23:44:48.9150820+00:00`

## Data

```json
{
  "end_line": 431,
  "entity_kind": "method",
  "parent": "Collector",
  "start_line": 271,
  "symbol": "Collector.collect"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/deletion.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":271,"selector":"L271-L431","symbol":"Collector.collect"}`

## Items

```json
[
  {
    "text": "Add 'objs' to the collection of objects to be deleted as well as all parent instances. 'objs' must be a homogeneous iterable collection of model instances (e.g. a QuerySet). If 'collect_related' is True, related objects will be handled by their respective on_delete handler.",
    "locator": {
      "line": 282
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/deletion::Collector.collect](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 431,
    "entity_kind": "method",
    "parent": "Collector",
    "start_line": 271,
    "symbol": "Collector.collect"
  },
  "id": "d7db0ea0-4d04-4299-8351-83ccf90d903e",
  "items": [
    {
      "locator": {
        "line": 282
      },
      "text": "Add 'objs' to the collection of objects to be deleted as well as all parent instances. 'objs' must be a homogeneous iterable collection of model instances (e.g. a QuerySet). If 'collect_related' is True, related objects will be handled by their respective on_delete handler."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.9150820+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 271,
        "selector": "L271-L431",
        "symbol": "Collector.collect"
      },
      "rel": "derived_from",
      "target": "django/db/models/deletion.py"
    }
  ],
  "status": "live",
  "subject_id": "b328a346-78b6-40c2-aede-437716cf56f4",
  "subject_name": "django/db/models/deletion::Collector.collect",
  "tags": [
    "entity:method"
  ],
  "text": "def collect( self, objs, source=None, nullable=False, collect_related=True, source_attr=None, reverse_dependency=False, keep_parents=False, fail_on_restricted=True, )"
}
```
