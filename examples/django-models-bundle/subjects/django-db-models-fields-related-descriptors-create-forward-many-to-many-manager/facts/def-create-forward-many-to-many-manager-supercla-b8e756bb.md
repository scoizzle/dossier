# Fact b8e756bb

Store id: 8e26cc1c-b623-4de1-a7c6-8237dadc0615

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
- posted_at: `2026-11-09T22:39:44.8502050+00:00`

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
  "id": "8e26cc1c-b623-4de1-a7c6-8237dadc0615",
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
    "posted_at": "2026-11-09T22:39:44.8502050+00:00"
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
  "subject_id": "f2a5952d-cd1f-470c-afee-e5e776292e55",
  "subject_name": "django/db/models/fields/related_descriptors::create_forward_many_to_many_manager",
  "tags": [
    "entity:function"
  ],
  "text": "def create_forward_many_to_many_manager(superclass, rel, reverse)"
}
```
