# Fact 2f3ba343

Store id: 376a0115-f0b8-4160-a9e2-48b11f92e7cc

## Text

```text
def get_db_converters(self, connection)
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
- posted_at: `2026-11-09T23:31:55.7600060+00:00`

## Data

```json
{
  "end_line": 207,
  "entity_kind": "method",
  "parent": "BaseExpression",
  "start_line": 202,
  "symbol": "BaseExpression.get_db_converters"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":202,"selector":"L202-L207","symbol":"BaseExpression.get_db_converters"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::BaseExpression.get_db_converters](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 207,
    "entity_kind": "method",
    "parent": "BaseExpression",
    "start_line": 202,
    "symbol": "BaseExpression.get_db_converters"
  },
  "id": "376a0115-f0b8-4160-a9e2-48b11f92e7cc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.7600060+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 202,
        "selector": "L202-L207",
        "symbol": "BaseExpression.get_db_converters"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "520590a8-3af2-41b1-a3d3-c0366a277505",
  "subject_name": "django/db/models/expressions::BaseExpression.get_db_converters",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_converters(self, connection)"
}
```
