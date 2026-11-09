# Fact b8fd3059

Store id: 11d0702a-3009-4bd2-a477-9d3cf1b2dd4e

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
- posted_at: `2026-11-09T22:39:41.5801540+00:00`

## Data

```json
{
  "end_line": 1095,
  "entity_kind": "method",
  "parent": "Func",
  "start_line": 1094,
  "symbol": "Func.set_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1094,"selector":"L1094-L1095","symbol":"Func.set_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Func.set_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1095,
    "entity_kind": "method",
    "parent": "Func",
    "start_line": 1094,
    "symbol": "Func.set_source_expressions"
  },
  "id": "11d0702a-3009-4bd2-a477-9d3cf1b2dd4e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5801540+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1094,
        "selector": "L1094-L1095",
        "symbol": "Func.set_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "f12e611e-cbe3-45b8-aa0b-b6ce00647b54",
  "subject_name": "django/db/models/expressions::Func.set_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def set_source_expressions(self, exprs)"
}
```
