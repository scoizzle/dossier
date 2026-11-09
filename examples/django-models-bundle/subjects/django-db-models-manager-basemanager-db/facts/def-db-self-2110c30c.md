# Fact 2110c30c

Store id: 8b74bd7f-706b-4f9f-889f-081efdb1e1c1

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
- posted_at: `2026-11-09T23:32:03.6982740+00:00`

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
  "id": "8b74bd7f-706b-4f9f-889f-081efdb1e1c1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.6982740+00:00"
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
  "subject_id": "710d4bae-85b3-48dd-9e80-c792f69854ec",
  "subject_name": "django/db/models/manager::BaseManager.db",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def db(self)"
}
```
