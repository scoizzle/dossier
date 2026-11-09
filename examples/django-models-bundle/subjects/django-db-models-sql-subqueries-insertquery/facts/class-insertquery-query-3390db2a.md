# Fact 3390db2a

Store id: da783113-c4d9-4c4d-86c0-cde2fc0eafa7

## Text

```text
class InsertQuery(Query)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:51.7573720+00:00`

## Data

```json
{
  "end_line": 164,
  "entity_kind": "class",
  "parent": "subqueries",
  "start_line": 148,
  "symbol": "InsertQuery"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/subqueries.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":148,"selector":"L148-L164","symbol":"InsertQuery"}`

## Referenced by

None.

## Subject

[django/db/models/sql/subqueries::InsertQuery](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 164,
    "entity_kind": "class",
    "parent": "subqueries",
    "start_line": 148,
    "symbol": "InsertQuery"
  },
  "id": "da783113-c4d9-4c4d-86c0-cde2fc0eafa7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.7573720+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 148,
        "selector": "L148-L164",
        "symbol": "InsertQuery"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/subqueries.py"
    }
  ],
  "status": "live",
  "subject_id": "cac895ef-8ad1-4fed-843d-2639ef72c7ba",
  "subject_name": "django/db/models/sql/subqueries::InsertQuery",
  "tags": [
    "entity:class"
  ],
  "text": "class InsertQuery(Query)"
}
```
