# Fact 6506d8d0

Store id: 35559ece-8467-4b33-8a09-091fd1f8d952

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
- posted_at: `2026-11-09T23:44:49.4538760+00:00`

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
  "id": "35559ece-8467-4b33-8a09-091fd1f8d952",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.4538760+00:00"
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
  "subject_id": "b837e4d9-4be3-475d-a1b9-8b60246dfa97",
  "subject_name": "django/db/models/expressions::DurationExpression.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection, **extra_context)"
}
```
