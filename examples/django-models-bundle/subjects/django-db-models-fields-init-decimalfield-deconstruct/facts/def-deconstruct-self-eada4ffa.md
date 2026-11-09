# Fact eada4ffa

Store id: a7bd9e40-f9b4-4f34-9812-a29f53d438c2

## Text

```text
def deconstruct(self)
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
- posted_at: `2026-11-09T23:44:50.1198660+00:00`

## Data

```json
{
  "end_line": 1888,
  "entity_kind": "method",
  "parent": "DecimalField",
  "start_line": 1882,
  "symbol": "DecimalField.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1882,"selector":"L1882-L1888","symbol":"DecimalField.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DecimalField.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1888,
    "entity_kind": "method",
    "parent": "DecimalField",
    "start_line": 1882,
    "symbol": "DecimalField.deconstruct"
  },
  "id": "a7bd9e40-f9b4-4f34-9812-a29f53d438c2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1198660+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1882,
        "selector": "L1882-L1888",
        "symbol": "DecimalField.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "ac6e80e8-5f4d-4f5d-85e1-0dae9353c8b8",
  "subject_name": "django/db/models/fields/__init__::DecimalField.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
