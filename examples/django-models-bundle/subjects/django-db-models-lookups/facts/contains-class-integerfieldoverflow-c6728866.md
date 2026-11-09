# Fact c6728866

Store id: 07d64903-3147-486d-9ccc-0700967a13a4

## Text

```text
contains class IntegerFieldOverflow
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
  - target: [django/db/models/lookups::IntegerFieldOverflow](../../django-db-models-lookups-integerfieldoverflow/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":445,"symbol":"IntegerFieldOverflow"}`

## Referenced by

None.

## Subject

[django/db/models/lookups](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "07d64903-3147-486d-9ccc-0700967a13a4",
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
        "line": 445,
        "symbol": "IntegerFieldOverflow"
      },
      "rel": "contains",
      "target": "e70211a8-51b7-4c58-8ce1-f17708cbf10d"
    }
  ],
  "status": "live",
  "subject_id": "8a4b2e84-bc75-4dfe-afa5-aa8af215b8c6",
  "subject_name": "django/db/models/lookups",
  "tags": [
    "entity:class"
  ],
  "text": "contains class IntegerFieldOverflow"
}
```
