# Fact 02f0cc4e

Store id: 9296233b-aaae-481e-9089-25c786fc099d

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
- posted_at: `2026-11-09T23:44:55.3295960+00:00`

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
  "id": "9296233b-aaae-481e-9089-25c786fc099d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.3295960+00:00"
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
      "target": "df1eb2b8-86f5-41e6-a6b6-2965ced2e6ee"
    }
  ],
  "status": "live",
  "subject_id": "dc0aeb12-8c7a-413b-aab2-e5de5c51b999",
  "subject_name": "django/db/models/manager",
  "tags": [
    "entity:class"
  ],
  "text": "contains class EmptyManager"
}
```
