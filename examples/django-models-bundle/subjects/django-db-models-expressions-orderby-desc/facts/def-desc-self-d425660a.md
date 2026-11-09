# Fact d425660a

Store id: 1eb2f518-5d2f-466e-bed5-1081f6f8e337

## Text

```text
def desc(self)
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
- posted_at: `2026-11-09T23:44:49.6652830+00:00`

## Data

```json
{
  "end_line": 2017,
  "entity_kind": "method",
  "parent": "OrderBy",
  "start_line": 2016,
  "symbol": "OrderBy.desc"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2016,"selector":"L2016-L2017","symbol":"OrderBy.desc"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::OrderBy.desc](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2017,
    "entity_kind": "method",
    "parent": "OrderBy",
    "start_line": 2016,
    "symbol": "OrderBy.desc"
  },
  "id": "1eb2f518-5d2f-466e-bed5-1081f6f8e337",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6652830+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2016,
        "selector": "L2016-L2017",
        "symbol": "OrderBy.desc"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "63f187db-7455-41c8-b9c2-b5b075287e29",
  "subject_name": "django/db/models/expressions::OrderBy.desc",
  "tags": [
    "entity:method"
  ],
  "text": "def desc(self)"
}
```
