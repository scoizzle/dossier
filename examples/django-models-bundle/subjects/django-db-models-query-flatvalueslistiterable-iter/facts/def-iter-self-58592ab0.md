# Fact 58592ab0

Store id: 17233882-0389-493d-a898-54c76688a2dc

## Text

```text
def __iter__(self)
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
- posted_at: `2026-11-09T22:39:49.2625520+00:00`

## Data

```json
{
  "end_line": 339,
  "entity_kind": "method",
  "parent": "FlatValuesListIterable",
  "start_line": 333,
  "symbol": "FlatValuesListIterable.__iter__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":333,"selector":"L333-L339","symbol":"FlatValuesListIterable.__iter__"}`

## Referenced by

None.

## Subject

[django/db/models/query::FlatValuesListIterable.__iter__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 339,
    "entity_kind": "method",
    "parent": "FlatValuesListIterable",
    "start_line": 333,
    "symbol": "FlatValuesListIterable.__iter__"
  },
  "id": "17233882-0389-493d-a898-54c76688a2dc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.2625520+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 333,
        "selector": "L333-L339",
        "symbol": "FlatValuesListIterable.__iter__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "c3f4d356-9f8d-468c-a1ea-d77ebf661401",
  "subject_name": "django/db/models/query::FlatValuesListIterable.__iter__",
  "tags": [
    "entity:method"
  ],
  "text": "def __iter__(self)"
}
```
