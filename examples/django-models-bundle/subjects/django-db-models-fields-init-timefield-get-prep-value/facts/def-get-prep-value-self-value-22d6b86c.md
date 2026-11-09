# Fact 22d6b86c

Store id: 51a4a085-8fe8-4996-a0d5-3d0a3819d759

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
- posted_at: `2026-11-09T23:31:56.8248240+00:00`

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
  "id": "51a4a085-8fe8-4996-a0d5-3d0a3819d759",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.8248240+00:00"
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
  "subject_id": "608346fb-d1aa-444d-b46b-d4cf91b4fb93",
  "subject_name": "django/db/models/fields/__init__::TimeField.get_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_value(self, value)"
}
```
