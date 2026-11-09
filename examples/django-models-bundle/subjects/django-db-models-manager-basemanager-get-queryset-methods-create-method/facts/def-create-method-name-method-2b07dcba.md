# Fact 2b07dcba

Store id: e6f66d42-8ec3-4cdd-b403-9fe16b2bc634

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
- posted_at: `2026-11-09T23:32:03.6711870+00:00`

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
  "id": "e6f66d42-8ec3-4cdd-b403-9fe16b2bc634",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.6711870+00:00"
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
  "subject_id": "39e5cbf3-645c-4a4b-ab94-1866c7643252",
  "subject_name": "django/db/models/manager::BaseManager._get_queryset_methods.create_method",
  "tags": [
    "entity:function"
  ],
  "text": "def create_method(name, method)"
}
```
