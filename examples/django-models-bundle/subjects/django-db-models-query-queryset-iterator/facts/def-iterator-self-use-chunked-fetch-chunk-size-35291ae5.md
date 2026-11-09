# Fact 35291ae5

Store id: 23279b2b-0cef-481c-bc5e-5a0bcc4e51fd

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
- posted_at: `2026-11-09T23:44:55.8755300+00:00`

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
  "id": "23279b2b-0cef-481c-bc5e-5a0bcc4e51fd",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.8755300+00:00"
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
  "subject_id": "5b3f7eb1-3fa4-4579-a815-ebe3e0ae0ba1",
  "subject_name": "django/db/models/query::QuerySet._iterator",
  "tags": [
    "entity:method"
  ],
  "text": "def _iterator(self, use_chunked_fetch, chunk_size)"
}
```
