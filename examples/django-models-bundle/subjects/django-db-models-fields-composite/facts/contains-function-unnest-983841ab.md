# Fact 983841ab

Store id: 7b2e4136-3597-491e-b29d-64846b233311

## Text

```text
contains function unnest
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
- posted_at: `2026-11-09T23:44:50.5014100+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/fields/composite::unnest](../../django-db-models-fields-composite-unnest/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":168,"symbol":"unnest"}`

## Referenced by

None.

## Subject

[django/db/models/fields/composite](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "7b2e4136-3597-491e-b29d-64846b233311",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.5014100+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 168,
        "symbol": "unnest"
      },
      "rel": "contains",
      "target": "606122af-e40a-43bc-b488-690901d5adad"
    }
  ],
  "status": "live",
  "subject_id": "b8232277-ea28-4cdf-8d6a-026269c8b135",
  "subject_name": "django/db/models/fields/composite",
  "tags": [
    "entity:function"
  ],
  "text": "contains function unnest"
}
```
