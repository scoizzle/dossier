# Fact da04b813

Store id: c7c843b1-9d1e-416c-a8b6-c47ddd188a63

## Text

```text
def reset_refcounts(self, to_counts)
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
- posted_at: `2026-11-09T23:32:06.8495820+00:00`

## Data

```json
{
  "end_line": 998,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 991,
  "symbol": "Query.reset_refcounts"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":991,"selector":"L991-L998","symbol":"Query.reset_refcounts"}`

## Items

```json
[
  {
    "text": "Reset reference counts for aliases so that they match the value passed in `to_counts`.",
    "locator": {
      "line": 992
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.reset_refcounts](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 998,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 991,
    "symbol": "Query.reset_refcounts"
  },
  "id": "c7c843b1-9d1e-416c-a8b6-c47ddd188a63",
  "items": [
    {
      "locator": {
        "line": 992
      },
      "text": "Reset reference counts for aliases so that they match the value passed in `to_counts`."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.8495820+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 991,
        "selector": "L991-L998",
        "symbol": "Query.reset_refcounts"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "44c02478-f5e0-43a5-99ac-29816b6425dc",
  "subject_name": "django/db/models/sql/query::Query.reset_refcounts",
  "tags": [
    "entity:method"
  ],
  "text": "def reset_refcounts(self, to_counts)"
}
```
