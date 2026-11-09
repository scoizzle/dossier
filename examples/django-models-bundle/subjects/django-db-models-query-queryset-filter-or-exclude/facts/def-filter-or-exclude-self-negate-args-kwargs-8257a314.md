# Fact 8257a314

Store id: 7b02b0d7-7281-4bfa-a9ee-43e1e12ef534

## Text

```text
def _filter_or_exclude(self, negate, args, kwargs)
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
- posted_at: `2026-11-09T23:32:04.5438880+00:00`

## Data

```json
{
  "end_line": 1720,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1711,
  "symbol": "QuerySet._filter_or_exclude"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1711,"selector":"L1711-L1720","symbol":"QuerySet._filter_or_exclude"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet._filter_or_exclude](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1720,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1711,
    "symbol": "QuerySet._filter_or_exclude"
  },
  "id": "7b02b0d7-7281-4bfa-a9ee-43e1e12ef534",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.5438880+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1711,
        "selector": "L1711-L1720",
        "symbol": "QuerySet._filter_or_exclude"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "124bc05a-d226-40d1-b85f-6102bfe60462",
  "subject_name": "django/db/models/query::QuerySet._filter_or_exclude",
  "tags": [
    "entity:method"
  ],
  "text": "def _filter_or_exclude(self, negate, args, kwargs)"
}
```
