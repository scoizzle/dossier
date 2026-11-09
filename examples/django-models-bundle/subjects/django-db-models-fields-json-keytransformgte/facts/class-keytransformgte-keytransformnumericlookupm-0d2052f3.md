# Fact 0d2052f3

Store id: 58547430-a16b-49ff-ae4c-98ba7806d854

## Text

```text
class KeyTransformGte(KeyTransformNumericLookupMixin, lookups.GreaterThanOrEqual)
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
- posted_at: `2026-11-09T22:39:43.7659310+00:00`

## Data

```json
{
  "end_line": 741,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 740,
  "symbol": "KeyTransformGte"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":740,"selector":"L740-L741","symbol":"KeyTransformGte"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTransformGte](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 741,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 740,
    "symbol": "KeyTransformGte"
  },
  "id": "58547430-a16b-49ff-ae4c-98ba7806d854",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.7659310+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 740,
        "selector": "L740-L741",
        "symbol": "KeyTransformGte"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "81c68fb7-84c2-497f-b5e3-adfce8a1c2b9",
  "subject_name": "django/db/models/fields/json::KeyTransformGte",
  "tags": [
    "entity:class"
  ],
  "text": "class KeyTransformGte(KeyTransformNumericLookupMixin, lookups.GreaterThanOrEqual)"
}
```
