# Fact 1410501c

Store id: e34521e0-b152-42c1-87c4-80fb299dbe2c

## Text

```text
class QuerySet(AltersData)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:49.2835260+00:00`

## Data

```json
{
  "end_line": 2392,
  "entity_kind": "class",
  "parent": "query",
  "start_line": 364,
  "symbol": "QuerySet"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":364,"selector":"L364-L2392","symbol":"QuerySet"}`

## Items

```json
[
  {
    "text": "Represent a lazy database lookup for a set of objects.",
    "locator": {
      "line": 365
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2392,
    "entity_kind": "class",
    "parent": "query",
    "start_line": 364,
    "symbol": "QuerySet"
  },
  "id": "e34521e0-b152-42c1-87c4-80fb299dbe2c",
  "items": [
    {
      "locator": {
        "line": 365
      },
      "text": "Represent a lazy database lookup for a set of objects."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.2835260+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 364,
        "selector": "L364-L2392",
        "symbol": "QuerySet"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "2644b5c2-4213-41b2-9f8d-bd393de7978b",
  "subject_name": "django/db/models/query::QuerySet",
  "tags": [
    "entity:class"
  ],
  "text": "class QuerySet(AltersData)"
}
```
