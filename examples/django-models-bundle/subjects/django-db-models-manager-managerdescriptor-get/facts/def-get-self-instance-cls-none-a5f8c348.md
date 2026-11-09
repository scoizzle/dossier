# Fact a5f8c348

Store id: 6c7e4deb-0260-4167-bd75-dd4c92cd762d

## Text

```text
def __get__(self, instance, cls=None)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:48.5453570+00:00`

## Data

```json
{
  "end_line": 204,
  "entity_kind": "method",
  "parent": "ManagerDescriptor",
  "start_line": 184,
  "symbol": "ManagerDescriptor.__get__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/manager.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":184,"selector":"L184-L204","symbol":"ManagerDescriptor.__get__"}`

## Referenced by

None.

## Subject

[django/db/models/manager::ManagerDescriptor.__get__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 204,
    "entity_kind": "method",
    "parent": "ManagerDescriptor",
    "start_line": 184,
    "symbol": "ManagerDescriptor.__get__"
  },
  "id": "6c7e4deb-0260-4167-bd75-dd4c92cd762d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.5453570+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 184,
        "selector": "L184-L204",
        "symbol": "ManagerDescriptor.__get__"
      },
      "rel": "derived_from",
      "target": "django/db/models/manager.py"
    }
  ],
  "status": "live",
  "subject_id": "1e92c836-dbbf-4b39-a41f-bdb3a6249f46",
  "subject_name": "django/db/models/manager::ManagerDescriptor.__get__",
  "tags": [
    "entity:method"
  ],
  "text": "def __get__(self, instance, cls=None)"
}
```
