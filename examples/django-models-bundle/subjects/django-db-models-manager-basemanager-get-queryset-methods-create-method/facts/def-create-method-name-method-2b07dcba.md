# Fact 2b07dcba

Store id: a548d397-37ba-4325-8ba7-9c95165edc0d

## Text

```text
def create_method(name, method)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:48.4847710+00:00`

## Data

```json
{
  "end_line": 89,
  "entity_kind": "function",
  "parent": "BaseManager._get_queryset_methods",
  "start_line": 84,
  "symbol": "BaseManager._get_queryset_methods.create_method"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/manager.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":84,"selector":"L84-L89","symbol":"BaseManager._get_queryset_methods.create_method"}`

## Referenced by

None.

## Subject

[django/db/models/manager::BaseManager._get_queryset_methods.create_method](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 89,
    "entity_kind": "function",
    "parent": "BaseManager._get_queryset_methods",
    "start_line": 84,
    "symbol": "BaseManager._get_queryset_methods.create_method"
  },
  "id": "a548d397-37ba-4325-8ba7-9c95165edc0d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.4847710+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 84,
        "selector": "L84-L89",
        "symbol": "BaseManager._get_queryset_methods.create_method"
      },
      "rel": "derived_from",
      "target": "django/db/models/manager.py"
    }
  ],
  "status": "live",
  "subject_id": "2a6a140d-6a43-4bd5-84e5-8a65d428192b",
  "subject_name": "django/db/models/manager::BaseManager._get_queryset_methods.create_method",
  "tags": [
    "entity:function"
  ],
  "text": "def create_method(name, method)"
}
```
