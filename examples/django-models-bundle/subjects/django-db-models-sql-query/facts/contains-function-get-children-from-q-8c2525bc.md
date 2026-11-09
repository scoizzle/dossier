# Fact 8c2525bc

Store id: 40082dd2-612a-42d0-88ce-a487bb8beb41

## Text

```text
contains function get_children_from_q
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
  - target: [django/db/models/sql/query::get_children_from_q](../../django-db-models-sql-query-get-children-from-q/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":92,"symbol":"get_children_from_q"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "40082dd2-612a-42d0-88ce-a487bb8beb41",
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
        "line": 92,
        "symbol": "get_children_from_q"
      },
      "rel": "contains",
      "target": "38e68cf6-6cdc-4b17-a83a-4981537e2607"
    }
  ],
  "status": "live",
  "subject_id": "896c3d29-801c-41be-9558-1f478fdb752d",
  "subject_name": "django/db/models/sql/query",
  "tags": [
    "entity:function"
  ],
  "text": "contains function get_children_from_q"
}
```
