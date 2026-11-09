# Fact 4f277036

Store id: 9340ae67-adef-48df-90ff-f90321bf24e5

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
- posted_at: `2026-11-09T23:31:55.9866220+00:00`

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
  "id": "9340ae67-adef-48df-90ff-f90321bf24e5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9866220+00:00"
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
  "subject_id": "f820cae5-4325-4c5f-8b42-628996fa785f",
  "subject_name": "django/db/models/expressions::OrderBy.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, expression, descending=False, nulls_first=None, nulls_last=None)"
}
```
