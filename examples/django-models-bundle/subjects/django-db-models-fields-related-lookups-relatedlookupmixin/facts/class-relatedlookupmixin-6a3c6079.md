# Fact 6a3c6079

Store id: 4d8d8661-b8a3-4102-8cf6-0aa5aa470e29

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
- posted_at: `2026-11-09T23:44:52.2487150+00:00`

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
  "id": "4d8d8661-b8a3-4102-8cf6-0aa5aa470e29",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.2487150+00:00"
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
  "subject_id": "5998eb16-5e4a-451d-a559-4490d56169af",
  "subject_name": "django/db/models/fields/related_lookups::RelatedLookupMixin",
  "tags": [
    "entity:class"
  ],
  "text": "class RelatedLookupMixin"
}
```
