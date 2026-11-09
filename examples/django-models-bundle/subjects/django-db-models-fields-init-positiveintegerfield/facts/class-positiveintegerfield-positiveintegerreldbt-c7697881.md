# Fact c7697881

Store id: 44d8449f-4967-4d36-9b9e-2eec8d36a57a

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
- posted_at: `2026-11-09T22:39:42.6108950+00:00`

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
  "id": "44d8449f-4967-4d36-9b9e-2eec8d36a57a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.6108950+00:00"
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
  "subject_id": "0e613b3a-0777-48b1-84b0-6f551fe45a2d",
  "subject_name": "django/db/models/fields/__init__::PositiveIntegerField",
  "tags": [
    "entity:class"
  ],
  "text": "class PositiveIntegerField(PositiveIntegerRelDbTypeMixin, IntegerField)"
}
```
