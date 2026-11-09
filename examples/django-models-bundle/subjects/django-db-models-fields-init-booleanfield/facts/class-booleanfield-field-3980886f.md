# Fact 3980886f

Store id: cb29eb7c-53f0-4d1a-89d5-7c24d65b90c0

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
- posted_at: `2026-11-09T22:39:42.3649210+00:00`

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
  "id": "cb29eb7c-53f0-4d1a-89d5-7c24d65b90c0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.3649210+00:00"
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
  "subject_id": "95e67432-77b2-4dcc-ac82-a68c274fddfb",
  "subject_name": "django/db/models/fields/__init__::BooleanField",
  "tags": [
    "entity:class"
  ],
  "text": "class BooleanField(Field)"
}
```
