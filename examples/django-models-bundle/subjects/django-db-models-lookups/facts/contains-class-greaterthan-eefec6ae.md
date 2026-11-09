# Fact eefec6ae

Store id: b02852bb-ae51-4e0f-9d82-b503e90276f5

## Text

```text
contains class GreaterThan
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
- posted_at: `2026-11-09T22:39:48.3048640+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/lookups::GreaterThan](../../django-db-models-lookups-greaterthan/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":425,"symbol":"GreaterThan"}`

## Referenced by

None.

## Subject

[django/db/models/lookups](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "b02852bb-ae51-4e0f-9d82-b503e90276f5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.3048640+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 425,
        "symbol": "GreaterThan"
      },
      "rel": "contains",
      "target": "da7f3222-99c6-4593-926d-12af3a5244e4"
    }
  ],
  "status": "live",
  "subject_id": "8a4b2e84-bc75-4dfe-afa5-aa8af215b8c6",
  "subject_name": "django/db/models/lookups",
  "tags": [
    "entity:class"
  ],
  "text": "contains class GreaterThan"
}
```
