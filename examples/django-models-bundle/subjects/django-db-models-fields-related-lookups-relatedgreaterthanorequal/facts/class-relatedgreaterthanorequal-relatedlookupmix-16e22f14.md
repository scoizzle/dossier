# Fact 16e22f14

Store id: 53a5ee58-bd0e-4054-9d4e-e21e70f71eed

## Text

```text
class RelatedGreaterThanOrEqual(RelatedLookupMixin, GreaterThanOrEqual)
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
- posted_at: `2026-11-09T23:32:00.0222190+00:00`

## Data

```json
{
  "end_line": 144,
  "entity_kind": "class",
  "parent": "related_lookups",
  "start_line": 143,
  "symbol": "RelatedGreaterThanOrEqual"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":143,"selector":"L143-L144","symbol":"RelatedGreaterThanOrEqual"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_lookups::RelatedGreaterThanOrEqual](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 144,
    "entity_kind": "class",
    "parent": "related_lookups",
    "start_line": 143,
    "symbol": "RelatedGreaterThanOrEqual"
  },
  "id": "53a5ee58-bd0e-4054-9d4e-e21e70f71eed",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.0222190+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 143,
        "selector": "L143-L144",
        "symbol": "RelatedGreaterThanOrEqual"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "8894b4be-d14d-41d5-a2a0-ee383aeaaa4c",
  "subject_name": "django/db/models/fields/related_lookups::RelatedGreaterThanOrEqual",
  "tags": [
    "entity:class"
  ],
  "text": "class RelatedGreaterThanOrEqual(RelatedLookupMixin, GreaterThanOrEqual)"
}
```
