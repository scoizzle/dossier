# Fact daabe8ef

Store id: 4dcd3d4b-f044-432f-9656-a42a0d85c5bd

## Text

```text
def _has_filters(self)
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
- posted_at: `2026-11-09T23:32:04.6690760+00:00`

## Data

```json
{
  "end_line": 2344,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 2338,
  "symbol": "QuerySet._has_filters"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2338,"selector":"L2338-L2344","symbol":"QuerySet._has_filters"}`

## Items

```json
[
  {
    "text": "Check if this QuerySet has any filtering going on. This isn't equivalent with checking if all objects are present in results, for example, qs[1:]._has_filters() -> False.",
    "locator": {
      "line": 2339
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet._has_filters](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2344,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 2338,
    "symbol": "QuerySet._has_filters"
  },
  "id": "4dcd3d4b-f044-432f-9656-a42a0d85c5bd",
  "items": [
    {
      "locator": {
        "line": 2339
      },
      "text": "Check if this QuerySet has any filtering going on. This isn't equivalent with checking if all objects are present in results, for example, qs[1:]._has_filters() -> False."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.6690760+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2338,
        "selector": "L2338-L2344",
        "symbol": "QuerySet._has_filters"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "fddf55cd-2d84-46c3-a2f3-463f954493df",
  "subject_name": "django/db/models/query::QuerySet._has_filters",
  "tags": [
    "entity:method"
  ],
  "text": "def _has_filters(self)"
}
```
