# Fact 2e776bf1

Store id: a92fdbeb-a680-487f-8f7a-a5b689a24c08

## Text

```text
def orderby_issubset_groupby(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:58.9854980+00:00`

## Data

```json
{
  "end_line": 2388,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2362,
  "symbol": "Query.orderby_issubset_groupby"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2362,"selector":"L2362-L2388","symbol":"Query.orderby_issubset_groupby"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.orderby_issubset_groupby](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2388,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2362,
    "symbol": "Query.orderby_issubset_groupby"
  },
  "id": "a92fdbeb-a680-487f-8f7a-a5b689a24c08",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.9854980+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2362,
        "selector": "L2362-L2388",
        "symbol": "Query.orderby_issubset_groupby"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "f040e8bf-38be-4687-a9dd-71a61f6ab1e7",
  "subject_name": "django/db/models/sql/query::Query.orderby_issubset_groupby",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def orderby_issubset_groupby(self)"
}
```
