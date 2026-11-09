# Fact bcac2f0f

Store id: 24a5ed5f-cdf0-4018-b249-bfa679cd78fd

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
- posted_at: `2026-11-09T23:44:50.2133250+00:00`

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
  "id": "24a5ed5f-cdf0-4018-b249-bfa679cd78fd",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.2133250+00:00"
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
  "subject_id": "e5014ba7-6e81-4dbb-a83d-d78cabdd8adc",
  "subject_name": "django/db/models/fields/__init__::PositiveBigIntegerField",
  "tags": [
    "entity:class"
  ],
  "text": "class PositiveBigIntegerField(PositiveIntegerRelDbTypeMixin, BigIntegerField)"
}
```
