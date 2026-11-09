# Fact 11d864ec

Store id: 51389743-819a-41b6-971f-9b4ff860782f

## Text

```text
class RelatedIsNull(RelatedLookupMixin, IsNull)
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
- posted_at: `2026-11-09T22:39:45.1372430+00:00`

## Data

```json
{
  "end_line": 152,
  "entity_kind": "class",
  "parent": "related_lookups",
  "start_line": 151,
  "symbol": "RelatedIsNull"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":151,"selector":"L151-L152","symbol":"RelatedIsNull"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_lookups::RelatedIsNull](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 152,
    "entity_kind": "class",
    "parent": "related_lookups",
    "start_line": 151,
    "symbol": "RelatedIsNull"
  },
  "id": "51389743-819a-41b6-971f-9b4ff860782f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.1372430+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 151,
        "selector": "L151-L152",
        "symbol": "RelatedIsNull"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "2a48e5b8-8aa3-490f-9a5c-8d198c22a6ae",
  "subject_name": "django/db/models/fields/related_lookups::RelatedIsNull",
  "tags": [
    "entity:class"
  ],
  "text": "class RelatedIsNull(RelatedLookupMixin, IsNull)"
}
```
