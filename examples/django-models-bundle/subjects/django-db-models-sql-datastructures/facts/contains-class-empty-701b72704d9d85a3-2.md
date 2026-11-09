# Fact 701b72704d9d85a3-2

Store id: f821f041-5c7c-471b-afcb-6f7c66f35595

## Text

```text
contains class Empty
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
- posted_at: `2026-11-09T22:39:51.0344460+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/sql/datastructures::Empty](../../django-db-models-sql-datastructures-empty/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":23,"symbol":"Empty"}`

## Referenced by

None.

## Subject

[django/db/models/sql/datastructures](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "f821f041-5c7c-471b-afcb-6f7c66f35595",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.0344460+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 23,
        "symbol": "Empty"
      },
      "rel": "contains",
      "target": "db5c277c-1eba-469e-ba50-21cc2aaf0591"
    }
  ],
  "status": "live",
  "subject_id": "b1502e27-bc33-4761-a195-6853e0cf262a",
  "subject_name": "django/db/models/sql/datastructures",
  "tags": [
    "entity:class"
  ],
  "text": "contains class Empty"
}
```
