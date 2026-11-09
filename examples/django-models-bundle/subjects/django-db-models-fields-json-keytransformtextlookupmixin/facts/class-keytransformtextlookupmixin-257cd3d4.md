# Fact 257cd3d4

Store id: 34b6b00b-0a67-463a-9134-5d0f35058795

## Text

```text
class KeyTransformTextLookupMixin
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
- posted_at: `2026-11-09T22:39:43.7216690+00:00`

## Data

```json
{
  "end_line": 591,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 572,
  "symbol": "KeyTransformTextLookupMixin"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":572,"selector":"L572-L591","symbol":"KeyTransformTextLookupMixin"}`

## Items

```json
[
  {
    "text": "Mixin for combining with a lookup expecting a text lhs from a JSONField key lookup. On PostgreSQL, make use of the ->> operator instead of casting key values to text and performing the lookup on the resulting representation.",
    "locator": {
      "line": 573
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTransformTextLookupMixin](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 591,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 572,
    "symbol": "KeyTransformTextLookupMixin"
  },
  "id": "34b6b00b-0a67-463a-9134-5d0f35058795",
  "items": [
    {
      "locator": {
        "line": 573
      },
      "text": "Mixin for combining with a lookup expecting a text lhs from a JSONField key lookup. On PostgreSQL, make use of the ->> operator instead of casting key values to text and performing the lookup on the resulting representation."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.7216690+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 572,
        "selector": "L572-L591",
        "symbol": "KeyTransformTextLookupMixin"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "9615212b-ff68-4612-86dd-a62da9df0521",
  "subject_name": "django/db/models/fields/json::KeyTransformTextLookupMixin",
  "tags": [
    "entity:class"
  ],
  "text": "class KeyTransformTextLookupMixin"
}
```
