# Fact cdf527ea

Store id: 6b7a7790-1f24-4356-8867-21a0c5b3d14a

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
- posted_at: `2026-11-09T23:32:07.4098050+00:00`

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
  "id": "6b7a7790-1f24-4356-8867-21a0c5b3d14a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.4098050+00:00"
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
  "subject_id": "77495ccb-be33-433b-8312-7bfca918c165",
  "subject_name": "django/db/models/sql/subqueries::InsertQuery.insert_values",
  "tags": [
    "entity:method"
  ],
  "text": "def insert_values(self, fields, objs, raw=False)"
}
```
