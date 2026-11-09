# Fact 0657f198

Store id: bedf391b-daa4-428f-929b-f73435f49181

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
- posted_at: `2026-11-09T23:32:03.6930100+00:00`

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
  "id": "bedf391b-daa4-428f-929b-f73435f49181",
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
    "posted_at": "2026-11-09T23:32:03.6930100+00:00"
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
  "subject_id": "8cdbf012-6aa8-4bc2-a1f7-7bb020257d6c",
  "subject_name": "django/db/models/manager::BaseManager._set_creation_counter",
  "tags": [
    "entity:method"
  ],
  "text": "def _set_creation_counter(self)"
}
```
