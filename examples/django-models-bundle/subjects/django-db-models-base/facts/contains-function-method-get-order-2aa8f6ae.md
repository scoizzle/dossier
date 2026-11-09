# Fact 2aa8f6ae

Store id: 6dbaf6f3-9d3b-4096-9ffc-5a85234d7092

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
- posted_at: `2026-11-09T22:39:40.3699300+00:00`

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
  "id": "6dbaf6f3-9d3b-4096-9ffc-5a85234d7092",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.3699300+00:00"
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
      "target": "dc1a03d3-2fc3-4df1-aacc-15882c372a1d"
    }
  ],
  "status": "live",
  "subject_id": "70b750e6-0b0a-43ce-80a5-3403f95c66e3",
  "subject_name": "django/db/models/base",
  "tags": [
    "entity:function"
  ],
  "text": "contains function method_get_order"
}
```
