# Fact b6fb5119

Store id: e5e9b519-5566-4c79-bab8-1820cbc5983d

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
- posted_at: `2026-11-09T23:31:58.0174390+00:00`

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
  "id": "e5e9b519-5566-4c79-bab8-1820cbc5983d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.0174390+00:00"
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
  "subject_id": "3820c146-4205-467b-a8ce-da6f989028de",
  "subject_name": "django/db/models/fields/json::KeyTransformIStartsWith",
  "tags": [
    "entity:class"
  ],
  "text": "class KeyTransformIStartsWith( CaseInsensitiveMixin, KeyTransformTextLookupMixin, lookups.IStartsWith )"
}
```
