# Fact d74279bd

Store id: 5ac07ceb-231c-4ecc-8f1a-83594a8f8bd0

## Text

```text
def as_sql(self, compiler, connection)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:50.2021260+00:00`

## Data

```json
{
  "end_line": 570,
  "entity_kind": "method",
  "parent": "FilteredRelation",
  "start_line": 569,
  "symbol": "FilteredRelation.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":569,"selector":"L569-L570","symbol":"FilteredRelation.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::FilteredRelation.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 570,
    "entity_kind": "method",
    "parent": "FilteredRelation",
    "start_line": 569,
    "symbol": "FilteredRelation.as_sql"
  },
  "id": "5ac07ceb-231c-4ecc-8f1a-83594a8f8bd0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.2021260+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 569,
        "selector": "L569-L570",
        "symbol": "FilteredRelation.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "e0114fd6-52a4-47a0-bb3a-96a15b165b35",
  "subject_name": "django/db/models/query_utils::FilteredRelation.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
