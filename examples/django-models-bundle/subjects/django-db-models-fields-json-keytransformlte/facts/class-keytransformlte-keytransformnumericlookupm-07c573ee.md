# Fact 07c573ee

Store id: b61939bd-0f75-4a5c-afce-6d453d071cfb

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
- posted_at: `2026-11-09T22:39:43.7625950+00:00`

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
  "id": "b61939bd-0f75-4a5c-afce-6d453d071cfb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.7625950+00:00"
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
  "subject_id": "4b173c03-1bf2-45db-9ebc-4d3819a5a751",
  "subject_name": "django/db/models/fields/json::KeyTransformLte",
  "tags": [
    "entity:class"
  ],
  "text": "class KeyTransformLte(KeyTransformNumericLookupMixin, lookups.LessThanOrEqual)"
}
```
