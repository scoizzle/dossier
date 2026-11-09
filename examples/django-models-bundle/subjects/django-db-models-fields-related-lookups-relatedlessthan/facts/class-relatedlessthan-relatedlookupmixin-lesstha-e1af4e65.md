# Fact e1af4e65

Store id: ec81abc8-94cb-4e98-979f-a385df6f6ce3

## Text

```text
class RelatedLessThan(RelatedLookupMixin, LessThan)
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
- posted_at: `2026-11-09T23:44:52.2643510+00:00`

## Data

```json
{
  "end_line": 136,
  "entity_kind": "class",
  "parent": "related_lookups",
  "start_line": 135,
  "symbol": "RelatedLessThan"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":135,"selector":"L135-L136","symbol":"RelatedLessThan"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_lookups::RelatedLessThan](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 136,
    "entity_kind": "class",
    "parent": "related_lookups",
    "start_line": 135,
    "symbol": "RelatedLessThan"
  },
  "id": "ec81abc8-94cb-4e98-979f-a385df6f6ce3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.2643510+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 135,
        "selector": "L135-L136",
        "symbol": "RelatedLessThan"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "54b917db-7bdc-4058-9dbc-9c1c04310402",
  "subject_name": "django/db/models/fields/related_lookups::RelatedLessThan",
  "tags": [
    "entity:class"
  ],
  "text": "class RelatedLessThan(RelatedLookupMixin, LessThan)"
}
```
