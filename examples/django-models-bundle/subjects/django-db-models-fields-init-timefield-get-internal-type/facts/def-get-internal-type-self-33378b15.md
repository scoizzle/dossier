# Fact 33378b15

Store id: dbe8ef69-4b30-47e1-897e-a6bfec51e89b

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
- posted_at: `2026-11-09T23:44:50.2568030+00:00`

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
  "id": "dbe8ef69-4b30-47e1-897e-a6bfec51e89b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.2568030+00:00"
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
  "subject_id": "164c1478-881b-47ec-8116-c50661927d98",
  "subject_name": "django/db/models/fields/__init__::TimeField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
