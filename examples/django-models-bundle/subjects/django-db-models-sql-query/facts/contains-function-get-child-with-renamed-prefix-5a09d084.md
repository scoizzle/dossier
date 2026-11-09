# Fact 5a09d084

Store id: 87a1f4d5-4792-43c4-9460-796ca733c90a

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
- posted_at: `2026-11-09T23:44:59.0942990+00:00`

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
  "id": "87a1f4d5-4792-43c4-9460-796ca733c90a",
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
        "line": 105,
        "symbol": "get_child_with_renamed_prefix"
      },
      "rel": "contains",
      "target": "4c269dcd-28b5-4922-a433-26e8b41c9389"
    }
  ],
  "status": "live",
  "subject_id": "ba44da72-3cad-4dd7-ae2b-7d1f35aaf915",
  "subject_name": "django/db/models/sql/query",
  "tags": [
    "entity:function"
  ],
  "text": "contains function get_child_with_renamed_prefix"
}
```
