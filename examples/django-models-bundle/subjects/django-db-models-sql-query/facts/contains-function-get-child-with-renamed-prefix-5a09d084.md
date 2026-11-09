# Fact 5a09d084

Store id: 701b16e4-4ade-43ce-8d04-a04a1963ccf4

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
- posted_at: `2026-11-09T23:32:07.1866820+00:00`

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
  "id": "701b16e4-4ade-43ce-8d04-a04a1963ccf4",
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
        "line": 105,
        "symbol": "get_child_with_renamed_prefix"
      },
      "rel": "contains",
      "target": "844225ec-6ae1-44c1-a507-3e47b204b4d5"
    }
  ],
  "status": "live",
  "subject_id": "896c3d29-801c-41be-9558-1f478fdb752d",
  "subject_name": "django/db/models/sql/query",
  "tags": [
    "entity:function"
  ],
  "text": "contains function get_child_with_renamed_prefix"
}
```
