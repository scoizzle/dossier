# Fact 75f005e4

Store id: ea03ddb0-e4fe-4536-8ffc-860b5e4983d2

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
- posted_at: `2026-11-09T23:32:03.7049560+00:00`

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
  "id": "ea03ddb0-e4fe-4536-8ffc-860b5e4983d2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.7049560+00:00"
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
  "subject_id": "c72311b3-d0f8-4353-bb89-86ab3ebed0c2",
  "subject_name": "django/db/models/manager::BaseManager.all",
  "tags": [
    "entity:method"
  ],
  "text": "def all(self)"
}
```
