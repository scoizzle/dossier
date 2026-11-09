# Fact 24dadcc7

Store id: 8017b60f-08ab-419d-b573-23ccf715151d

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
- posted_at: `2026-11-09T23:32:04.8716240+00:00`

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
  "id": "8017b60f-08ab-419d-b573-23ccf715151d",
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
        "line": 2410,
        "symbol": "RawQuerySet"
      },
      "rel": "contains",
      "target": "d50e49db-87da-4fa4-b3e7-3a5120ac63dc"
    }
  ],
  "status": "live",
  "subject_id": "668f5055-eb85-405a-857a-aabb695bad53",
  "subject_name": "django/db/models/query",
  "tags": [
    "entity:class"
  ],
  "text": "contains class RawQuerySet"
}
```
