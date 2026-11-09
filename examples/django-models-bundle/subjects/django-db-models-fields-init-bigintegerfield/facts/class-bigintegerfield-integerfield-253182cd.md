# Fact 253182cd

Store id: 3d783795-5b62-4c17-aac2-889285b70055

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
- posted_at: `2026-11-09T23:44:50.1708730+00:00`

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
  "id": "3d783795-5b62-4c17-aac2-889285b70055",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1708730+00:00"
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
  "subject_id": "ee7553db-edb5-4337-bfc6-041d593db79a",
  "subject_name": "django/db/models/fields/__init__::BigIntegerField",
  "tags": [
    "entity:class"
  ],
  "text": "class BigIntegerField(IntegerField)"
}
```
