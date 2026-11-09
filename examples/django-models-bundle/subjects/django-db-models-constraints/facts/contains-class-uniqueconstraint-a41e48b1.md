# Fact a41e48b1

Store id: 72da44a2-162d-4b9e-a2f0-b6e722c4f154

## Text

```text
contains class UniqueConstraint
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
- posted_at: `2026-11-09T22:39:40.7335660+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/constraints::UniqueConstraint](../../django-db-models-constraints-uniqueconstraint/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":269,"symbol":"UniqueConstraint"}`

## Referenced by

None.

## Subject

[django/db/models/constraints](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "72da44a2-162d-4b9e-a2f0-b6e722c4f154",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.7335660+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 269,
        "symbol": "UniqueConstraint"
      },
      "rel": "contains",
      "target": "6d07c87a-2b23-416e-9586-82887bee9496"
    }
  ],
  "status": "live",
  "subject_id": "b0b09a84-2c50-431b-bcae-db67e92caf42",
  "subject_name": "django/db/models/constraints",
  "tags": [
    "entity:class"
  ],
  "text": "contains class UniqueConstraint"
}
```
