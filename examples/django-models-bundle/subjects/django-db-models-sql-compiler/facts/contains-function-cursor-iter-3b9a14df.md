# Fact 3b9a14df

Store id: 141ab5cc-99a1-48bd-a497-7baf6eb561c4

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
- posted_at: `2026-11-09T23:32:06.1168670+00:00`

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
  "id": "141ab5cc-99a1-48bd-a497-7baf6eb561c4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.1168670+00:00"
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
      "target": "1fd19681-3402-44b7-b123-c8ec1090187c"
    }
  ],
  "status": "live",
  "subject_id": "eec456aa-334a-4312-a193-ed044257811d",
  "subject_name": "django/db/models/sql/compiler",
  "tags": [
    "entity:function"
  ],
  "text": "contains function cursor_iter"
}
```
