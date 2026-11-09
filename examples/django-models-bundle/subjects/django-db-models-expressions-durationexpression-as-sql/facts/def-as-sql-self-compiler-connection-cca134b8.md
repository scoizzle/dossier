# Fact cca134b8

Store id: 50cdbe41-3b12-40c6-82e9-3bab90ea9368

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
- posted_at: `2026-11-09T22:39:41.5527930+00:00`

## Data

```json
{
  "end_line": 842,
  "entity_kind": "method",
  "parent": "DurationExpression",
  "start_line": 827,
  "symbol": "DurationExpression.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":827,"selector":"L827-L842","symbol":"DurationExpression.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::DurationExpression.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 842,
    "entity_kind": "method",
    "parent": "DurationExpression",
    "start_line": 827,
    "symbol": "DurationExpression.as_sql"
  },
  "id": "50cdbe41-3b12-40c6-82e9-3bab90ea9368",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5527930+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 827,
        "selector": "L827-L842",
        "symbol": "DurationExpression.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "685d7496-db09-4b61-9f83-d7b95615fe3d",
  "subject_name": "django/db/models/expressions::DurationExpression.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
