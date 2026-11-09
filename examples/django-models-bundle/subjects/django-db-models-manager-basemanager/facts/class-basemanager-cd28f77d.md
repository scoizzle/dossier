# Fact cd28f77d

Store id: 18d21322-93ad-498b-9739-270adeb8aed7

## Text

```text
class BaseManager
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
- posted_at: `2026-11-09T23:44:55.2393450+00:00`

## Data

```json
{
  "end_line": 173,
  "entity_kind": "class",
  "parent": "manager",
  "start_line": 10,
  "symbol": "BaseManager"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/manager.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":10,"selector":"L10-L173","symbol":"BaseManager"}`

## Referenced by

None.

## Subject

[django/db/models/manager::BaseManager](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 173,
    "entity_kind": "class",
    "parent": "manager",
    "start_line": 10,
    "symbol": "BaseManager"
  },
  "id": "18d21322-93ad-498b-9739-270adeb8aed7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.2393450+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 10,
        "selector": "L10-L173",
        "symbol": "BaseManager"
      },
      "rel": "derived_from",
      "target": "django/db/models/manager.py"
    }
  ],
  "status": "live",
  "subject_id": "e70e161d-fbee-46af-85ff-f1075f414966",
  "subject_name": "django/db/models/manager::BaseManager",
  "tags": [
    "entity:class"
  ],
  "text": "class BaseManager"
}
```
