# Fact 02745c98

Store id: 7bd222c3-544a-4326-8c6d-80f9117be46f

## Text

```text
def from_queryset(cls, queryset_class, class_name=None)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class_method`, `decorator:classmethod`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:03.6870740+00:00`

## Data

```json
{
  "end_line": 118,
  "entity_kind": "class_method",
  "parent": "BaseManager",
  "start_line": 107,
  "symbol": "BaseManager.from_queryset"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/manager.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":107,"selector":"L107-L118","symbol":"BaseManager.from_queryset"}`

## Referenced by

None.

## Subject

[django/db/models/manager::BaseManager.from_queryset](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 118,
    "entity_kind": "class_method",
    "parent": "BaseManager",
    "start_line": 107,
    "symbol": "BaseManager.from_queryset"
  },
  "id": "7bd222c3-544a-4326-8c6d-80f9117be46f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.6870740+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 107,
        "selector": "L107-L118",
        "symbol": "BaseManager.from_queryset"
      },
      "rel": "derived_from",
      "target": "django/db/models/manager.py"
    }
  ],
  "status": "live",
  "subject_id": "5be77768-7126-4343-b692-c7d6f4c524f2",
  "subject_name": "django/db/models/manager::BaseManager.from_queryset",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def from_queryset(cls, queryset_class, class_name=None)"
}
```
