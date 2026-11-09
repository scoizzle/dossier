# Fact 24dadcc7

Store id: 5f666e63-ad53-40eb-919f-374de6414210

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
- posted_at: `2026-11-09T23:44:56.3472900+00:00`

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
  "id": "5f666e63-ad53-40eb-919f-374de6414210",
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
        "line": 2410,
        "symbol": "RawQuerySet"
      },
      "rel": "contains",
      "target": "7d538028-2402-474e-903d-a73cbd5918f4"
    }
  ],
  "status": "live",
  "subject_id": "a910a8bf-9a53-4a65-820c-a0b6a0775724",
  "subject_name": "django/db/models/query",
  "tags": [
    "entity:class"
  ],
  "text": "contains class RawQuerySet"
}
```
