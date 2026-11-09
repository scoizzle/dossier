# Fact 75f005e4

Store id: 4da6688c-537c-489a-b279-a3871d357585

## Text

```text
def all(self)
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
- posted_at: `2026-11-09T23:44:55.3033360+00:00`

## Data

```json
{
  "end_line": 164,
  "entity_kind": "method",
  "parent": "BaseManager",
  "start_line": 157,
  "symbol": "BaseManager.all"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/manager.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":157,"selector":"L157-L164","symbol":"BaseManager.all"}`

## Referenced by

None.

## Subject

[django/db/models/manager::BaseManager.all](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 164,
    "entity_kind": "method",
    "parent": "BaseManager",
    "start_line": 157,
    "symbol": "BaseManager.all"
  },
  "id": "4da6688c-537c-489a-b279-a3871d357585",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.3033360+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 157,
        "selector": "L157-L164",
        "symbol": "BaseManager.all"
      },
      "rel": "derived_from",
      "target": "django/db/models/manager.py"
    }
  ],
  "status": "live",
  "subject_id": "6fc704b9-7d86-42a0-8f4b-1fa3961c2688",
  "subject_name": "django/db/models/manager::BaseManager.all",
  "tags": [
    "entity:method"
  ],
  "text": "def all(self)"
}
```
