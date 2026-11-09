# Fact 2aa8f6ae

Store id: bc20d9af-7516-42f8-a44e-92bae7824556

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
- posted_at: `2026-11-09T23:31:53.7768270+00:00`

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
  "id": "bc20d9af-7516-42f8-a44e-92bae7824556",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7768270+00:00"
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
      "target": "42a1ffd9-abf6-4402-b327-5d451afd17e7"
    }
  ],
  "status": "live",
  "subject_id": "48784eff-2794-4b93-9cfc-4ff4781fa45d",
  "subject_name": "django/db/models/base",
  "tags": [
    "entity:function"
  ],
  "text": "contains function method_get_order"
}
```
