# Fact 449677c8

Store id: a4d55550-9b5a-4282-b736-f6ea501d4784

## Text

```text
contains class ManagerDescriptor
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
  - target: [django/db/models/manager::ManagerDescriptor](../../django-db-models-manager-managerdescriptor/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":180,"symbol":"ManagerDescriptor"}`

## Referenced by

None.

## Subject

[django/db/models/manager](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "a4d55550-9b5a-4282-b736-f6ea501d4784",
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
        "line": 180,
        "symbol": "ManagerDescriptor"
      },
      "rel": "contains",
      "target": "f8e8f773-e646-4ed8-a269-4b91a36f753c"
    }
  ],
  "status": "live",
  "subject_id": "db0c2f2d-3473-4386-8f36-4d861124f3a4",
  "subject_name": "django/db/models/manager",
  "tags": [
    "entity:class"
  ],
  "text": "contains class ManagerDescriptor"
}
```
