# Fact 3b9a14df

Store id: e92ebd6c-b1bb-46e9-bdc5-39537c555a2c

## Text

```text
contains function cursor_iter
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
- posted_at: `2026-11-09T23:44:57.7715820+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/sql/compiler::cursor_iter](../../django-db-models-sql-compiler-cursor-iter/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":2276,"symbol":"cursor_iter"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "e92ebd6c-b1bb-46e9-bdc5-39537c555a2c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:57.7715820+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 2276,
        "symbol": "cursor_iter"
      },
      "rel": "contains",
      "target": "89def0e0-3f76-4740-8f18-9ec9f2c96522"
    }
  ],
  "status": "live",
  "subject_id": "d0d15420-734c-41c7-8915-96b8b2169578",
  "subject_name": "django/db/models/sql/compiler",
  "tags": [
    "entity:function"
  ],
  "text": "contains function cursor_iter"
}
```
