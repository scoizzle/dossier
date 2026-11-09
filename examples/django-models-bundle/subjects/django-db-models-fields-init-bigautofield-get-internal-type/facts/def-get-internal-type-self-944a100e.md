# Fact 944a100e

Store id: 7edeb973-55d2-4ed7-b4fa-4681ebed3839

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
- posted_at: `2026-11-09T23:31:56.9270750+00:00`

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
  "id": "7edeb973-55d2-4ed7-b4fa-4681ebed3839",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.9270750+00:00"
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
  "subject_id": "37954cd6-a539-470f-8d6d-51381977572c",
  "subject_name": "django/db/models/fields/__init__::BigAutoField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
