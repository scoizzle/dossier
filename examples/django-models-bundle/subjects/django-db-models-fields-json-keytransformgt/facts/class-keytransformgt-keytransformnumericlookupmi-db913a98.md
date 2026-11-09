# Fact db913a98

Store id: 788de3ff-63cc-443f-8b86-5622bc0bce39

## Text

```text
class KeyTransformGt(KeyTransformNumericLookupMixin, lookups.GreaterThan)
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
- posted_at: `2026-11-09T22:39:43.7642770+00:00`

## Data

```json
{
  "end_line": 737,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 736,
  "symbol": "KeyTransformGt"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":736,"selector":"L736-L737","symbol":"KeyTransformGt"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTransformGt](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 737,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 736,
    "symbol": "KeyTransformGt"
  },
  "id": "788de3ff-63cc-443f-8b86-5622bc0bce39",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.7642770+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 736,
        "selector": "L736-L737",
        "symbol": "KeyTransformGt"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "8d46b66f-b309-4720-af2d-658db668cdc8",
  "subject_name": "django/db/models/fields/json::KeyTransformGt",
  "tags": [
    "entity:class"
  ],
  "text": "class KeyTransformGt(KeyTransformNumericLookupMixin, lookups.GreaterThan)"
}
```
