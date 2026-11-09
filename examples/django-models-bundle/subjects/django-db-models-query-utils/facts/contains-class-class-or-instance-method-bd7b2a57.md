# Fact bd7b2a57

Store id: 5b100570-01f7-4e07-a977-4178f4e42462

## Text

```text
contains class class_or_instance_method
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
- posted_at: `2026-11-09T23:32:05.2268070+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/query_utils::class_or_instance_method](../../django-db-models-query-utils-class-or-instance-method/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":320,"symbol":"class_or_instance_method"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "5b100570-01f7-4e07-a977-4178f4e42462",
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
        "line": 320,
        "symbol": "class_or_instance_method"
      },
      "rel": "contains",
      "target": "34b28c00-b0ac-4dfa-8424-56b99d2c5b71"
    }
  ],
  "status": "live",
  "subject_id": "c693c97c-c89e-4768-9017-bc6868b175fc",
  "subject_name": "django/db/models/query_utils",
  "tags": [
    "entity:class"
  ],
  "text": "contains class class_or_instance_method"
}
```
