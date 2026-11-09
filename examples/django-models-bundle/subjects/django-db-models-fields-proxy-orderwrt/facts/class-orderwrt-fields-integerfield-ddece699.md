# Fact ddece699

Store id: 30af5381-9e29-4d31-a978-3195de6c8c2b

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
- posted_at: `2026-11-09T23:31:58.4082470+00:00`

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
  "id": "30af5381-9e29-4d31-a978-3195de6c8c2b",
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
    "posted_at": "2026-11-09T23:31:58.4082470+00:00"
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
  "subject_id": "8ca693d8-6edd-4a39-a800-a5a03b1a32d3",
  "subject_name": "django/db/models/fields/proxy::OrderWrt",
  "tags": [
    "entity:class"
  ],
  "text": "class OrderWrt(fields.IntegerField)"
}
```
