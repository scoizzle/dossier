# Fact 976f3a2e

Store id: f7f74a1c-320a-45f6-a811-e98760a40935

## Text

```text
class RelatedGreaterThan(RelatedLookupMixin, GreaterThan)
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
- posted_at: `2026-11-09T22:39:45.1294700+00:00`

## Data

```json
{
  "end_line": 140,
  "entity_kind": "class",
  "parent": "related_lookups",
  "start_line": 139,
  "symbol": "RelatedGreaterThan"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":139,"selector":"L139-L140","symbol":"RelatedGreaterThan"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_lookups::RelatedGreaterThan](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 140,
    "entity_kind": "class",
    "parent": "related_lookups",
    "start_line": 139,
    "symbol": "RelatedGreaterThan"
  },
  "id": "f7f74a1c-320a-45f6-a811-e98760a40935",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.1294700+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 139,
        "selector": "L139-L140",
        "symbol": "RelatedGreaterThan"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "6216b244-8392-4912-b220-3229434656bf",
  "subject_name": "django/db/models/fields/related_lookups::RelatedGreaterThan",
  "tags": [
    "entity:class"
  ],
  "text": "class RelatedGreaterThan(RelatedLookupMixin, GreaterThan)"
}
```
