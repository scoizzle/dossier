# Fact 9e918f8b

Store id: eeb547a2-d900-4ca4-8a7f-abe700a8cc36

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
- posted_at: `2026-11-09T23:44:56.3472900+00:00`

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
  "id": "eeb547a2-d900-4ca4-8a7f-abe700a8cc36",
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
        "line": 364,
        "symbol": "QuerySet"
      },
      "rel": "contains",
      "target": "9beca53b-c46e-4232-b4f9-77ae2cc445a4"
    }
  ],
  "status": "live",
  "subject_id": "a910a8bf-9a53-4a65-820c-a0b6a0775724",
  "subject_name": "django/db/models/query",
  "tags": [
    "entity:class"
  ],
  "text": "contains class QuerySet"
}
```
