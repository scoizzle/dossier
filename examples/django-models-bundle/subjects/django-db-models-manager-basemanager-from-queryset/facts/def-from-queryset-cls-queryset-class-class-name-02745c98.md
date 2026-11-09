# Fact 02745c98

Store id: cf33abc7-67e5-4732-8698-03d8b8ac9909

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
- posted_at: `2026-11-09T22:39:48.5034280+00:00`

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
  "id": "cf33abc7-67e5-4732-8698-03d8b8ac9909",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.5034280+00:00"
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
  "subject_id": "770c1e89-4d54-46e0-97c3-031afd068e7d",
  "subject_name": "django/db/models/manager::BaseManager.from_queryset",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def from_queryset(cls, queryset_class, class_name=None)"
}
```
