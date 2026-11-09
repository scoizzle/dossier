# Fact c6728866

Store id: 039f8a3e-c658-4dff-9f72-1572ef23f2e0

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
- posted_at: `2026-11-09T23:32:03.5009330+00:00`

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
  "id": "039f8a3e-c658-4dff-9f72-1572ef23f2e0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.5009330+00:00"
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
      "target": "7ba007af-5293-403f-85a6-44962dbb84e1"
    }
  ],
  "status": "live",
  "subject_id": "e7bf7849-709d-446b-ad7a-17abee6ffd25",
  "subject_name": "django/db/models/lookups",
  "tags": [
    "entity:class"
  ],
  "text": "contains class IntegerFieldOverflow"
}
```
