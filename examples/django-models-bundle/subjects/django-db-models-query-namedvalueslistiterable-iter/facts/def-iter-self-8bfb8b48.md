# Fact 8bfb8b48

Store id: 293b6718-0c01-4683-8e56-815c8e8760c3

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
- posted_at: `2026-11-09T23:44:55.8060070+00:00`

## Data

```json
{
  "end_line": 324,
  "entity_kind": "method",
  "parent": "NamedValuesListIterable",
  "start_line": 310,
  "symbol": "NamedValuesListIterable.__iter__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":310,"selector":"L310-L324","symbol":"NamedValuesListIterable.__iter__"}`

## Referenced by

None.

## Subject

[django/db/models/query::NamedValuesListIterable.__iter__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 324,
    "entity_kind": "method",
    "parent": "NamedValuesListIterable",
    "start_line": 310,
    "symbol": "NamedValuesListIterable.__iter__"
  },
  "id": "293b6718-0c01-4683-8e56-815c8e8760c3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.8060070+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 310,
        "selector": "L310-L324",
        "symbol": "NamedValuesListIterable.__iter__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "c664190c-c07b-4326-a8bb-44902ee4c17c",
  "subject_name": "django/db/models/query::NamedValuesListIterable.__iter__",
  "tags": [
    "entity:method"
  ],
  "text": "def __iter__(self)"
}
```
