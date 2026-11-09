# Fact 07c573ee

Store id: f1a4f19b-4359-4d39-837f-fe4d1e031744

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
- posted_at: `2026-11-09T23:44:51.0675570+00:00`

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
  "id": "f1a4f19b-4359-4d39-837f-fe4d1e031744",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.0675570+00:00"
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
  "subject_id": "26306f09-58b8-4ec6-888e-bbac78b77449",
  "subject_name": "django/db/models/fields/json::KeyTransformLte",
  "tags": [
    "entity:class"
  ],
  "text": "class KeyTransformLte(KeyTransformNumericLookupMixin, lookups.LessThanOrEqual)"
}
```
