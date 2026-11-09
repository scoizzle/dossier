# Fact cbdbb90d

Store id: 50d84e6d-35db-4e0f-84cf-76f0964320ab

## Text

```text
def get_internal_type(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:50.1285890+00:00`

## Data

```json
{
  "end_line": 1954,
  "entity_kind": "method",
  "parent": "DurationField",
  "start_line": 1953,
  "symbol": "DurationField.get_internal_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1953,"selector":"L1953-L1954","symbol":"DurationField.get_internal_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DurationField.get_internal_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1954,
    "entity_kind": "method",
    "parent": "DurationField",
    "start_line": 1953,
    "symbol": "DurationField.get_internal_type"
  },
  "id": "50d84e6d-35db-4e0f-84cf-76f0964320ab",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1285890+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1953,
        "selector": "L1953-L1954",
        "symbol": "DurationField.get_internal_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "b0e300e4-1011-4726-99b8-7617ca162a73",
  "subject_name": "django/db/models/fields/__init__::DurationField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
