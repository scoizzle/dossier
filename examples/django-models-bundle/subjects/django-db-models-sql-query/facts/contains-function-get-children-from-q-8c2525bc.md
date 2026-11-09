# Fact 8c2525bc

Store id: f7559bf6-e373-4d1b-8b19-9062bb08ae92

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
- posted_at: `2026-11-09T23:44:59.0942990+00:00`

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
  "id": "f7559bf6-e373-4d1b-8b19-9062bb08ae92",
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
        "line": 92,
        "symbol": "get_children_from_q"
      },
      "rel": "contains",
      "target": "d023db1a-dbf8-4ed8-a289-93ad36398bf2"
    }
  ],
  "status": "live",
  "subject_id": "ba44da72-3cad-4dd7-ae2b-7d1f35aaf915",
  "subject_name": "django/db/models/sql/query",
  "tags": [
    "entity:function"
  ],
  "text": "contains function get_children_from_q"
}
```
