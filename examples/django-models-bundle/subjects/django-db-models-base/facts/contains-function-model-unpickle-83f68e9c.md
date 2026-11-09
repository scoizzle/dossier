# Fact 83f68e9c

Store id: 4e2e2166-a934-4693-8438-b87e861a2ba8

## Text

```text
contains function model_unpickle
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
- posted_at: `2026-11-09T23:31:53.7768270+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/base::model_unpickle](../../django-db-models-base-model-unpickle/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":2566,"symbol":"model_unpickle"}`

## Referenced by

None.

## Subject

[django/db/models/base](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "4e2e2166-a934-4693-8438-b87e861a2ba8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7768270+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 2566,
        "symbol": "model_unpickle"
      },
      "rel": "contains",
      "target": "eaa023bd-9df3-481e-a8f3-b764b1520937"
    }
  ],
  "status": "live",
  "subject_id": "48784eff-2794-4b93-9cfc-4ff4781fa45d",
  "subject_name": "django/db/models/base",
  "tags": [
    "entity:function"
  ],
  "text": "contains function model_unpickle"
}
```
