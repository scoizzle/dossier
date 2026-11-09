# Fact 4e4252a6

Store id: fa876422-4c12-47b9-814e-22cfdd1540c0

## Text

```text
class RelatedField(FieldCacheMixin, Field)
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
- posted_at: `2026-11-09T22:39:44.2391020+00:00`

## Data

```json
{
  "end_line": 541,
  "entity_kind": "class",
  "parent": "related",
  "start_line": 98,
  "symbol": "RelatedField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":98,"selector":"L98-L541","symbol":"RelatedField"}`

## Items

```json
[
  {
    "text": "Base class that all relational fields inherit from.",
    "locator": {
      "line": 99
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related::RelatedField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 541,
    "entity_kind": "class",
    "parent": "related",
    "start_line": 98,
    "symbol": "RelatedField"
  },
  "id": "fa876422-4c12-47b9-814e-22cfdd1540c0",
  "items": [
    {
      "locator": {
        "line": 99
      },
      "text": "Base class that all relational fields inherit from."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.2391020+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 98,
        "selector": "L98-L541",
        "symbol": "RelatedField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "5e1644c7-1218-4c6b-91fa-0c3297ae6c25",
  "subject_name": "django/db/models/fields/related::RelatedField",
  "tags": [
    "entity:class"
  ],
  "text": "class RelatedField(FieldCacheMixin, Field)"
}
```
