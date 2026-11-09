# Fact 11d864ec

Store id: b97f35b5-7498-4f15-a6a8-9bded2ccf978

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
- posted_at: `2026-11-09T23:32:00.0316370+00:00`

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
  "id": "b97f35b5-7498-4f15-a6a8-9bded2ccf978",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.0316370+00:00"
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
  "subject_id": "0a3b82b1-4898-4b81-96fc-cccac2857419",
  "subject_name": "django/db/models/fields/related_lookups::RelatedIsNull",
  "tags": [
    "entity:class"
  ],
  "text": "class RelatedIsNull(RelatedLookupMixin, IsNull)"
}
```
