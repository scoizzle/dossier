# Fact 828c80cd

Store id: b2df627a-dc77-4fb5-8dd0-fcc5d1a3dc64

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
- posted_at: `2026-11-09T23:31:59.2295680+00:00`

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
  "id": "b2df627a-dc77-4fb5-8dd0-fcc5d1a3dc64",
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
    "posted_at": "2026-11-09T23:31:59.2295680+00:00"
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
  "subject_id": "c0b30863-fa0e-4f20-90d7-c8ed57a7d290",
  "subject_name": "django/db/models/fields/related_descriptors::create_reverse_many_to_one_manager",
  "tags": [
    "entity:function"
  ],
  "text": "def create_reverse_many_to_one_manager(superclass, rel)"
}
```
