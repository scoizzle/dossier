# Fact a9c3071f

Store id: db536357-11ca-484c-8918-da6b7fdd9e3b

## Text

```text
def count(self)
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
- posted_at: `2026-11-09T23:44:55.8889330+00:00`

## Data

```json
{
  "end_line": 693,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 682,
  "symbol": "QuerySet.count"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":682,"selector":"L682-L693","symbol":"QuerySet.count"}`

## Items

```json
[
  {
    "text": "Perform a SELECT COUNT() and return the number of records as an integer.",
    "locator": {
      "line": 683
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.count](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 693,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 682,
    "symbol": "QuerySet.count"
  },
  "id": "db536357-11ca-484c-8918-da6b7fdd9e3b",
  "items": [
    {
      "locator": {
        "line": 683
      },
      "text": "Perform a SELECT COUNT() and return the number of records as an integer."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.8889330+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 682,
        "selector": "L682-L693",
        "symbol": "QuerySet.count"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "a6b86ede-cc21-45f6-ae89-3e732fb2dd07",
  "subject_name": "django/db/models/query::QuerySet.count",
  "tags": [
    "entity:method"
  ],
  "text": "def count(self)"
}
```
