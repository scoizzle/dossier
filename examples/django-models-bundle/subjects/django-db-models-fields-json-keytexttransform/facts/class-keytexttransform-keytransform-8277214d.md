# Fact 8277214d

Store id: 474eeb4f-400a-4f5d-9739-c8ce615518b5

## Text

```text
class KeyTextTransform(KeyTransform)
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
- posted_at: `2026-11-09T22:39:43.7159210+00:00`

## Data

```json
{
  "end_line": 566,
  "entity_kind": "class",
  "parent": "json",
  "start_line": 540,
  "symbol": "KeyTextTransform"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":540,"selector":"L540-L566","symbol":"KeyTextTransform"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTextTransform](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 566,
    "entity_kind": "class",
    "parent": "json",
    "start_line": 540,
    "symbol": "KeyTextTransform"
  },
  "id": "474eeb4f-400a-4f5d-9739-c8ce615518b5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.7159210+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 540,
        "selector": "L540-L566",
        "symbol": "KeyTextTransform"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "05d2c823-1aaf-4fa2-97ea-a98914ed4165",
  "subject_name": "django/db/models/fields/json::KeyTextTransform",
  "tags": [
    "entity:class"
  ],
  "text": "class KeyTextTransform(KeyTransform)"
}
```
