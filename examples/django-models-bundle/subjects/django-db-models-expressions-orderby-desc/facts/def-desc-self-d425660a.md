# Fact d425660a

Store id: 84c72158-5e30-4a98-a0a5-ecd9074cc87f

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
- posted_at: `2026-11-09T23:31:55.9974310+00:00`

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
  "id": "84c72158-5e30-4a98-a0a5-ecd9074cc87f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9974310+00:00"
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
  "subject_id": "4c329f90-143c-473b-9de2-484bdae2b5c0",
  "subject_name": "django/db/models/expressions::OrderBy.desc",
  "tags": [
    "entity:method"
  ],
  "text": "def desc(self)"
}
```
