# Fact ddece699

Store id: ee489d19-733a-4fc6-a553-2e4acc51c7e7

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
- posted_at: `2026-11-09T23:44:51.3214910+00:00`

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
  "id": "ee489d19-733a-4fc6-a553-2e4acc51c7e7",
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
    "posted_at": "2026-11-09T23:44:51.3214910+00:00"
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
  "subject_id": "ead50282-31c9-44d9-ba33-8b9ae0878470",
  "subject_name": "django/db/models/fields/proxy::OrderWrt",
  "tags": [
    "entity:class"
  ],
  "text": "class OrderWrt(fields.IntegerField)"
}
```
