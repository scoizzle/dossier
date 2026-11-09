# Fact 24dadcc7

Store id: 8a665d28-6301-4f29-9411-e9c96764c907

## Text

```text
contains class RawQuerySet
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
  - target: [django/db/models/query::RawQuerySet](../../django-db-models-query-rawqueryset/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":2410,"symbol":"RawQuerySet"}`

## Referenced by

None.

## Subject

[django/db/models/query](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "8a665d28-6301-4f29-9411-e9c96764c907",
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
        "line": 2410,
        "symbol": "RawQuerySet"
      },
      "rel": "contains",
      "target": "4e95a187-ce10-4a8d-8f7f-e1d40ee73d08"
    }
  ],
  "status": "live",
  "subject_id": "8760e773-b477-4dc2-a0d3-b24b429fa7ec",
  "subject_name": "django/db/models/query",
  "tags": [
    "entity:class"
  ],
  "text": "contains class RawQuerySet"
}
```
