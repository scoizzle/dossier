# Fact db913a98

Store id: 03838dce-4d86-4e64-bd05-809e9c2c48bb

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
- posted_at: `2026-11-09T23:44:51.0692060+00:00`

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
  "id": "03838dce-4d86-4e64-bd05-809e9c2c48bb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.0692060+00:00"
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
  "subject_id": "6fdcfdd4-dc99-4a51-ba52-66b2c48d7bc2",
  "subject_name": "django/db/models/fields/json::KeyTransformGt",
  "tags": [
    "entity:class"
  ],
  "text": "class KeyTransformGt(KeyTransformNumericLookupMixin, lookups.GreaterThan)"
}
```
