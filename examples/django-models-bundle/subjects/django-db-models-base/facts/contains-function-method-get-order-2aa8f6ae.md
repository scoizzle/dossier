# Fact 2aa8f6ae

Store id: 6ffd04d3-eec4-45e2-bcf7-7de70efda98e

## Text

```text
contains function method_get_order
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
- posted_at: `2026-11-09T23:44:48.5582640+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/base::method_get_order](../../django-db-models-base-method-get-order/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":2541,"symbol":"method_get_order"}`

## Referenced by

None.

## Subject

[django/db/models/base](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "6ffd04d3-eec4-45e2-bcf7-7de70efda98e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5582640+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 2541,
        "symbol": "method_get_order"
      },
      "rel": "contains",
      "target": "0e6d830f-951e-4e98-9bf2-50cff895d4fb"
    }
  ],
  "status": "live",
  "subject_id": "adcf7c5a-348e-4481-9bc5-dcdd17eb19d6",
  "subject_name": "django/db/models/base",
  "tags": [
    "entity:function"
  ],
  "text": "contains function method_get_order"
}
```
