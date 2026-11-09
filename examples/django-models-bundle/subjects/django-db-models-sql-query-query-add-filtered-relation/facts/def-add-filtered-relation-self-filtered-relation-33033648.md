# Fact 33033648

Store id: 82c1573d-ed34-47c9-91a2-b383337b504a

## Text

```text
def add_filtered_relation(self, filtered_relation, alias)
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
- posted_at: `2026-11-09T23:32:06.9577730+00:00`

## Data

```json
{
  "end_line": 1772,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 1732,
  "symbol": "Query.add_filtered_relation"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1732,"selector":"L1732-L1772","symbol":"Query.add_filtered_relation"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.add_filtered_relation](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1772,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 1732,
    "symbol": "Query.add_filtered_relation"
  },
  "id": "82c1573d-ed34-47c9-91a2-b383337b504a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.9577730+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1732,
        "selector": "L1732-L1772",
        "symbol": "Query.add_filtered_relation"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "4c58f030-c6ac-4e2f-b0a1-c62c083fdf5e",
  "subject_name": "django/db/models/sql/query::Query.add_filtered_relation",
  "tags": [
    "entity:method"
  ],
  "text": "def add_filtered_relation(self, filtered_relation, alias)"
}
```
