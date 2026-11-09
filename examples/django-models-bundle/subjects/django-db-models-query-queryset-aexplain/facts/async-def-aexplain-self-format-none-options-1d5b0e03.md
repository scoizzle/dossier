# Fact 1d5b0e03

Store id: aea338f3-5fd2-4e55-a4d1-34d98da393fb

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
- posted_at: `2026-11-09T23:44:56.0069140+00:00`

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
  "id": "aea338f3-5fd2-4e55-a4d1-34d98da393fb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.0069140+00:00"
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
  "subject_id": "716f6236-6e10-46cb-b2b2-e496be3f4e53",
  "subject_name": "django/db/models/query::QuerySet.aexplain",
  "tags": [
    "entity:method",
    "async"
  ],
  "text": "async def aexplain(self, *, format=None, **options)"
}
```
