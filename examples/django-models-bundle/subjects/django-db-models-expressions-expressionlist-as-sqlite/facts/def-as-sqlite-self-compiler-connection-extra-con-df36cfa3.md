# Fact df36cfa3

Store id: 63c0bbc5-de24-4111-b110-7fc292122ee7

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
- posted_at: `2026-11-09T23:44:49.5872310+00:00`

## Data

```json
{
  "end_line": 1507,
  "entity_kind": "method",
  "parent": "ExpressionList",
  "start_line": 1505,
  "symbol": "ExpressionList.as_sqlite"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1505,"selector":"L1505-L1507","symbol":"ExpressionList.as_sqlite"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::ExpressionList.as_sqlite](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1507,
    "entity_kind": "method",
    "parent": "ExpressionList",
    "start_line": 1505,
    "symbol": "ExpressionList.as_sqlite"
  },
  "id": "63c0bbc5-de24-4111-b110-7fc292122ee7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5872310+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1505,
        "selector": "L1505-L1507",
        "symbol": "ExpressionList.as_sqlite"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "4ddf992f-0efe-4957-8546-7ef8b9ebff25",
  "subject_name": "django/db/models/expressions::ExpressionList.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection, **extra_context)"
}
```
