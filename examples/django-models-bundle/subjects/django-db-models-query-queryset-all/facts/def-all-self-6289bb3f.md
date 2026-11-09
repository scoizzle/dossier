# Fact 6289bb3f

Store id: bce8a55f-e162-41ba-baa7-69919db87079

## Text

```text
def all(self)
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
- posted_at: `2026-11-09T22:39:49.5979330+00:00`

## Data

```json
{
  "end_line": 1693,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1688,
  "symbol": "QuerySet.all"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1688,"selector":"L1688-L1693","symbol":"QuerySet.all"}`

## Items

```json
[
  {
    "text": "Return a new QuerySet that is a copy of the current one. This allows a QuerySet to proxy for a model manager in some cases.",
    "locator": {
      "line": 1689
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.all](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1693,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1688,
    "symbol": "QuerySet.all"
  },
  "id": "bce8a55f-e162-41ba-baa7-69919db87079",
  "items": [
    {
      "locator": {
        "line": 1689
      },
      "text": "Return a new QuerySet that is a copy of the current one. This allows a QuerySet to proxy for a model manager in some cases."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.5979330+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1688,
        "selector": "L1688-L1693",
        "symbol": "QuerySet.all"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "e9ce4292-c706-459c-842d-a00ae5ec044f",
  "subject_name": "django/db/models/query::QuerySet.all",
  "tags": [
    "entity:method"
  ],
  "text": "def all(self)"
}
```
