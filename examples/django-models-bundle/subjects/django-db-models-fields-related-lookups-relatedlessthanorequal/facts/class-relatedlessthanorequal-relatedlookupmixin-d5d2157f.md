# Fact d5d2157f

Store id: b4727fb3-65cd-4598-aeca-73ff76b9e889

## Text

```text
class RelatedLessThanOrEqual(RelatedLookupMixin, LessThanOrEqual)
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
- posted_at: `2026-11-09T23:44:52.2878690+00:00`

## Data

```json
{
  "end_line": 148,
  "entity_kind": "class",
  "parent": "related_lookups",
  "start_line": 147,
  "symbol": "RelatedLessThanOrEqual"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":147,"selector":"L147-L148","symbol":"RelatedLessThanOrEqual"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_lookups::RelatedLessThanOrEqual](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 148,
    "entity_kind": "class",
    "parent": "related_lookups",
    "start_line": 147,
    "symbol": "RelatedLessThanOrEqual"
  },
  "id": "b4727fb3-65cd-4598-aeca-73ff76b9e889",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.2878690+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 147,
        "selector": "L147-L148",
        "symbol": "RelatedLessThanOrEqual"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "6d7b3527-a18d-48b6-845b-560a9d0b5d8c",
  "subject_name": "django/db/models/fields/related_lookups::RelatedLessThanOrEqual",
  "tags": [
    "entity:class"
  ],
  "text": "class RelatedLessThanOrEqual(RelatedLookupMixin, LessThanOrEqual)"
}
```
