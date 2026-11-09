# Fact 4f277036

Store id: 0972f1b9-1029-45df-aa9d-18e2d72970a6

## Text

```text
def __init__(self, expression, descending=False, nulls_first=None, nulls_last=None)
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
- posted_at: `2026-11-09T23:44:49.6525880+00:00`

## Data

```json
{
  "end_line": 1931,
  "entity_kind": "method",
  "parent": "OrderBy",
  "start_line": 1921,
  "symbol": "OrderBy.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1921,"selector":"L1921-L1931","symbol":"OrderBy.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::OrderBy.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1931,
    "entity_kind": "method",
    "parent": "OrderBy",
    "start_line": 1921,
    "symbol": "OrderBy.__init__"
  },
  "id": "0972f1b9-1029-45df-aa9d-18e2d72970a6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6525880+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1921,
        "selector": "L1921-L1931",
        "symbol": "OrderBy.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "4434902d-5cf4-4d62-9353-82fca57eeaea",
  "subject_name": "django/db/models/expressions::OrderBy.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, expression, descending=False, nulls_first=None, nulls_last=None)"
}
```
