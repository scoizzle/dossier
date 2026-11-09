# Fact cdf527ea

Store id: d0cb29c8-cf13-4912-8def-4b556046e425

## Text

```text
def insert_values(self, fields, objs, raw=False)
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
- posted_at: `2026-11-09T23:44:59.4383810+00:00`

## Data

```json
{
  "end_line": 164,
  "entity_kind": "method",
  "parent": "InsertQuery",
  "start_line": 161,
  "symbol": "InsertQuery.insert_values"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/subqueries.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":161,"selector":"L161-L164","symbol":"InsertQuery.insert_values"}`

## Referenced by

None.

## Subject

[django/db/models/sql/subqueries::InsertQuery.insert_values](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 164,
    "entity_kind": "method",
    "parent": "InsertQuery",
    "start_line": 161,
    "symbol": "InsertQuery.insert_values"
  },
  "id": "d0cb29c8-cf13-4912-8def-4b556046e425",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:59.4383810+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 161,
        "selector": "L161-L164",
        "symbol": "InsertQuery.insert_values"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/subqueries.py"
    }
  ],
  "status": "live",
  "subject_id": "37dd9b08-5ce4-4ca4-92b9-f64ee1d4cc23",
  "subject_name": "django/db/models/sql/subqueries::InsertQuery.insert_values",
  "tags": [
    "entity:method"
  ],
  "text": "def insert_values(self, fields, objs, raw=False)"
}
```
