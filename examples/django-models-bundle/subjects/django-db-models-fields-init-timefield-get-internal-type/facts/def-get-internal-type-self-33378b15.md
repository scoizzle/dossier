# Fact 33378b15

Store id: 21a6fe77-72b0-4fc5-836c-ba2780e3a82e

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
- posted_at: `2026-11-09T22:39:42.6633780+00:00`

## Data

```json
{
  "end_line": 2658,
  "entity_kind": "method",
  "parent": "TimeField",
  "start_line": 2657,
  "symbol": "TimeField.get_internal_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2657,"selector":"L2657-L2658","symbol":"TimeField.get_internal_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::TimeField.get_internal_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2658,
    "entity_kind": "method",
    "parent": "TimeField",
    "start_line": 2657,
    "symbol": "TimeField.get_internal_type"
  },
  "id": "21a6fe77-72b0-4fc5-836c-ba2780e3a82e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.6633780+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2657,
        "selector": "L2657-L2658",
        "symbol": "TimeField.get_internal_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "6c002d91-6835-45e3-95df-34510647343b",
  "subject_name": "django/db/models/fields/__init__::TimeField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
