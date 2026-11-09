# Fact f927cae2

Store id: 8afff1b3-6cf2-4e25-a897-714f464343ca

## Text

```text
def get_related_updates(self)
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
- posted_at: `2026-11-09T22:39:51.7536220+00:00`

## Data

```json
{
  "end_line": 145,
  "entity_kind": "method",
  "parent": "UpdateQuery",
  "start_line": 130,
  "symbol": "UpdateQuery.get_related_updates"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/subqueries.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":130,"selector":"L130-L145","symbol":"UpdateQuery.get_related_updates"}`

## Items

```json
[
  {
    "text": "Return a list of query objects: one for each update required to an ancestor model. Each query will have the same filtering conditions as the current query but will only update a single table.",
    "locator": {
      "line": 131
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/subqueries::UpdateQuery.get_related_updates](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 145,
    "entity_kind": "method",
    "parent": "UpdateQuery",
    "start_line": 130,
    "symbol": "UpdateQuery.get_related_updates"
  },
  "id": "8afff1b3-6cf2-4e25-a897-714f464343ca",
  "items": [
    {
      "locator": {
        "line": 131
      },
      "text": "Return a list of query objects: one for each update required to an ancestor model. Each query will have the same filtering conditions as the current query but will only update a single table."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.7536220+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 130,
        "selector": "L130-L145",
        "symbol": "UpdateQuery.get_related_updates"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/subqueries.py"
    }
  ],
  "status": "live",
  "subject_id": "52dba4b4-77fb-495a-af5e-957a15d6e785",
  "subject_name": "django/db/models/sql/subqueries::UpdateQuery.get_related_updates",
  "tags": [
    "entity:method"
  ],
  "text": "def get_related_updates(self)"
}
```
