# Fact a9c3071f

Store id: e2b4c56a-fc91-4f42-8dd9-60a1592a3ef7

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
- posted_at: `2026-11-09T22:39:49.3777910+00:00`

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
  "id": "e2b4c56a-fc91-4f42-8dd9-60a1592a3ef7",
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
    "posted_at": "2026-11-09T22:39:49.3777910+00:00"
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
  "subject_id": "dee10d4e-6882-4e02-ad05-5e782d4a1e29",
  "subject_name": "django/db/models/query::QuerySet.count",
  "tags": [
    "entity:method"
  ],
  "text": "def count(self)"
}
```
