# Fact 68b8efb4

Store id: 5315012f-812c-4283-b42d-717faab8f0a4

## Text

```text
contains class Manager
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
  - target: [django/db/models/manager::Manager](../../django-db-models-manager-manager/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":176,"symbol":"Manager"}`

## Referenced by

None.

## Subject

[django/db/models/manager](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "5315012f-812c-4283-b42d-717faab8f0a4",
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
        "line": 176,
        "symbol": "Manager"
      },
      "rel": "contains",
      "target": "fdec2446-31cb-4287-9cb2-0d0d76537d56"
    }
  ],
  "status": "live",
  "subject_id": "db0c2f2d-3473-4386-8f36-4d861124f3a4",
  "subject_name": "django/db/models/manager",
  "tags": [
    "entity:class"
  ],
  "text": "contains class Manager"
}
```
