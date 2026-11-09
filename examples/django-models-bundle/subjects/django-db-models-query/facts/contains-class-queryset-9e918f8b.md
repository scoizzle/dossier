# Fact 9e918f8b

Store id: 32618394-adbf-4d6f-a519-a3c41a4a4359

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
- posted_at: `2026-11-09T23:32:04.8716240+00:00`

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
  "id": "32618394-adbf-4d6f-a519-a3c41a4a4359",
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
        "line": 364,
        "symbol": "QuerySet"
      },
      "rel": "contains",
      "target": "b00ad65a-fa33-4333-803d-406a3ed70c02"
    }
  ],
  "status": "live",
  "subject_id": "668f5055-eb85-405a-857a-aabb695bad53",
  "subject_name": "django/db/models/query",
  "tags": [
    "entity:class"
  ],
  "text": "contains class QuerySet"
}
```
