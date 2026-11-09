# Fact 0a29afa6

Store id: 9b30cfe8-d803-417a-8e4f-5162d522fed6

## Text

```text
class DeleteQuery(Query)
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
- posted_at: `2026-11-09T22:39:51.6966110+00:00`

## Data

```json
{
  "end_line": 46,
  "entity_kind": "class",
  "parent": "subqueries",
  "start_line": 17,
  "symbol": "DeleteQuery"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/subqueries.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":17,"selector":"L17-L46","symbol":"DeleteQuery"}`

## Items

```json
[
  {
    "text": "A DELETE SQL query.",
    "locator": {
      "line": 18
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/subqueries::DeleteQuery](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 46,
    "entity_kind": "class",
    "parent": "subqueries",
    "start_line": 17,
    "symbol": "DeleteQuery"
  },
  "id": "9b30cfe8-d803-417a-8e4f-5162d522fed6",
  "items": [
    {
      "locator": {
        "line": 18
      },
      "text": "A DELETE SQL query."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.6966110+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 17,
        "selector": "L17-L46",
        "symbol": "DeleteQuery"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/subqueries.py"
    }
  ],
  "status": "live",
  "subject_id": "360a8628-67d1-43b3-8878-3dd7dfd2ddb7",
  "subject_name": "django/db/models/sql/subqueries::DeleteQuery",
  "tags": [
    "entity:class"
  ],
  "text": "class DeleteQuery(Query)"
}
```
