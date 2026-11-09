# Fact 33033648

Store id: ad951142-bc35-4741-a949-8053f094b3fc

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
- posted_at: `2026-11-09T23:44:58.8722620+00:00`

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
  "id": "ad951142-bc35-4741-a949-8053f094b3fc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.8722620+00:00"
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
  "subject_id": "c91952d6-7e4c-4e97-a5ec-13483ddcca43",
  "subject_name": "django/db/models/sql/query::Query.add_filtered_relation",
  "tags": [
    "entity:method"
  ],
  "text": "def add_filtered_relation(self, filtered_relation, alias)"
}
```
