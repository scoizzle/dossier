# Fact 35291ae5

Store id: d7d6f3a6-e3af-4caa-aa20-7bacd10c1a36

## Text

```text
def _iterator(self, use_chunked_fetch, chunk_size)
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
- posted_at: `2026-11-09T23:32:04.3605290+00:00`

## Data

```json
{
  "end_line": 597,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 584,
  "symbol": "QuerySet._iterator"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":584,"selector":"L584-L597","symbol":"QuerySet._iterator"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet._iterator](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 597,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 584,
    "symbol": "QuerySet._iterator"
  },
  "id": "d7d6f3a6-e3af-4caa-aa20-7bacd10c1a36",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.3605290+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 584,
        "selector": "L584-L597",
        "symbol": "QuerySet._iterator"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "696ff628-6162-48ef-9f18-e278dfe5bd7e",
  "subject_name": "django/db/models/query::QuerySet._iterator",
  "tags": [
    "entity:method"
  ],
  "text": "def _iterator(self, use_chunked_fetch, chunk_size)"
}
```
