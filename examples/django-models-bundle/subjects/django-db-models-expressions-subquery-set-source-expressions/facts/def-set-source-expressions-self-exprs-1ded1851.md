# Fact 1ded1851

Store id: d42d58f9-c676-49be-a3b7-e3f8ab92e2a3

## Text

```text
def set_source_expressions(self, exprs)
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
- posted_at: `2026-11-09T22:39:41.7227830+00:00`

## Data

```json
{
  "end_line": 1839,
  "entity_kind": "method",
  "parent": "Subquery",
  "start_line": 1838,
  "symbol": "Subquery.set_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1838,"selector":"L1838-L1839","symbol":"Subquery.set_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Subquery.set_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1839,
    "entity_kind": "method",
    "parent": "Subquery",
    "start_line": 1838,
    "symbol": "Subquery.set_source_expressions"
  },
  "id": "d42d58f9-c676-49be-a3b7-e3f8ab92e2a3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7227830+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1838,
        "selector": "L1838-L1839",
        "symbol": "Subquery.set_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "23baed49-b442-42d2-a71d-9cc424aa1b07",
  "subject_name": "django/db/models/expressions::Subquery.set_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def set_source_expressions(self, exprs)"
}
```
