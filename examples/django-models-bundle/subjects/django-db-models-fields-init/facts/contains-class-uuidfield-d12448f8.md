# Fact d12448f8

Store id: 3fe127cb-c4cc-419e-99b3-06e9738d2095

## Text

```text
contains class UUIDField
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
- posted_at: `2026-11-09T23:44:50.3490680+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/fields/__init__::UUIDField](../../django-db-models-fields-init-uuidfield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":2819,"symbol":"UUIDField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "3fe127cb-c4cc-419e-99b3-06e9738d2095",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.3490680+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 2819,
        "symbol": "UUIDField"
      },
      "rel": "contains",
      "target": "935acc5d-4f26-4206-8da5-1cd89b37e211"
    }
  ],
  "status": "live",
  "subject_id": "33b0e427-f796-4783-893b-52c7154949df",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class UUIDField"
}
```
