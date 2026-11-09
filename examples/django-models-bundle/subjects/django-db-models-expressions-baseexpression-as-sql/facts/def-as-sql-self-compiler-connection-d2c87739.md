# Fact d2c87739

Store id: e2999811-5e04-4d33-ad1c-c24c69424997

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
- posted_at: `2026-11-09T23:44:49.3025960+00:00`

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
  "id": "e2999811-5e04-4d33-ad1c-c24c69424997",
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
    "posted_at": "2026-11-09T23:44:49.3025960+00:00"
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
  "subject_id": "3dcf8f9d-8b6f-449f-ac74-4e274feb30b5",
  "subject_name": "django/db/models/expressions::BaseExpression.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
