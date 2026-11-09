# Fact eefec6ae

Store id: 4fbc8f92-2f96-494a-af23-d06ef04d6f41

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
- posted_at: `2026-11-09T23:44:55.1315130+00:00`

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
  "id": "4fbc8f92-2f96-494a-af23-d06ef04d6f41",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.1315130+00:00"
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
      "target": "64c6fcaf-b9e1-41b5-8883-d48d61f422c0"
    }
  ],
  "status": "live",
  "subject_id": "08d59620-584d-4fa4-9163-3befcd8a2879",
  "subject_name": "django/db/models/lookups",
  "tags": [
    "entity:class"
  ],
  "text": "contains class GreaterThan"
}
```
