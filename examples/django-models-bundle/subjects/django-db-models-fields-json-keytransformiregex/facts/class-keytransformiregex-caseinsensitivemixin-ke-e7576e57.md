# Fact e7576e57

Store id: 2ffc3e20-573d-4572-bd87-6a5b2f745756

## Text

```text
class KeyTransformIRegex( CaseInsensitiveMixin, KeyTransformTextLookupMixin, lookups.IRegex )
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
- posted_at: `2026-11-09T22:39:43.7540110+00:00`

## Data

```json
{
  "end_line": 717,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 714,
  "symbol": "KeyTransformIRegex"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":714,"selector":"L714-L717","symbol":"KeyTransformIRegex"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTransformIRegex](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 717,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 714,
    "symbol": "KeyTransformIRegex"
  },
  "id": "2ffc3e20-573d-4572-bd87-6a5b2f745756",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.7540110+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 714,
        "selector": "L714-L717",
        "symbol": "KeyTransformIRegex"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "c65cb8a4-5c60-419c-898d-5015520a6cb5",
  "subject_name": "django/db/models/fields/json::KeyTransformIRegex",
  "tags": [
    "entity:class"
  ],
  "text": "class KeyTransformIRegex( CaseInsensitiveMixin, KeyTransformTextLookupMixin, lookups.IRegex )"
}
```
