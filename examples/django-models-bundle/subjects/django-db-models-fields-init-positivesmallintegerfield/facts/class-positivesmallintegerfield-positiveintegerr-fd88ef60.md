# Fact fd88ef60

Store id: 62e4b061-bd20-48c2-8843-21f33a909f00

## Text

```text
class PositiveSmallIntegerField(PositiveIntegerRelDbTypeMixin, SmallIntegerField)
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
- posted_at: `2026-11-09T23:31:56.7760350+00:00`

## Data

```json
{
  "end_line": 2484,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 2472,
  "symbol": "PositiveSmallIntegerField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2472,"selector":"L2472-L2484","symbol":"PositiveSmallIntegerField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::PositiveSmallIntegerField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2484,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 2472,
    "symbol": "PositiveSmallIntegerField"
  },
  "id": "62e4b061-bd20-48c2-8843-21f33a909f00",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.7760350+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2472,
        "selector": "L2472-L2484",
        "symbol": "PositiveSmallIntegerField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "b78b7844-16cd-412d-ac34-f2c00d57c404",
  "subject_name": "django/db/models/fields/__init__::PositiveSmallIntegerField",
  "tags": [
    "entity:class"
  ],
  "text": "class PositiveSmallIntegerField(PositiveIntegerRelDbTypeMixin, SmallIntegerField)"
}
```
