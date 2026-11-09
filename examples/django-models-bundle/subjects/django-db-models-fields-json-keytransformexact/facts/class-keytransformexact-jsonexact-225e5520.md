# Fact 225e5520

Store id: 7fcbb858-7038-4fe1-9c14-2ea1a7d09c12

## Text

```text
class KeyTransformExact(JSONExact)
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
- posted_at: `2026-11-09T23:44:51.0422980+00:00`

## Data

```json
{
  "end_line": 663,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 622,
  "symbol": "KeyTransformExact"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":622,"selector":"L622-L663","symbol":"KeyTransformExact"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTransformExact](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 663,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 622,
    "symbol": "KeyTransformExact"
  },
  "id": "7fcbb858-7038-4fe1-9c14-2ea1a7d09c12",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.0422980+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 622,
        "selector": "L622-L663",
        "symbol": "KeyTransformExact"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "074838c5-c6a9-47e0-ac56-21a6b639f483",
  "subject_name": "django/db/models/fields/json::KeyTransformExact",
  "tags": [
    "entity:class"
  ],
  "text": "class KeyTransformExact(JSONExact)"
}
```
