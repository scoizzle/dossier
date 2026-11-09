# Fact a26d747b

Store id: 6a05b069-257f-4653-b038-7971a6cb6b66

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
- posted_at: `2026-11-09T23:32:07.1866820+00:00`

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
  "id": "6a05b069-257f-4653-b038-7971a6cb6b66",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.1866820+00:00"
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
      "target": "9b68c60a-5243-46f6-84e5-1c303ed401b7"
    }
  ],
  "status": "live",
  "subject_id": "896c3d29-801c-41be-9558-1f478fdb752d",
  "subject_name": "django/db/models/sql/query",
  "tags": [
    "entity:function"
  ],
  "text": "contains function get_order_dir"
}
```
