# Fact 6a3c6079

Store id: db6e309d-0188-4654-a383-ce4b49de05cc

## Text

```text
class RelatedLookupMixin
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
- posted_at: `2026-11-09T22:39:45.1062210+00:00`

## Data

```json
{
  "end_line": 128,
  "entity_kind": "class",
  "parent": "related_lookups",
  "start_line": 98,
  "symbol": "RelatedLookupMixin"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":98,"selector":"L98-L128","symbol":"RelatedLookupMixin"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_lookups::RelatedLookupMixin](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 128,
    "entity_kind": "class",
    "parent": "related_lookups",
    "start_line": 98,
    "symbol": "RelatedLookupMixin"
  },
  "id": "db6e309d-0188-4654-a383-ce4b49de05cc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.1062210+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 98,
        "selector": "L98-L128",
        "symbol": "RelatedLookupMixin"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "977b49e5-1c91-4ed5-9ab5-ac8f744fee6f",
  "subject_name": "django/db/models/fields/related_lookups::RelatedLookupMixin",
  "tags": [
    "entity:class"
  ],
  "text": "class RelatedLookupMixin"
}
```
