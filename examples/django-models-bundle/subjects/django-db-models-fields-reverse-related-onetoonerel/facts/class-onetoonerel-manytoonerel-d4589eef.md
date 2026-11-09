# Fact d4589eef

Store id: 15685661-7373-4b99-9e19-257216067277

## Text

```text
class OneToOneRel(ManyToOneRel)
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
- posted_at: `2026-11-09T23:32:00.3410070+00:00`

## Data

```json
{
  "end_line": 343,
  "entity_kind": "class",
  "parent": "reverse_related",
  "start_line": 313,
  "symbol": "OneToOneRel"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":313,"selector":"L313-L343","symbol":"OneToOneRel"}`

## Items

```json
[
  {
    "text": "Used by OneToOneField to store information about the relation.",
    "locator": {
      "line": 314
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::OneToOneRel](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 343,
    "entity_kind": "class",
    "parent": "reverse_related",
    "start_line": 313,
    "symbol": "OneToOneRel"
  },
  "id": "15685661-7373-4b99-9e19-257216067277",
  "items": [
    {
      "locator": {
        "line": 314
      },
      "text": "Used by OneToOneField to store information about the relation."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.3410070+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 313,
        "selector": "L313-L343",
        "symbol": "OneToOneRel"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "200cf0f5-e28e-4024-86f4-d8fb8a364cea",
  "subject_name": "django/db/models/fields/reverse_related::OneToOneRel",
  "tags": [
    "entity:class"
  ],
  "text": "class OneToOneRel(ManyToOneRel)"
}
```
