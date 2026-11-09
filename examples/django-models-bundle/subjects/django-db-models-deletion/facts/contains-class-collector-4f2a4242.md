# Fact 4f2a4242

Store id: 83f305b8-6324-4119-b04e-f69ca0502093

## Text

```text
contains class Collector
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
- posted_at: `2026-11-09T22:39:41.0946700+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/deletion::Collector](../../django-db-models-deletion-collector/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":117,"symbol":"Collector"}`

## Referenced by

None.

## Subject

[django/db/models/deletion](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "83f305b8-6324-4119-b04e-f69ca0502093",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.0946700+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 117,
        "symbol": "Collector"
      },
      "rel": "contains",
      "target": "df8b024f-7f5b-4027-927a-e1b65da670f6"
    }
  ],
  "status": "live",
  "subject_id": "9dd01ff9-dc4a-434f-bc10-89b57d3d6bb3",
  "subject_name": "django/db/models/deletion",
  "tags": [
    "entity:class"
  ],
  "text": "contains class Collector"
}
```
