# Fact 68b8efb4

Store id: 9766a943-5c97-435e-9ad3-4388dfaca52c

## Text

```text
contains class Manager
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
- posted_at: `2026-11-09T23:32:03.7342610+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/manager::Manager](../../django-db-models-manager-manager/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":176,"symbol":"Manager"}`

## Referenced by

None.

## Subject

[django/db/models/manager](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "9766a943-5c97-435e-9ad3-4388dfaca52c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.7342610+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 176,
        "symbol": "Manager"
      },
      "rel": "contains",
      "target": "7d9971a0-d774-4be1-b3e6-19765fc0dc84"
    }
  ],
  "status": "live",
  "subject_id": "5e85a5f7-e460-4775-bcc8-e7045c95860f",
  "subject_name": "django/db/models/manager",
  "tags": [
    "entity:class"
  ],
  "text": "contains class Manager"
}
```
