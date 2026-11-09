# Fact 2f3ba343

Store id: 28c5826e-03ad-4f42-bc13-04c4b734d2e8

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
- posted_at: `2026-11-09T23:44:49.2801980+00:00`

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
  "id": "28c5826e-03ad-4f42-bc13-04c4b734d2e8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.2801980+00:00"
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
  "subject_id": "04326403-46dc-43b8-952b-d5bd45a8c065",
  "subject_name": "django/db/models/expressions::BaseExpression.get_db_converters",
  "tags": [
    "entity:method"
  ],
  "text": "def get_db_converters(self, connection)"
}
```
