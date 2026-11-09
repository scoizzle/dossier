# Fact a6e027fd

Store id: ce549304-3dc7-4131-9d8e-88e9a110ab05

## Text

```text
def reverse_ordering(self)
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
- posted_at: `2026-11-09T23:31:55.9949950+00:00`

## Data

```json
{
  "end_line": 2011,
  "entity_kind": "method",
  "parent": "OrderBy",
  "start_line": 2003,
  "symbol": "OrderBy.reverse_ordering"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2003,"selector":"L2003-L2011","symbol":"OrderBy.reverse_ordering"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::OrderBy.reverse_ordering](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2011,
    "entity_kind": "method",
    "parent": "OrderBy",
    "start_line": 2003,
    "symbol": "OrderBy.reverse_ordering"
  },
  "id": "ce549304-3dc7-4131-9d8e-88e9a110ab05",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9949950+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2003,
        "selector": "L2003-L2011",
        "symbol": "OrderBy.reverse_ordering"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "36d2c769-f213-4e1b-bd48-35014eb25111",
  "subject_name": "django/db/models/expressions::OrderBy.reverse_ordering",
  "tags": [
    "entity:method"
  ],
  "text": "def reverse_ordering(self)"
}
```
