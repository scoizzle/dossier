# Fact 944a100e

Store id: 19dae6f8-0541-4d24-af5c-bc1f06ae2e1c

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
- posted_at: `2026-11-09T22:39:42.7617160+00:00`

## Data

```json
{
  "end_line": 2973,
  "entity_kind": "method",
  "parent": "BigAutoField",
  "start_line": 2972,
  "symbol": "BigAutoField.get_internal_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2972,"selector":"L2972-L2973","symbol":"BigAutoField.get_internal_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::BigAutoField.get_internal_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2973,
    "entity_kind": "method",
    "parent": "BigAutoField",
    "start_line": 2972,
    "symbol": "BigAutoField.get_internal_type"
  },
  "id": "19dae6f8-0541-4d24-af5c-bc1f06ae2e1c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.7617160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2972,
        "selector": "L2972-L2973",
        "symbol": "BigAutoField.get_internal_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "4364c37b-c298-46c1-a36f-806b9d7af50e",
  "subject_name": "django/db/models/fields/__init__::BigAutoField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
