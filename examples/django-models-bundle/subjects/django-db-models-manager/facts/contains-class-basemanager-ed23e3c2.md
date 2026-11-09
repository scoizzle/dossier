# Fact ed23e3c2

Store id: 0bd6f5fd-8dbe-49de-963c-0cf1f4d5b062

## Text

```text
contains class BaseManager
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
  - target: [django/db/models/manager::BaseManager](../../django-db-models-manager-basemanager/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":10,"symbol":"BaseManager"}`

## Referenced by

None.

## Subject

[django/db/models/manager](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "0bd6f5fd-8dbe-49de-963c-0cf1f4d5b062",
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
        "line": 10,
        "symbol": "BaseManager"
      },
      "rel": "contains",
      "target": "eec8cf94-8f7e-4c53-a088-afc3b719fa93"
    }
  ],
  "status": "live",
  "subject_id": "5e85a5f7-e460-4775-bcc8-e7045c95860f",
  "subject_name": "django/db/models/manager",
  "tags": [
    "entity:class"
  ],
  "text": "contains class BaseManager"
}
```
