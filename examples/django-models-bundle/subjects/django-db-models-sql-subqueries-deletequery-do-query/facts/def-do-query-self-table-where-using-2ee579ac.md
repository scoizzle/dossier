# Fact 2ee579ac

Store id: 7312b36b-cb73-48cc-8046-ce7dda94f145

## Text

```text
def do_query(self, table, where, using)
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
- posted_at: `2026-11-09T23:44:59.3323310+00:00`

## Data

```json
{
  "end_line": 25,
  "entity_kind": "method",
  "parent": "DeleteQuery",
  "start_line": 22,
  "symbol": "DeleteQuery.do_query"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/subqueries.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":22,"selector":"L22-L25","symbol":"DeleteQuery.do_query"}`

## Referenced by

None.

## Subject

[django/db/models/sql/subqueries::DeleteQuery.do_query](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 25,
    "entity_kind": "method",
    "parent": "DeleteQuery",
    "start_line": 22,
    "symbol": "DeleteQuery.do_query"
  },
  "id": "7312b36b-cb73-48cc-8046-ce7dda94f145",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:59.3323310+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 22,
        "selector": "L22-L25",
        "symbol": "DeleteQuery.do_query"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/subqueries.py"
    }
  ],
  "status": "live",
  "subject_id": "d827d5c4-6652-42a9-b5aa-b31cfd1cf2b3",
  "subject_name": "django/db/models/sql/subqueries::DeleteQuery.do_query",
  "tags": [
    "entity:method"
  ],
  "text": "def do_query(self, table, where, using)"
}
```
