# Fact 4e4252a6

Store id: bce7c4d1-2b0c-49b2-832f-3cc60275f93b

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
- posted_at: `2026-11-09T23:44:51.4589870+00:00`

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
  "id": "bce7c4d1-2b0c-49b2-832f-3cc60275f93b",
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
    "posted_at": "2026-11-09T23:44:51.4589870+00:00"
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
  "subject_id": "69d168a4-028d-4814-bd96-691b258bf5f3",
  "subject_name": "django/db/models/fields/related::RelatedField",
  "tags": [
    "entity:class"
  ],
  "text": "class RelatedField(FieldCacheMixin, Field)"
}
```
