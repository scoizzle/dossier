# Fact 04d28473

Store id: 7cfad09f-7b68-4752-bb43-759a4b14472b

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
- posted_at: `2026-11-09T23:44:56.7745430+00:00`

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
  "id": "7cfad09f-7b68-4752-bb43-759a4b14472b",
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
        "line": 35,
        "symbol": "subclasses"
      },
      "rel": "contains",
      "target": "42fb977b-7801-49b0-b1da-827977821190"
    }
  ],
  "status": "live",
  "subject_id": "c4182f55-5c15-42df-8e00-aa953309eedf",
  "subject_name": "django/db/models/query_utils",
  "tags": [
    "entity:function"
  ],
  "text": "contains function subclasses"
}
```
