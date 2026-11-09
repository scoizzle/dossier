# Fact 29da2456

Store id: 1ea14a8d-253f-4bab-9601-52bdeabc78ac

## Text

```text
class KeyTransformFactory
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
- posted_at: `2026-11-09T22:39:43.7677640+00:00`

## Data

```json
{
  "end_line": 767,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 762,
  "symbol": "KeyTransformFactory"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":762,"selector":"L762-L767","symbol":"KeyTransformFactory"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTransformFactory](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 767,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 762,
    "symbol": "KeyTransformFactory"
  },
  "id": "1ea14a8d-253f-4bab-9601-52bdeabc78ac",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.7677640+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 762,
        "selector": "L762-L767",
        "symbol": "KeyTransformFactory"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "749e61de-a1aa-4a71-99f9-e31ba4df384b",
  "subject_name": "django/db/models/fields/json::KeyTransformFactory",
  "tags": [
    "entity:class"
  ],
  "text": "class KeyTransformFactory"
}
```
