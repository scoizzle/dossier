# Fact d83cddfc

Store id: 1a71d2d6-f9a5-4bdb-ab91-da6342925a25

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
- posted_at: `2026-11-09T23:44:48.5582640+00:00`

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
  "id": "1a71d2d6-f9a5-4bdb-ab91-da6342925a25",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.5582640+00:00"
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
      "target": "9340da12-636e-432e-a41a-f8a7e88df16e"
    }
  ],
  "status": "live",
  "subject_id": "adcf7c5a-348e-4481-9bc5-dcdd17eb19d6",
  "subject_name": "django/db/models/base",
  "tags": [
    "entity:function"
  ],
  "text": "contains function subclass_exception"
}
```
