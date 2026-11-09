# Fact 4f277036

Store id: 75e087ff-7a83-4393-bad2-9d21bbc39eee

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
- posted_at: `2026-11-09T22:39:41.7414100+00:00`

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
  "id": "75e087ff-7a83-4393-bad2-9d21bbc39eee",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7414100+00:00"
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
  "subject_id": "8c119eeb-54c9-4039-8fda-27353401f39a",
  "subject_name": "django/db/models/expressions::OrderBy.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, expression, descending=False, nulls_first=None, nulls_last=None)"
}
```
