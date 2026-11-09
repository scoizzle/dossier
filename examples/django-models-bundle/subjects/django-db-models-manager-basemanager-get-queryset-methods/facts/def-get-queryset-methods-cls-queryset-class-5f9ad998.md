# Fact 5f9ad998

Store id: f8b25c66-d49b-4357-b63d-8fc4d39bacb5

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
- posted_at: `2026-11-09T22:39:48.4802570+00:00`

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
  "id": "f8b25c66-d49b-4357-b63d-8fc4d39bacb5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.4802570+00:00"
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
  "subject_id": "251eb999-3944-4542-8da5-a5cdd25cc9bc",
  "subject_name": "django/db/models/manager::BaseManager._get_queryset_methods",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _get_queryset_methods(cls, queryset_class)"
}
```
