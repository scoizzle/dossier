# Fact 8c2525bc

Store id: 7f1a1c93-eec7-46e3-8501-8682bf633d55

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
- posted_at: `2026-11-09T22:39:51.5840140+00:00`

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
  "id": "7f1a1c93-eec7-46e3-8501-8682bf633d55",
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
        "line": 92,
        "symbol": "get_children_from_q"
      },
      "rel": "contains",
      "target": "95245811-987a-461d-b1fb-4b571d17e9cf"
    }
  ],
  "status": "live",
  "subject_id": "414527cc-92ff-4d99-a78e-04fa25656e92",
  "subject_name": "django/db/models/sql/query",
  "tags": [
    "entity:function"
  ],
  "text": "contains function get_children_from_q"
}
```
