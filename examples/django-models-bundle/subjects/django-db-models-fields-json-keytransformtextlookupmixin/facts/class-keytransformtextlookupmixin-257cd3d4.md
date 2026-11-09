# Fact 257cd3d4

Store id: 817f01b8-0d49-4c3b-b312-1b59a9f97840

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
- posted_at: `2026-11-09T23:44:51.0332920+00:00`

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
  "id": "817f01b8-0d49-4c3b-b312-1b59a9f97840",
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
    "posted_at": "2026-11-09T23:44:51.0332920+00:00"
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
  "subject_id": "74cb5747-764d-42c0-a9cd-b6c7d0afbec2",
  "subject_name": "django/db/models/fields/json::KeyTransformTextLookupMixin",
  "tags": [
    "entity:class"
  ],
  "text": "class KeyTransformTextLookupMixin"
}
```
