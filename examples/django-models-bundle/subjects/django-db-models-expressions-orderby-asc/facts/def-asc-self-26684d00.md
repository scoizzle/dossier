# Fact 26684d00

Store id: 4d268f87-8a47-4ddc-93c6-fc00006eaca9

## Text

```text
def asc(self)
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
- posted_at: `2026-11-09T22:39:41.7512260+00:00`

## Data

```json
{
  "end_line": 2014,
  "entity_kind": "method",
  "parent": "OrderBy",
  "start_line": 2013,
  "symbol": "OrderBy.asc"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2013,"selector":"L2013-L2014","symbol":"OrderBy.asc"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::OrderBy.asc](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2014,
    "entity_kind": "method",
    "parent": "OrderBy",
    "start_line": 2013,
    "symbol": "OrderBy.asc"
  },
  "id": "4d268f87-8a47-4ddc-93c6-fc00006eaca9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7512260+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2013,
        "selector": "L2013-L2014",
        "symbol": "OrderBy.asc"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "7449d0da-dcd6-4fd7-8e25-79b27bb5a2cc",
  "subject_name": "django/db/models/expressions::OrderBy.asc",
  "tags": [
    "entity:method"
  ],
  "text": "def asc(self)"
}
```
