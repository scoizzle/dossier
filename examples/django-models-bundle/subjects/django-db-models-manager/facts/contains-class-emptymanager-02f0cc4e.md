# Fact 02f0cc4e

Store id: e9a11387-6448-48fa-a5ea-74baf87a3804

## Text

```text
contains class EmptyManager
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
- posted_at: `2026-11-09T23:32:03.7342610+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/manager::EmptyManager](../../django-db-models-manager-emptymanager/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":207,"symbol":"EmptyManager"}`

## Referenced by

None.

## Subject

[django/db/models/manager](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "e9a11387-6448-48fa-a5ea-74baf87a3804",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.7342610+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 207,
        "symbol": "EmptyManager"
      },
      "rel": "contains",
      "target": "bdecd72c-d0ee-4845-a253-b31ffff78b1c"
    }
  ],
  "status": "live",
  "subject_id": "5e85a5f7-e460-4775-bcc8-e7045c95860f",
  "subject_name": "django/db/models/manager",
  "tags": [
    "entity:class"
  ],
  "text": "contains class EmptyManager"
}
```
