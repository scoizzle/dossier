# Fact 1410501c

Store id: 18c4d32f-f092-43c2-b979-51112848c194

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
- posted_at: `2026-11-09T23:32:04.2997320+00:00`

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
  "id": "18c4d32f-f092-43c2-b979-51112848c194",
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
    "posted_at": "2026-11-09T23:32:04.2997320+00:00"
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
  "subject_id": "b00ad65a-fa33-4333-803d-406a3ed70c02",
  "subject_name": "django/db/models/query::QuerySet",
  "tags": [
    "entity:class"
  ],
  "text": "class QuerySet(AltersData)"
}
```
