# Fact 3390db2a

Store id: e6c8f875-b672-4dd6-9e69-3e5d1a49d0dc

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
- posted_at: `2026-11-09T23:44:59.4281500+00:00`

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
  "id": "e6c8f875-b672-4dd6-9e69-3e5d1a49d0dc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:59.4281500+00:00"
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
  "subject_id": "f2134864-8758-4511-88bc-4bf5f56ad259",
  "subject_name": "django/db/models/sql/subqueries::InsertQuery",
  "tags": [
    "entity:class"
  ],
  "text": "class InsertQuery(Query)"
}
```
