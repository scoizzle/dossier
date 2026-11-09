# Fact d5d2157f

Store id: ad8ffa67-388f-4afe-866b-aaa98a4f7777

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
- posted_at: `2026-11-09T23:32:00.0270090+00:00`

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
  "id": "ad8ffa67-388f-4afe-866b-aaa98a4f7777",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.0270090+00:00"
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
  "subject_id": "9124114d-abb7-4481-8465-10257d90399a",
  "subject_name": "django/db/models/fields/related_lookups::RelatedLessThanOrEqual",
  "tags": [
    "entity:class"
  ],
  "text": "class RelatedLessThanOrEqual(RelatedLookupMixin, LessThanOrEqual)"
}
```
