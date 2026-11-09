# Fact 38c45945

Store id: 315a6b60-9f17-4944-8c2c-6fb613d9550f

## Text

```text
def alias(self, *args, **kwargs)
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
- posted_at: `2026-11-09T23:32:04.5785170+00:00`

## Data

```json
{
  "end_line": 1874,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1869,
  "symbol": "QuerySet.alias"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1869,"selector":"L1869-L1874","symbol":"QuerySet.alias"}`

## Items

```json
[
  {
    "text": "Return a query set with added aliases for extra data or aggregations.",
    "locator": {
      "line": 1870
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.alias](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1874,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1869,
    "symbol": "QuerySet.alias"
  },
  "id": "315a6b60-9f17-4944-8c2c-6fb613d9550f",
  "items": [
    {
      "locator": {
        "line": 1870
      },
      "text": "Return a query set with added aliases for extra data or aggregations."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.5785170+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1869,
        "selector": "L1869-L1874",
        "symbol": "QuerySet.alias"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "0fe97a6f-3648-4ad8-b95f-5e11ed3f54fd",
  "subject_name": "django/db/models/query::QuerySet.alias",
  "tags": [
    "entity:method"
  ],
  "text": "def alias(self, *args, **kwargs)"
}
```
