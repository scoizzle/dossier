# Fact 2f3ba343

Store id: e9cf828a-8427-438a-b3df-28e890f81fb3

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
- posted_at: `2026-11-09T22:39:41.5023890+00:00`

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
  "id": "e9cf828a-8427-438a-b3df-28e890f81fb3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5023890+00:00"
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
  "subject_id": "51b33d64-b6a4-4fe6-8acc-031125b349ca",
  "subject_name": "django/db/models/expressions::BaseExpression.get_db_converters",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_converters(self, connection)"
}
```
