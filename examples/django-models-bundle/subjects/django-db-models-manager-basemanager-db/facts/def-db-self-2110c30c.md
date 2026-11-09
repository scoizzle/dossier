# Fact 2110c30c

Store id: f0cf5290-4143-41ed-834e-90be8f31f0c3

## Text

```text
def db(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:48.5179600+00:00`

## Data

```json
{
  "end_line": 144,
  "entity_kind": "method",
  "parent": "BaseManager",
  "start_line": 142,
  "symbol": "BaseManager.db"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/manager.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":142,"selector":"L142-L144","symbol":"BaseManager.db"}`

## Referenced by

None.

## Subject

[django/db/models/manager::BaseManager.db](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 144,
    "entity_kind": "method",
    "parent": "BaseManager",
    "start_line": 142,
    "symbol": "BaseManager.db"
  },
  "id": "f0cf5290-4143-41ed-834e-90be8f31f0c3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.5179600+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 142,
        "selector": "L142-L144",
        "symbol": "BaseManager.db"
      },
      "rel": "derived_from",
      "target": "django/db/models/manager.py"
    }
  ],
  "status": "live",
  "subject_id": "694a67cf-858f-4bb4-95d1-c5c59eb37e9e",
  "subject_name": "django/db/models/manager::BaseManager.db",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def db(self)"
}
```
