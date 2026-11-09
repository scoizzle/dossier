# Fact 1583aae9

Store id: 5db3ef20-682c-43f4-8fe2-f4e438495993

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
- posted_at: `2026-11-09T23:44:49.6571780+00:00`

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
  "id": "5db3ef20-682c-43f4-8fe2-f4e438495993",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6571780+00:00"
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
  "subject_id": "7f61d3fc-e0aa-4054-a8ee-a4b32865ceb9",
  "subject_name": "django/db/models/expressions::OrderBy.get_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def get_source_expressions(self)"
}
```
