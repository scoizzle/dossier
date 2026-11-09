# Fact cd28f77d

Store id: 475dc2e5-3d8a-4fce-a854-9bf01ebde8ab

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
- posted_at: `2026-11-09T22:39:48.4390940+00:00`

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
  "id": "475dc2e5-3d8a-4fce-a854-9bf01ebde8ab",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.4390940+00:00"
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
  "subject_id": "aa3aa9ba-69e2-42f1-9dd7-99885c442e2d",
  "subject_name": "django/db/models/manager::BaseManager",
  "tags": [
    "entity:class"
  ],
  "text": "class BaseManager"
}
```
