# Fact 0b5ebb17

Store id: f55c84e1-b432-40b5-865a-e48a78f243cf

## Text

```text
class KeyTransformLt(KeyTransformNumericLookupMixin, lookups.LessThan)
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
- posted_at: `2026-11-09T22:39:43.7602650+00:00`

## Data

```json
{
  "end_line": 729,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 728,
  "symbol": "KeyTransformLt"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":728,"selector":"L728-L729","symbol":"KeyTransformLt"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTransformLt](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 729,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 728,
    "symbol": "KeyTransformLt"
  },
  "id": "f55c84e1-b432-40b5-865a-e48a78f243cf",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.7602650+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 728,
        "selector": "L728-L729",
        "symbol": "KeyTransformLt"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "069ff750-ddce-48ca-9a99-528f9d32adf2",
  "subject_name": "django/db/models/fields/json::KeyTransformLt",
  "tags": [
    "entity:class"
  ],
  "text": "class KeyTransformLt(KeyTransformNumericLookupMixin, lookups.LessThan)"
}
```
