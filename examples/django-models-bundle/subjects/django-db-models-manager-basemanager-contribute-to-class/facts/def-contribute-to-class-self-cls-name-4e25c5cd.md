# Fact 4e25c5cd

Store id: 80bcb0a7-be0d-4787-99f5-a5211501ea77

## Text

```text
def contribute_to_class(self, cls, name)
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
- posted_at: `2026-11-09T22:39:48.5077070+00:00`

## Data

```json
{
  "end_line": 126,
  "entity_kind": "method",
  "parent": "BaseManager",
  "start_line": 120,
  "symbol": "BaseManager.contribute_to_class"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/manager.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":120,"selector":"L120-L126","symbol":"BaseManager.contribute_to_class"}`

## Referenced by

None.

## Subject

[django/db/models/manager::BaseManager.contribute_to_class](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 126,
    "entity_kind": "method",
    "parent": "BaseManager",
    "start_line": 120,
    "symbol": "BaseManager.contribute_to_class"
  },
  "id": "80bcb0a7-be0d-4787-99f5-a5211501ea77",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.5077070+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 120,
        "selector": "L120-L126",
        "symbol": "BaseManager.contribute_to_class"
      },
      "rel": "derived_from",
      "target": "django/db/models/manager.py"
    }
  ],
  "status": "live",
  "subject_id": "bf7c1aa0-f4ac-4aaa-83ae-93d9d59a8f28",
  "subject_name": "django/db/models/manager::BaseManager.contribute_to_class",
  "tags": [
    "entity:method"
  ],
  "text": "def contribute_to_class(self, cls, name)"
}
```
