# Fact f09a816c

Store id: b99cb986-a452-43e0-b449-e8a050345e6c

## Text

```text
contains class AutoField
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
  - target: [django/db/models/fields/__init__::AutoField](../../django-db-models-fields-init-autofield/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":2963,"symbol":"AutoField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "b99cb986-a452-43e0-b449-e8a050345e6c",
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
        "line": 2963,
        "symbol": "AutoField"
      },
      "rel": "contains",
      "target": "0eefb26b-5858-4441-ac8f-6905e4f4c7a2"
    }
  ],
  "status": "live",
  "subject_id": "33b0e427-f796-4783-893b-52c7154949df",
  "subject_name": "django/db/models/fields/__init__",
  "tags": [
    "entity:class"
  ],
  "text": "contains class AutoField"
}
```
