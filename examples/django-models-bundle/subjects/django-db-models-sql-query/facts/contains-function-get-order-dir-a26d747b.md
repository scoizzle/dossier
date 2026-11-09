# Fact a26d747b

Store id: 834e14e4-66af-4431-9b96-d129cec0f97c

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
- posted_at: `2026-11-09T23:44:59.0942990+00:00`

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
  "id": "834e14e4-66af-4431-9b96-d129cec0f97c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:59.0942990+00:00"
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
      "target": "d5703cb8-6992-45c9-9764-8ce0758c79fe"
    }
  ],
  "status": "live",
  "subject_id": "ba44da72-3cad-4dd7-ae2b-7d1f35aaf915",
  "subject_name": "django/db/models/sql/query",
  "tags": [
    "entity:function"
  ],
  "text": "contains function get_order_dir"
}
```
