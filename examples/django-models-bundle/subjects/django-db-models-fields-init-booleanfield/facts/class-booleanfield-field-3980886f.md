# Fact 3980886f

Store id: b686afcf-635a-41b6-81e2-5479bd2a217f

## Text

```text
class BooleanField(Field)
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
- posted_at: `2026-11-09T23:31:56.5372170+00:00`

## Data

```json
{
  "end_line": 1243,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 1200,
  "symbol": "BooleanField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1200,"selector":"L1200-L1243","symbol":"BooleanField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::BooleanField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1243,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 1200,
    "symbol": "BooleanField"
  },
  "id": "b686afcf-635a-41b6-81e2-5479bd2a217f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.5372170+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1200,
        "selector": "L1200-L1243",
        "symbol": "BooleanField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "1c691d9d-153d-4fc8-83c6-ad8b6ecd08b7",
  "subject_name": "django/db/models/fields/__init__::BooleanField",
  "tags": [
    "entity:class"
  ],
  "text": "class BooleanField(Field)"
}
```
