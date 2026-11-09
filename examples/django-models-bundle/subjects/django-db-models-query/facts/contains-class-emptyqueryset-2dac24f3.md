# Fact 2dac24f3

Store id: 624c453e-3b0f-4f8e-a0e2-047199956244

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
- posted_at: `2026-11-09T23:44:56.3472900+00:00`

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
  "id": "624c453e-3b0f-4f8e-a0e2-047199956244",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.3472900+00:00"
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
      "target": "b61c174f-638a-4190-afda-c90ec562fde2"
    }
  ],
  "status": "live",
  "subject_id": "a910a8bf-9a53-4a65-820c-a0b6a0775724",
  "subject_name": "django/db/models/query",
  "tags": [
    "entity:class"
  ],
  "text": "contains class EmptyQuerySet"
}
```
