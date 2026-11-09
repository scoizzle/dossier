# Fact 2a3e6548

Store id: 3dd4bb89-340c-4db7-9efa-d4c140cb3adf

## Text

```text
def prefetch_related(self, *lookups)
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
- posted_at: `2026-11-09T22:39:49.6447850+00:00`

## Data

```json
{
  "end_line": 1859,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1836,
  "symbol": "QuerySet.prefetch_related"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1836,"selector":"L1836-L1859","symbol":"QuerySet.prefetch_related"}`

## Items

```json
[
  {
    "text": "Return a new QuerySet instance that will prefetch the specified Many-To-One and Many-To-Many related objects when the QuerySet is evaluated.",
    "locator": {
      "line": 1837
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.prefetch_related](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1859,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1836,
    "symbol": "QuerySet.prefetch_related"
  },
  "id": "3dd4bb89-340c-4db7-9efa-d4c140cb3adf",
  "items": [
    {
      "locator": {
        "line": 1837
      },
      "text": "Return a new QuerySet instance that will prefetch the specified Many-To-One and Many-To-Many related objects when the QuerySet is evaluated."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.6447850+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1836,
        "selector": "L1836-L1859",
        "symbol": "QuerySet.prefetch_related"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "99a4d1fb-578c-4c08-aa9d-761f8ba62fe4",
  "subject_name": "django/db/models/query::QuerySet.prefetch_related",
  "tags": [
    "entity:method"
  ],
  "text": "def prefetch_related(self, *lookups)"
}
```
