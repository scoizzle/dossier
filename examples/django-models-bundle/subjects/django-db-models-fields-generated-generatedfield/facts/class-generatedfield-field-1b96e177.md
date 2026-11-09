# Fact 1b96e177

Store id: 98340ae9-dd8d-48cb-8e7d-42a8a130c7a3

## Text

```text
class GeneratedField(Field)
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
- posted_at: `2026-11-09T22:39:43.4128560+00:00`

## Data

```json
{
  "end_line": 207,
  "entity_kind": "class",
  "parent": "generated",
  "start_line": 11,
  "symbol": "GeneratedField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/generated.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":11,"selector":"L11-L207","symbol":"GeneratedField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/generated::GeneratedField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 207,
    "entity_kind": "class",
    "parent": "generated",
    "start_line": 11,
    "symbol": "GeneratedField"
  },
  "id": "98340ae9-dd8d-48cb-8e7d-42a8a130c7a3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:43.4128560+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 11,
        "selector": "L11-L207",
        "symbol": "GeneratedField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/generated.py"
    }
  ],
  "status": "live",
  "subject_id": "a5762a83-a9f6-4c06-856f-82e4f1a334f3",
  "subject_name": "django/db/models/fields/generated::GeneratedField",
  "tags": [
    "entity:class"
  ],
  "text": "class GeneratedField(Field)"
}
```
