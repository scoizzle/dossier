# Fact 1583aae9

Store id: 094e80b1-6bae-4c24-9ceb-41583cb55d6f

## Text

```text
def get_source_expressions(self)
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
- posted_at: `2026-11-09T22:39:41.7451140+00:00`

## Data

```json
{
  "end_line": 1942,
  "entity_kind": "method",
  "parent": "OrderBy",
  "start_line": 1941,
  "symbol": "OrderBy.get_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1941,"selector":"L1941-L1942","symbol":"OrderBy.get_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::OrderBy.get_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1942,
    "entity_kind": "method",
    "parent": "OrderBy",
    "start_line": 1941,
    "symbol": "OrderBy.get_source_expressions"
  },
  "id": "094e80b1-6bae-4c24-9ceb-41583cb55d6f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7451140+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1941,
        "selector": "L1941-L1942",
        "symbol": "OrderBy.get_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "497dd24f-3c98-458b-b2f8-7b5cf9f4646f",
  "subject_name": "django/db/models/expressions::OrderBy.get_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def get_source_expressions(self)"
}
```
