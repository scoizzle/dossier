# Fact fb7ec539

Store id: 9c7c17dc-939b-47a2-9e97-ff0383be03b8

## Text

```text
def add_ordering(self, *ordering)
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
- posted_at: `2026-11-09T23:44:58.9817600+00:00`

## Data

```json
{
  "end_line": 2360,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2326,
  "symbol": "Query.add_ordering"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2326,"selector":"L2326-L2360","symbol":"Query.add_ordering"}`

## Items

```json
[
  {
    "text": "Add items from the 'ordering' sequence to the query's \"order by\" clause. These items are either field names (not column names) -- possibly with a direction prefix ('-' or '?') -- or OrderBy expressions.",
    "locator": {
      "line": 2327
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.add_ordering](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2360,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2326,
    "symbol": "Query.add_ordering"
  },
  "id": "9c7c17dc-939b-47a2-9e97-ff0383be03b8",
  "items": [
    {
      "locator": {
        "line": 2327
      },
      "text": "Add items from the 'ordering' sequence to the query's \"order by\" clause. These items are either field names (not column names) -- possibly with a direction prefix ('-' or '?') -- or OrderBy expressions."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.9817600+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2326,
        "selector": "L2326-L2360",
        "symbol": "Query.add_ordering"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "dae89c10-6d29-4495-8c9a-a9bf85e6efaf",
  "subject_name": "django/db/models/sql/query::Query.add_ordering",
  "tags": [
    "entity:method"
  ],
  "text": "def add_ordering(self, *ordering)"
}
```
