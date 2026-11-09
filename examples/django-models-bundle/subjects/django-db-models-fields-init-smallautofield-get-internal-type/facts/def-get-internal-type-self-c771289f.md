# Fact c771289f

Store id: 2dda2e16-c8e9-47b3-b81d-46976a9e2f05

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
- posted_at: `2026-11-09T23:44:50.3458740+00:00`

## Data

```json
{
  "end_line": 2981,
  "entity_kind": "method",
  "parent": "SmallAutoField",
  "start_line": 2980,
  "symbol": "SmallAutoField.get_internal_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2980,"selector":"L2980-L2981","symbol":"SmallAutoField.get_internal_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::SmallAutoField.get_internal_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2981,
    "entity_kind": "method",
    "parent": "SmallAutoField",
    "start_line": 2980,
    "symbol": "SmallAutoField.get_internal_type"
  },
  "id": "2dda2e16-c8e9-47b3-b81d-46976a9e2f05",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.3458740+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2980,
        "selector": "L2980-L2981",
        "symbol": "SmallAutoField.get_internal_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "61d77d83-f39b-4040-94a0-cf636b5eff80",
  "subject_name": "django/db/models/fields/__init__::SmallAutoField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
