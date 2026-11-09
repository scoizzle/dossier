# Fact 6506d8d0

Store id: 3a7a096c-76e4-4588-91cd-428ff83e6ff2

## Text

```text
def as_sqlite(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T22:39:41.5534600+00:00`

## Data

```json
{
  "end_line": 863,
  "entity_kind": "method",
  "parent": "DurationExpression",
  "start_line": 844,
  "symbol": "DurationExpression.as_sqlite"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":844,"selector":"L844-L863","symbol":"DurationExpression.as_sqlite"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::DurationExpression.as_sqlite](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 863,
    "entity_kind": "method",
    "parent": "DurationExpression",
    "start_line": 844,
    "symbol": "DurationExpression.as_sqlite"
  },
  "id": "3a7a096c-76e4-4588-91cd-428ff83e6ff2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5534600+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 844,
        "selector": "L844-L863",
        "symbol": "DurationExpression.as_sqlite"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "44af7af6-afe0-4209-b651-515e031dc85a",
  "subject_name": "django/db/models/expressions::DurationExpression.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection, **extra_context)"
}
```
