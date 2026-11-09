# Fact fef4d453

Store id: b356469c-f70b-4388-ba4f-2be3e66a3c69

## Text

```text
class KeyTransformEndsWith(KeyTransformTextLookupMixin, lookups.EndsWith)
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
- posted_at: `2026-11-09T22:39:43.7484060+00:00`

## Data

```json
{
  "end_line": 701,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 700,
  "symbol": "KeyTransformEndsWith"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":700,"selector":"L700-L701","symbol":"KeyTransformEndsWith"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTransformEndsWith](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 701,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 700,
    "symbol": "KeyTransformEndsWith"
  },
  "id": "b356469c-f70b-4388-ba4f-2be3e66a3c69",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.7484060+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 700,
        "selector": "L700-L701",
        "symbol": "KeyTransformEndsWith"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "938dd105-e73e-463f-8ea7-b025ca8e0d89",
  "subject_name": "django/db/models/fields/json::KeyTransformEndsWith",
  "tags": [
    "entity:class"
  ],
  "text": "class KeyTransformEndsWith(KeyTransformTextLookupMixin, lookups.EndsWith)"
}
```
