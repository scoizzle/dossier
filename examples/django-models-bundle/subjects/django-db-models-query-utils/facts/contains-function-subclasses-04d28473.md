# Fact 04d28473

Store id: ff367463-6629-43bb-840c-933935ca0958

## Text

```text
contains function subclasses
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
- posted_at: `2026-11-09T23:32:05.2268070+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/query_utils::subclasses](../../django-db-models-query-utils-subclasses/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":35,"symbol":"subclasses"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "ff367463-6629-43bb-840c-933935ca0958",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.2268070+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 35,
        "symbol": "subclasses"
      },
      "rel": "contains",
      "target": "cc6fbe6b-1af0-4f95-b273-5f0fbc37b665"
    }
  ],
  "status": "live",
  "subject_id": "c693c97c-c89e-4768-9017-bc6868b175fc",
  "subject_name": "django/db/models/query_utils",
  "tags": [
    "entity:function"
  ],
  "text": "contains function subclasses"
}
```
