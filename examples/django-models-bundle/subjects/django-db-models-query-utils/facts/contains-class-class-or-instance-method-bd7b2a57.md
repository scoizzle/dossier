# Fact bd7b2a57

Store id: 0f508b33-bbba-4b88-bef5-24bf84452102

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
- posted_at: `2026-11-09T22:39:50.2075540+00:00`

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
  "id": "0f508b33-bbba-4b88-bef5-24bf84452102",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.2075540+00:00"
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
      "target": "6ce4560d-e072-4ea0-a708-f30861597ce5"
    }
  ],
  "status": "live",
  "subject_id": "37abb0c2-46cb-4f07-a1c9-39d94326e8fb",
  "subject_name": "django/db/models/query_utils",
  "tags": [
    "entity:class"
  ],
  "text": "contains class class_or_instance_method"
}
```
