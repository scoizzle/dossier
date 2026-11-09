# Fact 02745c98

Store id: aeececc9-f6c3-4419-89aa-96b98ea60182

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
- posted_at: `2026-11-09T23:44:55.2864700+00:00`

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
  "id": "aeececc9-f6c3-4419-89aa-96b98ea60182",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.2864700+00:00"
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
  "subject_id": "db2de810-733d-46b1-9078-f66215edf3aa",
  "subject_name": "django/db/models/manager::BaseManager.from_queryset",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def from_queryset(cls, queryset_class, class_name=None)"
}
```
