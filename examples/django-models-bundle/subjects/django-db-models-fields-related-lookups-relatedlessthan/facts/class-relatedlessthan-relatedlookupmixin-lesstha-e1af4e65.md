# Fact e1af4e65

Store id: c67f221d-fb8b-4226-bf6c-53dc1629c3da

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
- posted_at: `2026-11-09T22:39:45.1151190+00:00`

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
  "id": "c67f221d-fb8b-4226-bf6c-53dc1629c3da",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.1151190+00:00"
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
  "subject_id": "916824f8-910a-4259-a82e-098889770355",
  "subject_name": "django/db/models/fields/related_lookups::RelatedLessThan",
  "tags": [
    "entity:class"
  ],
  "text": "class RelatedLessThan(RelatedLookupMixin, LessThan)"
}
```
