# Fact 80262b08

Store id: f95305fe-7f1d-4230-9118-120e51bad59a

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
- posted_at: `2026-11-09T22:39:42.7152430+00:00`

## Data

```json
{
  "end_line": 2840,
  "entity_kind": "method",
  "parent": "UUIDField",
  "start_line": 2838,
  "symbol": "UUIDField.get_prep_value"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2838,"selector":"L2838-L2840","symbol":"UUIDField.get_prep_value"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::UUIDField.get_prep_value](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2840,
    "entity_kind": "method",
    "parent": "UUIDField",
    "start_line": 2838,
    "symbol": "UUIDField.get_prep_value"
  },
  "id": "f95305fe-7f1d-4230-9118-120e51bad59a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.7152430+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2838,
        "selector": "L2838-L2840",
        "symbol": "UUIDField.get_prep_value"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "4742206c-0009-4e16-bed8-f8c59d9c43e1",
  "subject_name": "django/db/models/fields/__init__::UUIDField.get_prep_value",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_value(self, value)"
}
```
