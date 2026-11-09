# Fact 2db75c52

Store id: 4d6bb382-6cdf-419a-9382-4f294916ff11

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
- posted_at: `2026-11-09T23:44:55.2838620+00:00`

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
  "id": "4d6bb382-6cdf-419a-9382-4f294916ff11",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.2838620+00:00"
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
  "subject_id": "0825ac11-d3f6-4ce2-ac28-f286bcf7ffc5",
  "subject_name": "django/db/models/manager::BaseManager._get_queryset_methods.create_method.manager_method",
  "tags": [
    "entity:function",
    "decorator:wraps"
  ],
  "text": "def manager_method(self, *args, **kwargs)"
}
```
