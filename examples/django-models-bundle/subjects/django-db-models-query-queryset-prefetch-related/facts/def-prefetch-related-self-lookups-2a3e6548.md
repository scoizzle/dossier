# Fact 2a3e6548

Store id: 54189057-ccfa-4da6-9ae1-0c7de74888f3

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
- posted_at: `2026-11-09T23:32:04.5731870+00:00`

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
  "id": "54189057-ccfa-4da6-9ae1-0c7de74888f3",
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
    "posted_at": "2026-11-09T23:32:04.5731870+00:00"
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
  "subject_id": "de1a200e-b2c3-40bc-a06b-d441c7bd51a3",
  "subject_name": "django/db/models/query::QuerySet.prefetch_related",
  "tags": [
    "entity:method"
  ],
  "text": "def prefetch_related(self, *lookups)"
}
```
