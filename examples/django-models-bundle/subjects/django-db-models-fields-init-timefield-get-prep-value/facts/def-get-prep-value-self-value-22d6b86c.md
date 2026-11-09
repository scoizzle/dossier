# Fact 22d6b86c

Store id: 320a45f1-9233-4735-b586-3eedbe505b29

## Text

```text
def get_prep_value(self, value)
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
- posted_at: `2026-11-09T23:44:50.2617320+00:00`

## Data

```json
{
  "end_line": 2698,
  "entity_kind": "method",
  "parent": "TimeField",
  "start_line": 2696,
  "symbol": "TimeField.get_prep_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2696,"selector":"L2696-L2698","symbol":"TimeField.get_prep_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::TimeField.get_prep_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2698,
    "entity_kind": "method",
    "parent": "TimeField",
    "start_line": 2696,
    "symbol": "TimeField.get_prep_value"
  },
  "id": "320a45f1-9233-4735-b586-3eedbe505b29",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.2617320+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2696,
        "selector": "L2696-L2698",
        "symbol": "TimeField.get_prep_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "4a102f6e-71e7-4a45-88bb-a1be6278559a",
  "subject_name": "django/db/models/fields/__init__::TimeField.get_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_value(self, value)"
}
```
