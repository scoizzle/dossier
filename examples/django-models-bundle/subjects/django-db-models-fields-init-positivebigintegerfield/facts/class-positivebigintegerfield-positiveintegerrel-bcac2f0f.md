# Fact bcac2f0f

Store id: 518d1109-7b4e-4c1b-b5be-811de64f49b6

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
- posted_at: `2026-11-09T22:39:42.6041980+00:00`

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
  "id": "518d1109-7b4e-4c1b-b5be-811de64f49b6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.6041980+00:00"
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
  "subject_id": "105ae3bb-e941-47ec-8336-ed933e75f833",
  "subject_name": "django/db/models/fields/__init__::PositiveBigIntegerField",
  "tags": [
    "entity:class"
  ],
  "text": "class PositiveBigIntegerField(PositiveIntegerRelDbTypeMixin, BigIntegerField)"
}
```
