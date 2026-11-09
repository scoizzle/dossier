# Fact 6a3c6079

Store id: c06435c5-faf4-4d6b-9550-bbe806fa1aa5

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
- posted_at: `2026-11-09T23:31:59.9833330+00:00`

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
  "id": "c06435c5-faf4-4d6b-9550-bbe806fa1aa5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:59.9833330+00:00"
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
  "subject_id": "6f26c6f7-c3fa-4bc5-a4db-0b40006e3f8b",
  "subject_name": "django/db/models/fields/related_lookups::RelatedLookupMixin",
  "tags": [
    "entity:class"
  ],
  "text": "class RelatedLookupMixin"
}
```
