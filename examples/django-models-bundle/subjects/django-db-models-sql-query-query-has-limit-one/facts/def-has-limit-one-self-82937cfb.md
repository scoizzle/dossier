# Fact 82937cfb

Store id: 0d6cd317-21ca-42c2-9157-ac1a4c20027b

## Text

```text
def has_limit_one(self)
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
- posted_at: `2026-11-09T23:32:07.0306530+00:00`

## Data

```json
{
  "end_line": 2221,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2220,
  "symbol": "Query.has_limit_one"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2220,"selector":"L2220-L2221","symbol":"Query.has_limit_one"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.has_limit_one](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2221,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2220,
    "symbol": "Query.has_limit_one"
  },
  "id": "0d6cd317-21ca-42c2-9157-ac1a4c20027b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.0306530+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2220,
        "selector": "L2220-L2221",
        "symbol": "Query.has_limit_one"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "c7024668-85be-414c-aec4-336b8c5d3018",
  "subject_name": "django/db/models/sql/query::Query.has_limit_one",
  "tags": [
    "entity:method"
  ],
  "text": "def has_limit_one(self)"
}
```
