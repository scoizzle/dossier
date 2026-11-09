# Fact c28b1b72

Store id: f308612e-ffa7-4a69-90d8-acff1c8946a1

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
- posted_at: `2026-11-09T23:44:49.6044260+00:00`

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
  "id": "f308612e-ffa7-4a69-90d8-acff1c8946a1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6044260+00:00"
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
  "subject_id": "54413843-9d3d-4888-829f-cb98653cd48d",
  "subject_name": "django/db/models/expressions::NegatedExpression.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
