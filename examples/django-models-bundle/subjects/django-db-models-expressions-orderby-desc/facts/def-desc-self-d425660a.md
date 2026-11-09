# Fact d425660a

Store id: 3a223ea5-1e69-4cc0-9172-046965f7aba9

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
- posted_at: `2026-11-09T22:39:41.7524220+00:00`

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
  "id": "3a223ea5-1e69-4cc0-9172-046965f7aba9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7524220+00:00"
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
  "subject_id": "b4a829a9-88ae-431c-a245-daa4b117b25b",
  "subject_name": "django/db/models/expressions::OrderBy.desc",
  "tags": [
    "entity:method"
  ],
  "text": "def desc(self)"
}
```
