# Fact 02f0cc4e

Store id: 845b2f3f-9c28-4507-b843-c05f3fbad986

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
- posted_at: `2026-11-09T22:39:48.5586340+00:00`

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
  "id": "845b2f3f-9c28-4507-b843-c05f3fbad986",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.5586340+00:00"
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
      "target": "7cbbc2fa-e7b1-4e01-9800-9001b2de69aa"
    }
  ],
  "status": "live",
  "subject_id": "db0c2f2d-3473-4386-8f36-4d861124f3a4",
  "subject_name": "django/db/models/manager",
  "tags": [
    "entity:class"
  ],
  "text": "contains class EmptyManager"
}
```
