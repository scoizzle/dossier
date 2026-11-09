# Fact 828c80cd

Store id: 0e39dec2-231f-4f80-92bf-267229e06e59

## Text

```text
def create_reverse_many_to_one_manager(superclass, rel)
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
- posted_at: `2026-11-09T22:39:44.7837160+00:00`

## Data

```json
{
  "end_line": 1025,
  "entity_kind": "function",
  "parent": "related_descriptors",
  "start_line": 714,
  "symbol": "create_reverse_many_to_one_manager"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":714,"selector":"L714-L1025","symbol":"create_reverse_many_to_one_manager"}`

## Items

```json
[
  {
    "text": "Create a manager for the reverse side of a many-to-one relation.",
    "locator": {
      "line": 715
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1025,
    "entity_kind": "function",
    "parent": "related_descriptors",
    "start_line": 714,
    "symbol": "create_reverse_many_to_one_manager"
  },
  "id": "0e39dec2-231f-4f80-92bf-267229e06e59",
  "items": [
    {
      "locator": {
        "line": 715
      },
      "text": "Create a manager for the reverse side of a many-to-one relation."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.7837160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 714,
        "selector": "L714-L1025",
        "symbol": "create_reverse_many_to_one_manager"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "af14aa2e-2947-45d9-bcc6-78c03ea8fb83",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager",
  "tags": [
    "entity:function"
  ],
  "text": "def create_reverse_many_to_one_manager(superclass, rel)"
}
```
