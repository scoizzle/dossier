# Fact 9e918f8b

Store id: b2a6d7be-7400-403b-8df9-ba663be39dc9

## Text

```text
contains class QuerySet
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
  - target: [django/db/models/query::QuerySet](../../django-db-models-query-queryset/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":364,"symbol":"QuerySet"}`

## Referenced by

None.

## Subject

[django/db/models/query](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "b2a6d7be-7400-403b-8df9-ba663be39dc9",
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
        "line": 364,
        "symbol": "QuerySet"
      },
      "rel": "contains",
      "target": "2644b5c2-4213-41b2-9f8d-bd393de7978b"
    }
  ],
  "status": "live",
  "subject_id": "8760e773-b477-4dc2-a0d3-b24b429fa7ec",
  "subject_name": "django/db/models/query",
  "tags": [
    "entity:class"
  ],
  "text": "contains class QuerySet"
}
```
