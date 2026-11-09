# Fact d4589eef

Store id: 8038c368-cb15-4ca5-a173-32e133bbfc89

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
- posted_at: `2026-11-09T23:44:52.5205550+00:00`

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
  "id": "8038c368-cb15-4ca5-a173-32e133bbfc89",
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
    "posted_at": "2026-11-09T23:44:52.5205550+00:00"
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
  "subject_id": "15d31121-d3a7-4ee4-9fa2-1fa469f4b265",
  "subject_name": "django/db/models/fields/reverse_related::OneToOneRel",
  "tags": [
    "entity:class"
  ],
  "text": "class OneToOneRel(ManyToOneRel)"
}
```
