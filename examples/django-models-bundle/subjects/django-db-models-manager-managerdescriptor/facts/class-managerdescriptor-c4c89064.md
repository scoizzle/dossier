# Fact c4c89064

Store id: a5a29324-2f00-4112-83d6-5757a42d7812

## Text

```text
class ManagerDescriptor
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:48.5393770+00:00`

## Data

```json
{
  "end_line": 204,
  "entity_kind": "class",
  "parent": "manager",
  "start_line": 180,
  "symbol": "ManagerDescriptor"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/manager.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":180,"selector":"L180-L204","symbol":"ManagerDescriptor"}`

## Referenced by

None.

## Subject

[django/db/models/manager::ManagerDescriptor](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 204,
    "entity_kind": "class",
    "parent": "manager",
    "start_line": 180,
    "symbol": "ManagerDescriptor"
  },
  "id": "a5a29324-2f00-4112-83d6-5757a42d7812",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.5393770+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 180,
        "selector": "L180-L204",
        "symbol": "ManagerDescriptor"
      },
      "rel": "derived_from",
      "target": "django/db/models/manager.py"
    }
  ],
  "status": "live",
  "subject_id": "f8e8f773-e646-4ed8-a269-4b91a36f753c",
  "subject_name": "django/db/models/manager::ManagerDescriptor",
  "tags": [
    "entity:class"
  ],
  "text": "class ManagerDescriptor"
}
```
