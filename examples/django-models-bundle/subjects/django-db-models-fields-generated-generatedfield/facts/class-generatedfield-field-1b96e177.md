# Fact 1b96e177

Store id: 611e1def-a9e7-4336-adb1-798a1c2ea543

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
- posted_at: `2026-11-09T23:31:57.6004430+00:00`

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
  "id": "611e1def-a9e7-4336-adb1-798a1c2ea543",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.6004430+00:00"
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
  "subject_id": "18a4f0e4-51f7-4435-bd91-57ee1af9b705",
  "subject_name": "django/db/models/fields/generated::GeneratedField",
  "tags": [
    "entity:class"
  ],
  "text": "class GeneratedField(Field)"
}
```
