# Fact 454f3c5d

Store id: 6256c3d1-931e-46c9-8352-38417c451c05

## Text

```text
contains class Now
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
- posted_at: `2026-11-09T23:44:53.4202890+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/functions/datetime::Now](../../django-db-models-functions-datetime-now/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":213,"symbol":"Now"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "6256c3d1-931e-46c9-8352-38417c451c05",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.4202890+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 213,
        "symbol": "Now"
      },
      "rel": "contains",
      "target": "2f1c6477-f9a5-4104-83b7-be6df88bc5a3"
    }
  ],
  "status": "live",
  "subject_id": "5ba59e7e-9eff-4cf9-9a39-0dbc240be1ad",
  "subject_name": "django/db/models/functions/datetime",
  "tags": [
    "entity:class"
  ],
  "text": "contains class Now"
}
```
