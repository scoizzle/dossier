# Fact 2e776bf1

Store id: ad7f5c6d-9738-41fb-a6aa-6533b823b28b

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
- posted_at: `2026-11-09T22:39:51.4908120+00:00`

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
  "id": "ad7f5c6d-9738-41fb-a6aa-6533b823b28b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.4908120+00:00"
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
  "subject_id": "5567da75-7583-4c6e-823b-6415f7c8b987",
  "subject_name": "django/db/models/sql/query::Query.orderby_issubset_groupby",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def orderby_issubset_groupby(self)"
}
```
