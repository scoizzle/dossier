# Fact bcac2f0f

Store id: 6448fb4b-6dfc-4d53-91c1-fc5841304bdb

## Text

```text
class PositiveBigIntegerField(PositiveIntegerRelDbTypeMixin, BigIntegerField)
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
- posted_at: `2026-11-09T23:31:56.7663300+00:00`

## Data

```json
{
  "end_line": 2454,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 2442,
  "symbol": "PositiveBigIntegerField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2442,"selector":"L2442-L2454","symbol":"PositiveBigIntegerField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::PositiveBigIntegerField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2454,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 2442,
    "symbol": "PositiveBigIntegerField"
  },
  "id": "6448fb4b-6dfc-4d53-91c1-fc5841304bdb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.7663300+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2442,
        "selector": "L2442-L2454",
        "symbol": "PositiveBigIntegerField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "87a7f915-4880-439b-a37f-a4580047d00c",
  "subject_name": "django/db/models/fields/__init__::PositiveBigIntegerField",
  "tags": [
    "entity:class"
  ],
  "text": "class PositiveBigIntegerField(PositiveIntegerRelDbTypeMixin, BigIntegerField)"
}
```
