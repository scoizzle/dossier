# Fact e7576e57

Store id: 1d748825-2097-462e-a370-008cc5d28dc8

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
- posted_at: `2026-11-09T23:31:58.0269620+00:00`

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
  "id": "1d748825-2097-462e-a370-008cc5d28dc8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.0269620+00:00"
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
  "subject_id": "39d12859-8e7a-4af1-b9d7-e7489dd00ada",
  "subject_name": "django/db/models/fields/json::KeyTransformIRegex",
  "tags": [
    "entity:class"
  ],
  "text": "class KeyTransformIRegex( CaseInsensitiveMixin, KeyTransformTextLookupMixin, lookups.IRegex )"
}
```
