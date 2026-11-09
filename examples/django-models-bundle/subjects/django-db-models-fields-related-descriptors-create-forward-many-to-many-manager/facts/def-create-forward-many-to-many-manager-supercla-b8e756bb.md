# Fact b8e756bb

Store id: 74d178e6-594a-4902-a70f-c814b4f81dd8

## Text

```text
def create_forward_many_to_many_manager(superclass, rel, reverse)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:51.9586210+00:00`

## Data

```json
{
  "end_line": 1714,
  "entity_kind": "function",
  "parent": "related_descriptors",
  "start_line": 1075,
  "symbol": "create_forward_many_to_many_manager"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1075,"selector":"L1075-L1714","symbol":"create_forward_many_to_many_manager"}`

## Items

```json
[
  {
    "text": "Create a manager for the either side of a many-to-many relation.",
    "locator": {
      "line": 1076
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_forward_many_to_many_manager](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1714,
    "entity_kind": "function",
    "parent": "related_descriptors",
    "start_line": 1075,
    "symbol": "create_forward_many_to_many_manager"
  },
  "id": "74d178e6-594a-4902-a70f-c814b4f81dd8",
  "items": [
    {
      "locator": {
        "line": 1076
      },
      "text": "Create a manager for the either side of a many-to-many relation."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.9586210+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1075,
        "selector": "L1075-L1714",
        "symbol": "create_forward_many_to_many_manager"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "c8942752-eb2d-4c50-b2e4-726b02ff8489",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager",
  "tags": [
    "entity:function"
  ],
  "text": "def create_forward_many_to_many_manager(superclass, rel, reverse)"
}
```
