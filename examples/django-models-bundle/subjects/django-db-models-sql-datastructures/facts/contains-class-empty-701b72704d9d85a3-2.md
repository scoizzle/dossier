# Fact 701b72704d9d85a3-2

Store id: 81017156-9cb5-419f-889e-3a30e277ccbc

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
- posted_at: `2026-11-09T23:32:06.5084320+00:00`

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
  "id": "81017156-9cb5-419f-889e-3a30e277ccbc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.5084320+00:00"
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
      "target": "a8f55ad4-8dd5-48db-936f-8e9d93942961"
    }
  ],
  "status": "live",
  "subject_id": "173565d9-788f-4a55-b66f-e71d8d7b1a33",
  "subject_name": "django/db/models/sql/datastructures",
  "tags": [
    "entity:class"
  ],
  "text": "contains class Empty"
}
```
