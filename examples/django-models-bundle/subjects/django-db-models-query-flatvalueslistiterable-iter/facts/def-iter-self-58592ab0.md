# Fact 58592ab0

Store id: 172a99aa-01ff-4520-b170-775a48475f08

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
- posted_at: `2026-11-09T23:44:55.8113760+00:00`

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
  "id": "172a99aa-01ff-4520-b170-775a48475f08",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.8113760+00:00"
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
  "subject_id": "8cecae8f-fce6-4197-805c-46dc01a15630",
  "subject_name": "django/db/models/query::FlatValuesListIterable.__iter__",
  "tags": [
    "entity:method"
  ],
  "text": "def __iter__(self)"
}
```
