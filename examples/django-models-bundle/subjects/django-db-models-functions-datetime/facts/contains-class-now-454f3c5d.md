# Fact 454f3c5d

Store id: 7865245c-d4c4-4b62-b639-e0ca988d6308

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
- posted_at: `2026-11-09T22:39:46.2219070+00:00`

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
  "id": "7865245c-d4c4-4b62-b639-e0ca988d6308",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.2219070+00:00"
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
      "target": "79e1cae9-64cd-48c6-b9ab-8872936995c9"
    }
  ],
  "status": "live",
  "subject_id": "6590f65d-0701-441c-adae-1cea47b0b755",
  "subject_name": "django/db/models/functions/datetime",
  "tags": [
    "entity:class"
  ],
  "text": "contains class Now"
}
```
