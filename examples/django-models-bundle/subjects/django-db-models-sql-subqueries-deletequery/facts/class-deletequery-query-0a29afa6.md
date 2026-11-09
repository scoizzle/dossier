# Fact 0a29afa6

Store id: 546bd0c3-92f1-47dc-9ec0-b8a800234f9c

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
- posted_at: `2026-11-09T23:32:07.3284400+00:00`

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
  "id": "546bd0c3-92f1-47dc-9ec0-b8a800234f9c",
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
    "posted_at": "2026-11-09T23:32:07.3284400+00:00"
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
  "subject_id": "1bc2033c-5c1b-4477-a3df-1f59b15daa0c",
  "subject_name": "django/db/models/sql/subqueries::DeleteQuery",
  "tags": [
    "entity:class"
  ],
  "text": "class DeleteQuery(Query)"
}
```
