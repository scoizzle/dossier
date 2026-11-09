# Fact b9eac560

Store id: bccf0b11-5a0c-42bb-8f2e-af7b5abf87d0

## Text

```text
def iterator(self, chunk_size=None)
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
- posted_at: `2026-11-09T22:39:49.3617550+00:00`

## Data

```json
{
  "end_line": 616,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 599,
  "symbol": "QuerySet.iterator"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":599,"selector":"L599-L616","symbol":"QuerySet.iterator"}`

## Items

```json
[
  {
    "text": "An iterator over the results from applying this QuerySet to the database. chunk_size must be provided for QuerySets that prefetch related objects. Otherwise, a default chunk_size of 2000 is supplied.",
    "locator": {
      "line": 600
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.iterator](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 616,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 599,
    "symbol": "QuerySet.iterator"
  },
  "id": "bccf0b11-5a0c-42bb-8f2e-af7b5abf87d0",
  "items": [
    {
      "locator": {
        "line": 600
      },
      "text": "An iterator over the results from applying this QuerySet to the database. chunk_size must be provided for QuerySets that prefetch related objects. Otherwise, a default chunk_size of 2000 is supplied."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.3617550+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 599,
        "selector": "L599-L616",
        "symbol": "QuerySet.iterator"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "f9219d60-8d74-43c8-a5c8-5e1ab3e9468b",
  "subject_name": "django/db/models/query::QuerySet.iterator",
  "tags": [
    "entity:method"
  ],
  "text": "def iterator(self, chunk_size=None)"
}
```
