# Fact 78e41354

Store id: 9057bb8b-9899-4467-81bc-5b0f71178161

## Text

```text
contains function prefetch_one_level
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
- posted_at: `2026-11-09T23:44:56.3472900+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/query::prefetch_one_level](../../django-db-models-query-prefetch-one-level/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":2874,"symbol":"prefetch_one_level"}`

## Referenced by

None.

## Subject

[django/db/models/query](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "9057bb8b-9899-4467-81bc-5b0f71178161",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.3472900+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 2874,
        "symbol": "prefetch_one_level"
      },
      "rel": "contains",
      "target": "413d8873-f950-4a57-9950-ca167e1ce47b"
    }
  ],
  "status": "live",
  "subject_id": "a910a8bf-9a53-4a65-820c-a0b6a0775724",
  "subject_name": "django/db/models/query",
  "tags": [
    "entity:function"
  ],
  "text": "contains function prefetch_one_level"
}
```
