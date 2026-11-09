# Fact 2110c30c

Store id: 841eb24f-f06d-417b-b0ea-80b8b427444e

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
- posted_at: `2026-11-09T23:44:55.2971760+00:00`

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
  "id": "841eb24f-f06d-417b-b0ea-80b8b427444e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.2971760+00:00"
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
  "subject_id": "c70e123c-5228-4f23-bc7c-45700f59c396",
  "subject_name": "django/db/models/manager::BaseManager.db",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def db(self)"
}
```
