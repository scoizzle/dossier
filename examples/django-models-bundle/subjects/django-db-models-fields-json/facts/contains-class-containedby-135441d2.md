# Fact 135441d2

Store id: 5a65142f-e938-4b9a-91a6-a2adde70e828

## Text

```text
contains class ContainedBy
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
- posted_at: `2026-11-09T23:44:51.0769520+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/fields/json::ContainedBy](../../django-db-models-fields-json-containedby/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":168,"symbol":"ContainedBy"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "5a65142f-e938-4b9a-91a6-a2adde70e828",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.0769520+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 168,
        "symbol": "ContainedBy"
      },
      "rel": "contains",
      "target": "8365e3bd-92b0-4e42-88a0-792b70f8e6b9"
    }
  ],
  "status": "live",
  "subject_id": "fa67266b-c3d1-46c4-89d8-c39e71d018cd",
  "subject_name": "django/db/models/fields/json",
  "tags": [
    "entity:class"
  ],
  "text": "contains class ContainedBy"
}
```
