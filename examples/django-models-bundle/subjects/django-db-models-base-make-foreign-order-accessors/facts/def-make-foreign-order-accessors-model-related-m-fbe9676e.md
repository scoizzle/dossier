# Fact fbe9676e

Store id: 1006d066-83c7-4a0a-9e22-eab9c4931f10

## Text

```text
def make_foreign_order_accessors(model, related_model)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:53.7755820+00:00`

## Data

```json
{
  "end_line": 2558,
  "entity_kind": "function",
  "parent": "base",
  "start_line": 2548,
  "symbol": "make_foreign_order_accessors"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2548,"selector":"L2548-L2558","symbol":"make_foreign_order_accessors"}`

## Referenced by

None.

## Subject

[django/db/models/base::make_foreign_order_accessors](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2558,
    "entity_kind": "function",
    "parent": "base",
    "start_line": 2548,
    "symbol": "make_foreign_order_accessors"
  },
  "id": "1006d066-83c7-4a0a-9e22-eab9c4931f10",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7755820+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2548,
        "selector": "L2548-L2558",
        "symbol": "make_foreign_order_accessors"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "76d8360b-0010-4bcd-9c64-acd6eb68cfe7",
  "subject_name": "django/db/models/base::make_foreign_order_accessors",
  "tags": [
    "entity:function"
  ],
  "text": "def make_foreign_order_accessors(model, related_model)"
}
```
