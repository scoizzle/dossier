# Fact 9eae4409

Store id: 890b6b8b-78c4-41bb-a087-5deeac61fa3d

## Text

```text
contains class GreaterThanOrEqual
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
  - target: [django/db/models/lookups::GreaterThanOrEqual](../../django-db-models-lookups-greaterthanorequal/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":430,"symbol":"GreaterThanOrEqual"}`

## Referenced by

None.

## Subject

[django/db/models/lookups](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "890b6b8b-78c4-41bb-a087-5deeac61fa3d",
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
        "line": 430,
        "symbol": "GreaterThanOrEqual"
      },
      "rel": "contains",
      "target": "a58f8a2c-155a-406e-bf3b-b3c9916d61a2"
    }
  ],
  "status": "live",
  "subject_id": "e7bf7849-709d-446b-ad7a-17abee6ffd25",
  "subject_name": "django/db/models/lookups",
  "tags": [
    "entity:class"
  ],
  "text": "contains class GreaterThanOrEqual"
}
```
