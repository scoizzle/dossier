# Fact 07c573ee

Store id: 033bfe3f-4bc2-4f27-820c-594b06d815d7

## Text

```text
class KeyTransformLte(KeyTransformNumericLookupMixin, lookups.LessThanOrEqual)
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
- posted_at: `2026-11-09T23:31:58.0355260+00:00`

## Data

```json
{
  "end_line": 733,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 732,
  "symbol": "KeyTransformLte"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":732,"selector":"L732-L733","symbol":"KeyTransformLte"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTransformLte](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 733,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 732,
    "symbol": "KeyTransformLte"
  },
  "id": "033bfe3f-4bc2-4f27-820c-594b06d815d7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.0355260+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 732,
        "selector": "L732-L733",
        "symbol": "KeyTransformLte"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "faae200e-8e6a-4385-8fcb-ed36f59b8f1f",
  "subject_name": "django/db/models/fields/json::KeyTransformLte",
  "tags": [
    "entity:class"
  ],
  "text": "class KeyTransformLte(KeyTransformNumericLookupMixin, lookups.LessThanOrEqual)"
}
```
