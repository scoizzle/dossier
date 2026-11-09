# Fact 0657f198

Store id: aff78fc5-cfa1-49e7-9a0d-761151f6c3d0

## Text

```text
def _set_creation_counter(self)
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
- posted_at: `2026-11-09T23:44:55.2918080+00:00`

## Data

```json
{
  "end_line": 134,
  "entity_kind": "method",
  "parent": "BaseManager",
  "start_line": 128,
  "symbol": "BaseManager._set_creation_counter"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/manager.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":128,"selector":"L128-L134","symbol":"BaseManager._set_creation_counter"}`

## Items

```json
[
  {
    "text": "Set the creation counter value for this instance and increment the class-level copy.",
    "locator": {
      "line": 129
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/manager::BaseManager._set_creation_counter](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 134,
    "entity_kind": "method",
    "parent": "BaseManager",
    "start_line": 128,
    "symbol": "BaseManager._set_creation_counter"
  },
  "id": "aff78fc5-cfa1-49e7-9a0d-761151f6c3d0",
  "items": [
    {
      "locator": {
        "line": 129
      },
      "text": "Set the creation counter value for this instance and increment the class-level copy."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.2918080+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 128,
        "selector": "L128-L134",
        "symbol": "BaseManager._set_creation_counter"
      },
      "rel": "derived_from",
      "target": "django/db/models/manager.py"
    }
  ],
  "status": "live",
  "subject_id": "06b949cd-68d7-4fa4-bd72-4f0f9a4fd76b",
  "subject_name": "django/db/models/manager::BaseManager._set_creation_counter",
  "tags": [
    "entity:method"
  ],
  "text": "def _set_creation_counter(self)"
}
```
