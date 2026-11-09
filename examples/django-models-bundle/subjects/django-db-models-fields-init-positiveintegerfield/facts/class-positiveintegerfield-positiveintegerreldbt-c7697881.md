# Fact c7697881

Store id: 21ac6f12-721e-4065-84be-cdb977f9e597

## Text

```text
class PositiveIntegerField(PositiveIntegerRelDbTypeMixin, IntegerField)
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
- posted_at: `2026-11-09T23:31:56.7714230+00:00`

## Data

```json
{
  "end_line": 2469,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 2457,
  "symbol": "PositiveIntegerField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2457,"selector":"L2457-L2469","symbol":"PositiveIntegerField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::PositiveIntegerField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2469,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 2457,
    "symbol": "PositiveIntegerField"
  },
  "id": "21ac6f12-721e-4065-84be-cdb977f9e597",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.7714230+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2457,
        "selector": "L2457-L2469",
        "symbol": "PositiveIntegerField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "856112ee-3f32-49e6-8c69-82a52640312e",
  "subject_name": "django/db/models/fields/__init__::PositiveIntegerField",
  "tags": [
    "entity:class"
  ],
  "text": "class PositiveIntegerField(PositiveIntegerRelDbTypeMixin, IntegerField)"
}
```
