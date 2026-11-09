# Fact 253182cd

Store id: 7560d67c-4cd3-403d-8c9b-598b6c8236cc

## Text

```text
class BigIntegerField(IntegerField)
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
- posted_at: `2026-11-09T23:31:56.7088740+00:00`

## Data

```json
{
  "end_line": 2255,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 2241,
  "symbol": "BigIntegerField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2241,"selector":"L2241-L2255","symbol":"BigIntegerField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::BigIntegerField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2255,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 2241,
    "symbol": "BigIntegerField"
  },
  "id": "7560d67c-4cd3-403d-8c9b-598b6c8236cc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.7088740+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2241,
        "selector": "L2241-L2255",
        "symbol": "BigIntegerField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "3117325a-0c44-4df3-850c-0b995f22ae9d",
  "subject_name": "django/db/models/fields/__init__::BigIntegerField",
  "tags": [
    "entity:class"
  ],
  "text": "class BigIntegerField(IntegerField)"
}
```
