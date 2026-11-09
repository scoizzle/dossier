# Fact 76da1b15

Store id: 42b128f5-6d9c-44cc-a2c0-3a101fbd0cd3

## Text

```text
def add_related_update(self, model, field, value)
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
- posted_at: `2026-11-09T22:39:51.7503890+00:00`

## Data

```json
{
  "end_line": 128,
  "entity_kind": "method",
  "parent": "UpdateQuery",
  "start_line": 122,
  "symbol": "UpdateQuery.add_related_update"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/subqueries.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":122,"selector":"L122-L128","symbol":"UpdateQuery.add_related_update"}`

## Items

```json
[
  {
    "text": "Add (name, value) to an update query for an ancestor model.",
    "locator": {
      "line": 123
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/subqueries::UpdateQuery.add_related_update](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 128,
    "entity_kind": "method",
    "parent": "UpdateQuery",
    "start_line": 122,
    "symbol": "UpdateQuery.add_related_update"
  },
  "id": "42b128f5-6d9c-44cc-a2c0-3a101fbd0cd3",
  "items": [
    {
      "locator": {
        "line": 123
      },
      "text": "Add (name, value) to an update query for an ancestor model."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.7503890+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 122,
        "selector": "L122-L128",
        "symbol": "UpdateQuery.add_related_update"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/subqueries.py"
    }
  ],
  "status": "live",
  "subject_id": "7a84ff01-a734-4d40-a6d0-797622f64be3",
  "subject_name": "django/db/models/sql/subqueries::UpdateQuery.add_related_update",
  "tags": [
    "entity:method"
  ],
  "text": "def add_related_update(self, model, field, value)"
}
```
