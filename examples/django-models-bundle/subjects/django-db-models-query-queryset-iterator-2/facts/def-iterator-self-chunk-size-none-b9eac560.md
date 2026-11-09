# Fact b9eac560

Store id: 449c1835-8c50-49b4-bca7-15687e7e535a

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
- posted_at: `2026-11-09T23:32:04.3631870+00:00`

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
  "id": "449c1835-8c50-49b4-bca7-15687e7e535a",
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
    "posted_at": "2026-11-09T23:32:04.3631870+00:00"
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
  "subject_id": "2ac4c197-e856-4e18-82c8-0235d38140d3",
  "subject_name": "django/db/models/query::QuerySet.iterator",
  "tags": [
    "entity:method"
  ],
  "text": "def iterator(self, chunk_size=None)"
}
```
