# Fact 2ee579ac

Store id: 761d69e9-0ae3-485b-8031-bfe9664f006e

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
- posted_at: `2026-11-09T23:32:07.3444530+00:00`

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
  "id": "761d69e9-0ae3-485b-8031-bfe9664f006e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.3444530+00:00"
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
  "subject_id": "1e818c53-ae88-453a-8cd7-de50f1a1f37a",
  "subject_name": "django/db/models/sql/subqueries::DeleteQuery.do_query",
  "tags": [
    "entity:method"
  ],
  "text": "def do_query(self, table, where, using)"
}
```
