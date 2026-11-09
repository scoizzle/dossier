# Fact e7576e57

Store id: 4e7aee66-8b2b-4053-9c49-3f047308fcd0

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
- posted_at: `2026-11-09T23:44:51.0606580+00:00`

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
  "id": "4e7aee66-8b2b-4053-9c49-3f047308fcd0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.0606580+00:00"
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
  "subject_id": "74a1fa7e-d2b6-4eae-9387-a783e65e9872",
  "subject_name": "django/db/models/fields/json::KeyTransformIRegex",
  "tags": [
    "entity:class"
  ],
  "text": "class KeyTransformIRegex( CaseInsensitiveMixin, KeyTransformTextLookupMixin, lookups.IRegex )"
}
```
