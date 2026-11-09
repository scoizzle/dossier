# Fact 58592ab0

Store id: 303a7c6c-e816-42a0-ab60-87101216b7ad

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
- posted_at: `2026-11-09T23:32:04.2836740+00:00`

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
  "id": "303a7c6c-e816-42a0-ab60-87101216b7ad",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.2836740+00:00"
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
  "subject_id": "843cac48-80fb-4478-8f5a-f16ebe953bb5",
  "subject_name": "django/db/models/query::FlatValuesListIterable.__iter__",
  "tags": [
    "entity:method"
  ],
  "text": "def __iter__(self)"
}
```
