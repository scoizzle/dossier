# Fact 0b5ebb17

Store id: 975d5292-c236-4081-82b9-64423071cafd

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
- posted_at: `2026-11-09T23:31:58.0335060+00:00`

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
  "id": "975d5292-c236-4081-82b9-64423071cafd",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.0335060+00:00"
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
  "subject_id": "d1c99caa-a36b-4d2e-85a3-461bbea7c207",
  "subject_name": "django/db/models/fields/json::KeyTransformLt",
  "tags": [
    "entity:class"
  ],
  "text": "class KeyTransformLt(KeyTransformNumericLookupMixin, lookups.LessThan)"
}
```
