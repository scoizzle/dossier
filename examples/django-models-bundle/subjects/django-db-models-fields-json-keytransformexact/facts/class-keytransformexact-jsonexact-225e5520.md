# Fact 225e5520

Store id: c29b7a70-b699-4a3c-a4f6-83e9f055b8b5

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
- posted_at: `2026-11-09T22:39:43.7325040+00:00`

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
  "id": "c29b7a70-b699-4a3c-a4f6-83e9f055b8b5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.7325040+00:00"
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
  "subject_id": "27d88e24-7c2c-421f-91c0-f8f791227e10",
  "subject_name": "django/db/models/fields/json::KeyTransformExact",
  "tags": [
    "entity:class"
  ],
  "text": "class KeyTransformExact(JSONExact)"
}
```
