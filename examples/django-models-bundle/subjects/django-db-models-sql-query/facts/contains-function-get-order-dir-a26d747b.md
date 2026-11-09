# Fact a26d747b

Store id: a8da09c3-f2d7-493e-9d09-afcad9186021

## Text

```text
contains function get_order_dir
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
- posted_at: `2026-11-09T22:39:51.5840140+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/sql/query::get_order_dir](../../django-db-models-sql-query-get-order-dir/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":2794,"symbol":"get_order_dir"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "a8da09c3-f2d7-493e-9d09-afcad9186021",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.5840140+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 2794,
        "symbol": "get_order_dir"
      },
      "rel": "contains",
      "target": "d2030d13-b37a-4ce7-bae8-29f656c4ecfd"
    }
  ],
  "status": "live",
  "subject_id": "414527cc-92ff-4d99-a78e-04fa25656e92",
  "subject_name": "django/db/models/sql/query",
  "tags": [
    "entity:function"
  ],
  "text": "contains function get_order_dir"
}
```
