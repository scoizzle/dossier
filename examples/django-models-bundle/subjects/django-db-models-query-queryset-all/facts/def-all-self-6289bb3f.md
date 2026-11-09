# Fact 6289bb3f

Store id: 8ccb706f-3424-4866-8c3c-1db258753b08

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
- posted_at: `2026-11-09T23:32:04.5342560+00:00`

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
  "id": "8ccb706f-3424-4866-8c3c-1db258753b08",
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
    "posted_at": "2026-11-09T23:32:04.5342560+00:00"
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
  "subject_id": "3e5b8cce-08a8-4bbc-b9b7-e54668e11509",
  "subject_name": "django/db/models/query::QuerySet.all",
  "tags": [
    "entity:method"
  ],
  "text": "def all(self)"
}
```
