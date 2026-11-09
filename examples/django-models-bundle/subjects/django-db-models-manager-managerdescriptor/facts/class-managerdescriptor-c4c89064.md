# Fact c4c89064

Store id: 43e0b834-d070-40d3-a39a-f0175fc63649

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
- posted_at: `2026-11-09T23:44:55.3137000+00:00`

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
  "id": "43e0b834-d070-40d3-a39a-f0175fc63649",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.3137000+00:00"
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
  "subject_id": "b6d6c821-5413-49b7-bc00-5839757bc299",
  "subject_name": "django/db/models/manager::ManagerDescriptor",
  "tags": [
    "entity:class"
  ],
  "text": "class ManagerDescriptor"
}
```
