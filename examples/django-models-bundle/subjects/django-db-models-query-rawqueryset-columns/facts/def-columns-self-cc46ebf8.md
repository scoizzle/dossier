# Fact cc46ebf8

Store id: e0aa5a67-85f9-4eb9-92a8-32880dfc452f

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
- posted_at: `2026-11-09T22:39:49.8287350+00:00`

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
  "id": "e0aa5a67-85f9-4eb9-92a8-32880dfc452f",
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
    "posted_at": "2026-11-09T22:39:49.8287350+00:00"
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
  "subject_id": "62c5fb2c-7241-42e4-b4b8-e21a08f23aae",
  "subject_name": "django/db/models/query::RawQuerySet.columns",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def columns(self)"
}
```
