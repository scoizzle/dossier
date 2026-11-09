# Fact 2e971bfb

Store id: b01d053b-98f6-47d3-8405-e573ce305ca4

## Text

```text
contains function method_set_order
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
  - target: [django/db/models/base::method_set_order](../../django-db-models-base-method-set-order/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":2532,"symbol":"method_set_order"}`

## Referenced by

None.

## Subject

[django/db/models/base](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "b01d053b-98f6-47d3-8405-e573ce305ca4",
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
        "line": 2532,
        "symbol": "method_set_order"
      },
      "rel": "contains",
      "target": "b23c09d5-cae9-42d6-bfc6-cb580d3c9919"
    }
  ],
  "status": "live",
  "subject_id": "adcf7c5a-348e-4481-9bc5-dcdd17eb19d6",
  "subject_name": "django/db/models/base",
  "tags": [
    "entity:function"
  ],
  "text": "contains function method_set_order"
}
```
