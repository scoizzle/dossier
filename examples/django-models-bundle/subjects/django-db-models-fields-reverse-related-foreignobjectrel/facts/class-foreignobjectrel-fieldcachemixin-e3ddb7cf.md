# Fact e3ddb7cf

Store id: d3a7cfb6-8f98-461f-87e6-b725b518e27d

## Text

```text
class ForeignObjectRel(FieldCacheMixin)
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
- posted_at: `2026-11-09T23:44:52.4081090+00:00`

## Data

```json
{
  "end_line": 248,
  "entity_kind": "class",
  "parent": "reverse_related",
  "start_line": 20,
  "symbol": "ForeignObjectRel"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":20,"selector":"L20-L248","symbol":"ForeignObjectRel"}`

## Items

```json
[
  {
    "text": "Used by ForeignObject to store information about the relation.",
    "locator": {
      "line": 21
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ForeignObjectRel](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 248,
    "entity_kind": "class",
    "parent": "reverse_related",
    "start_line": 20,
    "symbol": "ForeignObjectRel"
  },
  "id": "d3a7cfb6-8f98-461f-87e6-b725b518e27d",
  "items": [
    {
      "locator": {
        "line": 21
      },
      "text": "Used by ForeignObject to store information about the relation."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.4081090+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 20,
        "selector": "L20-L248",
        "symbol": "ForeignObjectRel"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "510c9e1c-006d-4641-b50f-538275ae0712",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel",
  "tags": [
    "entity:class"
  ],
  "text": "class ForeignObjectRel(FieldCacheMixin)"
}
```
