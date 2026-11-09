# Fact 5f9ad998

Store id: fd28dd3c-4cd1-4bcc-8836-f56166eee849

## Text

```text
def _get_queryset_methods(cls, queryset_class)
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
- posted_at: `2026-11-09T23:32:03.6682740+00:00`

## Data

```json
{
  "end_line": 105,
  "entity_kind": "class_method",
  "parent": "BaseManager",
  "start_line": 82,
  "symbol": "BaseManager._get_queryset_methods"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/manager.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":82,"selector":"L82-L105","symbol":"BaseManager._get_queryset_methods"}`

## Referenced by

None.

## Subject

[django/db/models/manager::BaseManager._get_queryset_methods](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 105,
    "entity_kind": "class_method",
    "parent": "BaseManager",
    "start_line": 82,
    "symbol": "BaseManager._get_queryset_methods"
  },
  "id": "fd28dd3c-4cd1-4bcc-8836-f56166eee849",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.6682740+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 82,
        "selector": "L82-L105",
        "symbol": "BaseManager._get_queryset_methods"
      },
      "rel": "derived_from",
      "target": "django/db/models/manager.py"
    }
  ],
  "status": "live",
  "subject_id": "1ad48513-c004-4e26-bdf5-1349f55ad8a8",
  "subject_name": "django/db/models/manager::BaseManager._get_queryset_methods",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _get_queryset_methods(cls, queryset_class)"
}
```
