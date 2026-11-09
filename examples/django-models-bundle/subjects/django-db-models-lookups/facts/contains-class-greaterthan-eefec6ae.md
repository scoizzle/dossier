# Fact eefec6ae

Store id: 4a58555f-9c97-4247-a056-7da8d021e733

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
- posted_at: `2026-11-09T23:32:03.5009330+00:00`

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
  "id": "4a58555f-9c97-4247-a056-7da8d021e733",
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
        "line": 425,
        "symbol": "GreaterThan"
      },
      "rel": "contains",
      "target": "d0f6990b-ec66-478b-ab71-a75afeafb677"
    }
  ],
  "status": "live",
  "subject_id": "e7bf7849-709d-446b-ad7a-17abee6ffd25",
  "subject_name": "django/db/models/lookups",
  "tags": [
    "entity:class"
  ],
  "text": "contains class GreaterThan"
}
```
