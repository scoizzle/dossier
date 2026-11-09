# Fact ddb4fa20

Store id: 7dd33d8f-ae31-40b8-b5f3-75c1a1738f57

## Text

```text
class ManyToManyRel(ForeignObjectRel)
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
- posted_at: `2026-11-09T22:39:45.3862400+00:00`

## Data

```json
{
  "end_line": 407,
  "entity_kind": "class",
  "parent": "reverse_related",
  "start_line": 346,
  "symbol": "ManyToManyRel"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":346,"selector":"L346-L407","symbol":"ManyToManyRel"}`

## Items

```json
[
  {
    "text": "Used by ManyToManyField to store information about the relation.",
    "locator": {
      "line": 347
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ManyToManyRel](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 407,
    "entity_kind": "class",
    "parent": "reverse_related",
    "start_line": 346,
    "symbol": "ManyToManyRel"
  },
  "id": "7dd33d8f-ae31-40b8-b5f3-75c1a1738f57",
  "items": [
    {
      "locator": {
        "line": 347
      },
      "text": "Used by ManyToManyField to store information about the relation."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.3862400+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 346,
        "selector": "L346-L407",
        "symbol": "ManyToManyRel"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "78b044fe-d5c4-434c-8711-e02b50135218",
  "subject_name": "django/db/models/fields/reverse_related::ManyToManyRel",
  "tags": [
    "entity:class"
  ],
  "text": "class ManyToManyRel(ForeignObjectRel)"
}
```
