# Fact 2db75c52

Store id: b8424877-9da9-4846-bb9d-3c5268f12f47

## Text

```text
def manager_method(self, *args, **kwargs)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`, `decorator:wraps`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:03.6835510+00:00`

## Data

```json
{
  "end_line": 87,
  "entity_kind": "function",
  "parent": "BaseManager._get_queryset_methods.create_method",
  "start_line": 85,
  "symbol": "BaseManager._get_queryset_methods.create_method.manager_method"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/manager.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":85,"selector":"L85-L87","symbol":"BaseManager._get_queryset_methods.create_method.manager_method"}`

## Referenced by

None.

## Subject

[django/db/models/manager::BaseManager._get_queryset_methods.create_method.manager_method](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 87,
    "entity_kind": "function",
    "parent": "BaseManager._get_queryset_methods.create_method",
    "start_line": 85,
    "symbol": "BaseManager._get_queryset_methods.create_method.manager_method"
  },
  "id": "b8424877-9da9-4846-bb9d-3c5268f12f47",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.6835510+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 85,
        "selector": "L85-L87",
        "symbol": "BaseManager._get_queryset_methods.create_method.manager_method"
      },
      "rel": "derived_from",
      "target": "django/db/models/manager.py"
    }
  ],
  "status": "live",
  "subject_id": "88682eb4-e905-4b4a-8aee-83695548cf4d",
  "subject_name": "django/db/models/manager::BaseManager._get_queryset_methods.create_method.manager_method",
  "tags": [
    "entity:function",
    "decorator:wraps"
  ],
  "text": "def manager_method(self, *args, **kwargs)"
}
```
