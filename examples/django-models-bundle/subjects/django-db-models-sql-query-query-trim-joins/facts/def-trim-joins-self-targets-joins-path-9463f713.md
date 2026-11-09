# Fact 9463f713

Store id: 8a5f3718-42ef-43db-9524-91093fb20265

## Text

```text
def trim_joins(self, targets, joins, path)
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
- posted_at: `2026-11-09T23:32:06.9798660+00:00`

## Data

```json
{
  "end_line": 2037,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2007,
  "symbol": "Query.trim_joins"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2007,"selector":"L2007-L2037","symbol":"Query.trim_joins"}`

## Items

```json
[
  {
    "text": "The 'target' parameter is the final field being joined to, 'joins' is the full list of join aliases. The 'path' contain the PathInfos used to create the joins.",
    "locator": {
      "line": 2008
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.trim_joins](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2037,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2007,
    "symbol": "Query.trim_joins"
  },
  "id": "8a5f3718-42ef-43db-9524-91093fb20265",
  "items": [
    {
      "locator": {
        "line": 2008
      },
      "text": "The 'target' parameter is the final field being joined to, 'joins' is the full list of join aliases. The 'path' contain the PathInfos used to create the joins."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.9798660+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2007,
        "selector": "L2007-L2037",
        "symbol": "Query.trim_joins"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "f97524e2-5c92-4ab5-b7f3-b6196dcce1a2",
  "subject_name": "django/db/models/sql/query::Query.trim_joins",
  "tags": [
    "entity:method"
  ],
  "text": "def trim_joins(self, targets, joins, path)"
}
```
