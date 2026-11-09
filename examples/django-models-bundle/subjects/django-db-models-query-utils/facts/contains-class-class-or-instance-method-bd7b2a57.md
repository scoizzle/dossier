# Fact bd7b2a57

Store id: 88ca2f96-402e-40a9-8b48-94480a4be952

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
- posted_at: `2026-11-09T23:44:56.7745430+00:00`

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
  "id": "88ca2f96-402e-40a9-8b48-94480a4be952",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.7745430+00:00"
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
      "target": "8089e49a-52bb-4795-af12-df360a422e77"
    }
  ],
  "status": "live",
  "subject_id": "c4182f55-5c15-42df-8e00-aa953309eedf",
  "subject_name": "django/db/models/query_utils",
  "tags": [
    "entity:class"
  ],
  "text": "contains class class_or_instance_method"
}
```
