# Fact f4174589

Store id: 7e988c47-8404-489d-b00b-fcd7d0466d29

## Text

```text
def get_aggregation(self, using, aggregate_exprs)
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
- posted_at: `2026-11-09T23:44:58.6531650+00:00`

## Data

```json
{
  "end_line": 649,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 457,
  "symbol": "Query.get_aggregation"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":457,"selector":"L457-L649","symbol":"Query.get_aggregation"}`

## Items

```json
[
  {
    "text": "Return the dictionary with the values of the existing aggregations.",
    "locator": {
      "line": 458
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.get_aggregation](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 649,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 457,
    "symbol": "Query.get_aggregation"
  },
  "id": "7e988c47-8404-489d-b00b-fcd7d0466d29",
  "items": [
    {
      "locator": {
        "line": 458
      },
      "text": "Return the dictionary with the values of the existing aggregations."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.6531650+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 457,
        "selector": "L457-L649",
        "symbol": "Query.get_aggregation"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "0ac55bea-6bb8-4778-9f10-eb3fe8cad57f",
  "subject_name": "django/db/models/sql/query::Query.get_aggregation",
  "tags": [
    "entity:method"
  ],
  "text": "def get_aggregation(self, using, aggregate_exprs)"
}
```
