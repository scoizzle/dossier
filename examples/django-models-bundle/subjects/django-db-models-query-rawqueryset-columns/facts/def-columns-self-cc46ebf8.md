# Fact cc46ebf8

Store id: 9cc3ca50-3dee-4cff-8067-f9e2b035eda4

## Text

```text
def columns(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:04.7743460+00:00`

## Data

```json
{
  "end_line": 2555,
  "entity_kind": "method",
  "parent": "RawQuerySet",
  "start_line": 2539,
  "symbol": "RawQuerySet.columns"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2539,"selector":"L2539-L2555","symbol":"RawQuerySet.columns"}`

## Items

```json
[
  {
    "text": "A list of model field names in the order they'll appear in the query results.",
    "locator": {
      "line": 2541
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::RawQuerySet.columns](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2555,
    "entity_kind": "method",
    "parent": "RawQuerySet",
    "start_line": 2539,
    "symbol": "RawQuerySet.columns"
  },
  "id": "9cc3ca50-3dee-4cff-8067-f9e2b035eda4",
  "items": [
    {
      "locator": {
        "line": 2541
      },
      "text": "A list of model field names in the order they'll appear in the query results."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.7743460+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2539,
        "selector": "L2539-L2555",
        "symbol": "RawQuerySet.columns"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "e320ed60-f259-432d-8ae3-e9a0d6fb397a",
  "subject_name": "django/db/models/query::RawQuerySet.columns",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def columns(self)"
}
```
