# Fact b6fb5119

Store id: 4e3957d0-805b-49d6-81be-f3e8d164e4de

## Text

```text
class KeyTransformIStartsWith( CaseInsensitiveMixin, KeyTransformTextLookupMixin, lookups.IStartsWith )
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
- posted_at: `2026-11-09T22:39:43.7460820+00:00`

## Data

```json
{
  "end_line": 697,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 694,
  "symbol": "KeyTransformIStartsWith"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":694,"selector":"L694-L697","symbol":"KeyTransformIStartsWith"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTransformIStartsWith](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 697,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 694,
    "symbol": "KeyTransformIStartsWith"
  },
  "id": "4e3957d0-805b-49d6-81be-f3e8d164e4de",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.7460820+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 694,
        "selector": "L694-L697",
        "symbol": "KeyTransformIStartsWith"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "e830806e-b02d-43c0-b3e5-c10b614814e6",
  "subject_name": "django/db/models/fields/json::KeyTransformIStartsWith",
  "tags": [
    "entity:class"
  ],
  "text": "class KeyTransformIStartsWith( CaseInsensitiveMixin, KeyTransformTextLookupMixin, lookups.IStartsWith )"
}
```
