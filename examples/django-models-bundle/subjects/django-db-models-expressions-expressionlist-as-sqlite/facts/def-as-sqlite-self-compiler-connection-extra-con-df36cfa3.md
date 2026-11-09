# Fact df36cfa3

Store id: 98dbbe84-576b-46c9-ba8a-7a7054f3837c

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
- posted_at: `2026-11-09T23:31:55.9277130+00:00`

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
  "id": "98dbbe84-576b-46c9-ba8a-7a7054f3837c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9277130+00:00"
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
  "subject_id": "c44f28d0-b492-481e-b4ee-afa0879fda4c",
  "subject_name": "django/db/models/expressions::ExpressionList.as_sqlite",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sqlite(self, compiler, connection, **extra_context)"
}
```
