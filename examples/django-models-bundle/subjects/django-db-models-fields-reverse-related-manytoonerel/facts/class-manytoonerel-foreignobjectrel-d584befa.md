# Fact d584befa

Store id: 3aa39cd9-fd60-4c1e-836a-13a2e38c173b

## Text

```text
class ManyToOneRel(ForeignObjectRel)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:45.3665740+00:00`

## Data

```json
{
  "end_line": 310,
  "entity_kind": "class",
  "parent": "reverse_related",
  "start_line": 251,
  "symbol": "ManyToOneRel"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":251,"selector":"L251-L310","symbol":"ManyToOneRel"}`

## Items

```json
[
  {
    "text": "Used by the ForeignKey field to store information about the relation.",
    "locator": {
      "line": 252
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ManyToOneRel](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 310,
    "entity_kind": "class",
    "parent": "reverse_related",
    "start_line": 251,
    "symbol": "ManyToOneRel"
  },
  "id": "3aa39cd9-fd60-4c1e-836a-13a2e38c173b",
  "items": [
    {
      "locator": {
        "line": 252
      },
      "text": "Used by the ForeignKey field to store information about the relation."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.3665740+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 251,
        "selector": "L251-L310",
        "symbol": "ManyToOneRel"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "8ec10572-323a-4f87-8e5a-3048ca831beb",
  "subject_name": "django/db/models/fields/reverse_related::ManyToOneRel",
  "tags": [
    "entity:class"
  ],
  "text": "class ManyToOneRel(ForeignObjectRel)"
}
```
