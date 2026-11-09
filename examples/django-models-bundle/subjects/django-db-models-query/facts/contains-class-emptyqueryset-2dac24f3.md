# Fact 2dac24f3

Store id: bfabfc11-6d9c-4a24-baa7-a73b3182fa47

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
- posted_at: `2026-11-09T22:39:49.9155620+00:00`

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
  "id": "bfabfc11-6d9c-4a24-baa7-a73b3182fa47",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.9155620+00:00"
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
      "target": "9184f5a0-d0f2-4f9f-8274-7b08643a55a8"
    }
  ],
  "status": "live",
  "subject_id": "8760e773-b477-4dc2-a0d3-b24b429fa7ec",
  "subject_name": "django/db/models/query",
  "tags": [
    "entity:class"
  ],
  "text": "contains class EmptyQuerySet"
}
```
