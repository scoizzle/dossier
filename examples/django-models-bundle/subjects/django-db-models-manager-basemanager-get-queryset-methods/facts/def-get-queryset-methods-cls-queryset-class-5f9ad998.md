# Fact 5f9ad998

Store id: 60b2dd69-811c-4e06-a73e-10a745dba7ca

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
- posted_at: `2026-11-09T23:44:55.2697640+00:00`

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
  "id": "60b2dd69-811c-4e06-a73e-10a745dba7ca",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.2697640+00:00"
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
  "subject_id": "591a7356-071b-4049-afb2-67a9b1902883",
  "subject_name": "django/db/models/manager::BaseManager._get_queryset_methods",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _get_queryset_methods(cls, queryset_class)"
}
```
