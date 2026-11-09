# Fact 2dac24f3

Store id: 220c5398-850d-48c0-bf85-d20e37749ad4

## Text

```text
contains class EmptyQuerySet
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
- posted_at: `2026-11-09T23:32:04.8716240+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/query::EmptyQuerySet](../../django-db-models-query-emptyqueryset/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":2400,"symbol":"EmptyQuerySet"}`

## Referenced by

None.

## Subject

[django/db/models/query](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "220c5398-850d-48c0-bf85-d20e37749ad4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.8716240+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 2400,
        "symbol": "EmptyQuerySet"
      },
      "rel": "contains",
      "target": "a7a5e963-fe31-4d35-9f2e-0f6f819923bf"
    }
  ],
  "status": "live",
  "subject_id": "668f5055-eb85-405a-857a-aabb695bad53",
  "subject_name": "django/db/models/query",
  "tags": [
    "entity:class"
  ],
  "text": "contains class EmptyQuerySet"
}
```
