# Fact c6728866

Store id: 406b3424-2c1f-4eb1-b3fe-264853a3c8e7

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
- posted_at: `2026-11-09T23:44:55.1315130+00:00`

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
  "id": "406b3424-2c1f-4eb1-b3fe-264853a3c8e7",
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
        "line": 445,
        "symbol": "IntegerFieldOverflow"
      },
      "rel": "contains",
      "target": "020a4927-6cb3-4a35-8d0c-dbf131eb1417"
    }
  ],
  "status": "live",
  "subject_id": "08d59620-584d-4fa4-9163-3befcd8a2879",
  "subject_name": "django/db/models/lookups",
  "tags": [
    "entity:class"
  ],
  "text": "contains class IntegerFieldOverflow"
}
```
