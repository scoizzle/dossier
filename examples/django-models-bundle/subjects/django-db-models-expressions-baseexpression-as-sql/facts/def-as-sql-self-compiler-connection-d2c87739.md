# Fact d2c87739

Store id: c60d2497-fa5e-4f48-aba8-bc059f801b4f

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
- posted_at: `2026-11-09T22:39:41.5068700+00:00`

## Data

```json
{
  "end_line": 251,
  "entity_kind": "method",
  "parent": "BaseExpression",
  "start_line": 225,
  "symbol": "BaseExpression.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":225,"selector":"L225-L251","symbol":"BaseExpression.as_sql"}`

## Items

```json
[
  {
    "text": "Responsible for returning a (sql, [params]) tuple to be included in the current query.",
    "locator": {
      "line": 226
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/expressions::BaseExpression.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 251,
    "entity_kind": "method",
    "parent": "BaseExpression",
    "start_line": 225,
    "symbol": "BaseExpression.as_sql"
  },
  "id": "c60d2497-fa5e-4f48-aba8-bc059f801b4f",
  "items": [
    {
      "locator": {
        "line": 226
      },
      "text": "Responsible for returning a (sql, [params]) tuple to be included in the current query."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5068700+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 225,
        "selector": "L225-L251",
        "symbol": "BaseExpression.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "891aa467-8733-4c08-9897-f767e6025a79",
  "subject_name": "django/db/models/expressions::BaseExpression.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
