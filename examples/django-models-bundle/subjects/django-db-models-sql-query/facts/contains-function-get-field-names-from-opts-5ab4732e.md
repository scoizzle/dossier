# Fact 5ab4732e

Store id: e9b8452a-b4f1-460a-ade4-50c6222b9945

## Text

```text
contains function get_field_names_from_opts
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
  - target: [django/db/models/sql/query::get_field_names_from_opts](../../django-db-models-sql-query-get-field-names-from-opts/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":71,"symbol":"get_field_names_from_opts"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "e9b8452a-b4f1-460a-ade4-50c6222b9945",
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
        "line": 71,
        "symbol": "get_field_names_from_opts"
      },
      "rel": "contains",
      "target": "e58e599a-b26d-4882-8869-366d9770ef4b"
    }
  ],
  "status": "live",
  "subject_id": "896c3d29-801c-41be-9558-1f478fdb752d",
  "subject_name": "django/db/models/sql/query",
  "tags": [
    "entity:function"
  ],
  "text": "contains function get_field_names_from_opts"
}
```
