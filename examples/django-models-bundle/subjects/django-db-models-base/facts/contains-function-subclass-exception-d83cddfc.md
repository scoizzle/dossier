# Fact d83cddfc

Store id: 3a1908ea-be2b-4710-a71c-107a1cbcafa2

## Text

```text
contains function subclass_exception
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:53.7768270+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/base::subclass_exception](../../django-db-models-base-subclass-exception/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":72,"symbol":"subclass_exception"}`

## Referenced by

None.

## Subject

[django/db/models/base](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "3a1908ea-be2b-4710-a71c-107a1cbcafa2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7768270+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 72,
        "symbol": "subclass_exception"
      },
      "rel": "contains",
      "target": "d57bf993-aac2-40fd-a059-d70983e50fc7"
    }
  ],
  "status": "live",
  "subject_id": "48784eff-2794-4b93-9cfc-4ff4781fa45d",
  "subject_name": "django/db/models/base",
  "tags": [
    "entity:function"
  ],
  "text": "contains function subclass_exception"
}
```
