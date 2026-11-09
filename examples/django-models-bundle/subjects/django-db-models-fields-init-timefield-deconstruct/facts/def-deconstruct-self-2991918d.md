# Fact 2991918d

Store id: 2efad5af-8cc7-49d9-a458-008fea51b31d

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
- posted_at: `2026-11-09T23:44:50.2552580+00:00`

## Data

```json
{
  "end_line": 2655,
  "entity_kind": "method",
  "parent": "TimeField",
  "start_line": 2646,
  "symbol": "TimeField.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2646,"selector":"L2646-L2655","symbol":"TimeField.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::TimeField.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2655,
    "entity_kind": "method",
    "parent": "TimeField",
    "start_line": 2646,
    "symbol": "TimeField.deconstruct"
  },
  "id": "2efad5af-8cc7-49d9-a458-008fea51b31d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.2552580+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2646,
        "selector": "L2646-L2655",
        "symbol": "TimeField.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "e9bcadaa-e4e1-442a-81d0-675fc8607843",
  "subject_name": "django/db/models/fields/__init__::TimeField.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
