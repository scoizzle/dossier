# Fact 0657f198

Store id: e9d2907e-989f-42d9-ad92-7319d28027ea

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
- posted_at: `2026-11-09T22:39:48.5114660+00:00`

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
  "id": "e9d2907e-989f-42d9-ad92-7319d28027ea",
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
    "posted_at": "2026-11-09T22:39:48.5114660+00:00"
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
  "subject_id": "0160f587-454e-45d5-a8df-d1877678daee",
  "subject_name": "django/db/models/manager::BaseManager._set_creation_counter",
  "tags": [
    "entity:method"
  ],
  "text": "def _set_creation_counter(self)"
}
```
