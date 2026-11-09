# Fact 04d28473

Store id: 26d10070-7645-4dad-b5bd-db3435bae5ac

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
- posted_at: `2026-11-09T22:39:50.2075540+00:00`

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
  "id": "26d10070-7645-4dad-b5bd-db3435bae5ac",
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
        "line": 35,
        "symbol": "subclasses"
      },
      "rel": "contains",
      "target": "923966b2-be18-4b6e-af6a-d0e74d7072e1"
    }
  ],
  "status": "live",
  "subject_id": "37abb0c2-46cb-4f07-a1c9-39d94326e8fb",
  "subject_name": "django/db/models/query_utils",
  "tags": [
    "entity:function"
  ],
  "text": "contains function subclasses"
}
```
