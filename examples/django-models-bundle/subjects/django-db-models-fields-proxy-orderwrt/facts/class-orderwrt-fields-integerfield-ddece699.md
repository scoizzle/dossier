# Fact ddece699

Store id: 0d7cdd2c-763b-4e0d-9027-fcd91ac102eb

## Text

```text
class OrderWrt(fields.IntegerField)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:44.0692850+00:00`

## Data

```json
{
  "end_line": 18,
  "entity_kind": "class",
  "parent": "proxy",
  "start_line": 9,
  "symbol": "OrderWrt"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/proxy.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":9,"selector":"L9-L18","symbol":"OrderWrt"}`

## Items

```json
[
  {
    "text": "A proxy for the _order database field that is used when Meta.order_with_respect_to is specified.",
    "locator": {
      "line": 10
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/proxy::OrderWrt](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 18,
    "entity_kind": "class",
    "parent": "proxy",
    "start_line": 9,
    "symbol": "OrderWrt"
  },
  "id": "0d7cdd2c-763b-4e0d-9027-fcd91ac102eb",
  "items": [
    {
      "locator": {
        "line": 10
      },
      "text": "A proxy for the _order database field that is used when Meta.order_with_respect_to is specified."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.0692850+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 9,
        "selector": "L9-L18",
        "symbol": "OrderWrt"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/proxy.py"
    }
  ],
  "status": "live",
  "subject_id": "fd67010c-c9b1-4995-bcb4-87d0031f9e1b",
  "subject_name": "django/db/models/fields/proxy::OrderWrt",
  "tags": [
    "entity:class"
  ],
  "text": "class OrderWrt(fields.IntegerField)"
}
```
