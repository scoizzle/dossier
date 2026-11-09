# Fact 1d5b0e03

Store id: 28893cef-bf9d-42d2-ad68-335093c5da2f

## Text

```text
async def aexplain(self, *, format=None, **options)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `async`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:04.5107250+00:00`

## Data

```json
{
  "end_line": 1526,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1525,
  "symbol": "QuerySet.aexplain"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1525,"selector":"L1525-L1526","symbol":"QuerySet.aexplain"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.aexplain](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1526,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1525,
    "symbol": "QuerySet.aexplain"
  },
  "id": "28893cef-bf9d-42d2-ad68-335093c5da2f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.5107250+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1525,
        "selector": "L1525-L1526",
        "symbol": "QuerySet.aexplain"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "6c62c813-19fc-404c-8872-577708a501bb",
  "subject_name": "django/db/models/query::QuerySet.aexplain",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def aexplain(self, *, format=None, **options)"
}
```
