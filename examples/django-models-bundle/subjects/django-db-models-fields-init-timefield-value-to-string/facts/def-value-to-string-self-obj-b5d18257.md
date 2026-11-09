# Fact b5d18257

Store id: 4d0d27e5-f951-40da-b8b1-abd8131d0619

## Text

```text
def value_to_string(self, obj)
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
- posted_at: `2026-11-09T23:31:56.8280800+00:00`

## Data

```json
{
  "end_line": 2708,
  "entity_kind": "method",
  "parent": "TimeField",
  "start_line": 2706,
  "symbol": "TimeField.value_to_string"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2706,"selector":"L2706-L2708","symbol":"TimeField.value_to_string"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::TimeField.value_to_string](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2708,
    "entity_kind": "method",
    "parent": "TimeField",
    "start_line": 2706,
    "symbol": "TimeField.value_to_string"
  },
  "id": "4d0d27e5-f951-40da-b8b1-abd8131d0619",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.8280800+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2706,
        "selector": "L2706-L2708",
        "symbol": "TimeField.value_to_string"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "980a0d82-6b5d-4e25-826d-54d8ee8a6942",
  "subject_name": "django/db/models/fields/__init__::TimeField.value_to_string",
  "tags": [
    "entity:method"
  ],
  "text": "def value_to_string(self, obj)"
}
```
