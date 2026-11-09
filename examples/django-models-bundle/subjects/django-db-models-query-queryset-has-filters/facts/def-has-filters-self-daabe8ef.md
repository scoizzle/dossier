# Fact daabe8ef

Store id: ff38667f-4824-45fc-8f8d-15d10fc69499

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
- posted_at: `2026-11-09T22:39:49.7363150+00:00`

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
  "id": "ff38667f-4824-45fc-8f8d-15d10fc69499",
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
    "posted_at": "2026-11-09T22:39:49.7363150+00:00"
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
  "subject_id": "74f61ae3-18d5-4f60-a64d-a13fbdbf3322",
  "subject_name": "django/db/models/query::QuerySet._has_filters",
  "tags": [
    "entity:method"
  ],
  "text": "def _has_filters(self)"
}
```
