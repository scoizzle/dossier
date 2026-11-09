# Fact 454f3c5d

Store id: c61f3995-bbe6-4e8a-839d-ea54c4345966

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
- posted_at: `2026-11-09T23:32:01.3094010+00:00`

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
  "id": "c61f3995-bbe6-4e8a-839d-ea54c4345966",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.3094010+00:00"
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
      "target": "151d7bcc-3141-4539-87b6-821274cafde6"
    }
  ],
  "status": "live",
  "subject_id": "f1548d19-5365-487c-8902-8045f2b05c2e",
  "subject_name": "django/db/models/functions/datetime",
  "tags": [
    "entity:class"
  ],
  "text": "contains class Now"
}
```
