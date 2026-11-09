# Fact 267caa5e

Store id: ed1d2e89-a357-41a7-aae2-75ed22f28777

## Text

```text
def as_sql(self, *args, **kwargs)
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
- posted_at: `2026-11-09T23:44:49.5863380+00:00`

## Data

```json
{
  "end_line": 1503,
  "entity_kind": "method",
  "parent": "ExpressionList",
  "start_line": 1500,
  "symbol": "ExpressionList.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1500,"selector":"L1500-L1503","symbol":"ExpressionList.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::ExpressionList.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1503,
    "entity_kind": "method",
    "parent": "ExpressionList",
    "start_line": 1500,
    "symbol": "ExpressionList.as_sql"
  },
  "id": "ed1d2e89-a357-41a7-aae2-75ed22f28777",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5863380+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1500,
        "selector": "L1500-L1503",
        "symbol": "ExpressionList.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "61bbc6c8-5dca-419f-bc38-98c8709596ac",
  "subject_name": "django/db/models/expressions::ExpressionList.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, *args, **kwargs)"
}
```
