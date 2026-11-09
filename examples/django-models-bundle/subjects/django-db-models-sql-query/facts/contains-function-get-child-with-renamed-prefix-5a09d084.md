# Fact 5a09d084

Store id: f3787cdb-3213-4484-8751-9f373de38349

## Text

```text
contains function get_child_with_renamed_prefix
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
  - target: [django/db/models/sql/query::get_child_with_renamed_prefix](../../django-db-models-sql-query-get-child-with-renamed-prefix/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":105,"symbol":"get_child_with_renamed_prefix"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "f3787cdb-3213-4484-8751-9f373de38349",
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
        "line": 105,
        "symbol": "get_child_with_renamed_prefix"
      },
      "rel": "contains",
      "target": "6d27e888-767d-4b15-a6bd-84aa224328f2"
    }
  ],
  "status": "live",
  "subject_id": "414527cc-92ff-4d99-a78e-04fa25656e92",
  "subject_name": "django/db/models/sql/query",
  "tags": [
    "entity:function"
  ],
  "text": "contains function get_child_with_renamed_prefix"
}
```
