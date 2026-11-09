# Fact c28b1b72

Store id: 012181a7-bec9-447a-b5c0-0717b0ebea17

## Text

```text
def as_sql(self, compiler, connection)
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
- posted_at: `2026-11-09T23:31:55.9421000+00:00`

## Data

```json
{
  "end_line": 1607,
  "entity_kind": "method",
  "parent": "NegatedExpression",
  "start_line": 1593,
  "symbol": "NegatedExpression.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1593,"selector":"L1593-L1607","symbol":"NegatedExpression.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::NegatedExpression.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1607,
    "entity_kind": "method",
    "parent": "NegatedExpression",
    "start_line": 1593,
    "symbol": "NegatedExpression.as_sql"
  },
  "id": "012181a7-bec9-447a-b5c0-0717b0ebea17",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9421000+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1593,
        "selector": "L1593-L1607",
        "symbol": "NegatedExpression.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "b8cc6127-3cae-402c-bb1e-441cbacdbcdf",
  "subject_name": "django/db/models/expressions::NegatedExpression.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
