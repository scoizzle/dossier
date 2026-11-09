# Fact 76da1b15

Store id: 4a400143-fd23-48fd-b47f-7fb0781d6b28

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
- posted_at: `2026-11-09T23:32:07.3939160+00:00`

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
  "id": "4a400143-fd23-48fd-b47f-7fb0781d6b28",
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
    "posted_at": "2026-11-09T23:32:07.3939160+00:00"
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
  "subject_id": "42bd1d13-e6b8-4df6-9c39-3cccfcdc8ffb",
  "subject_name": "django/db/models/sql/subqueries::UpdateQuery.add_related_update",
  "tags": [
    "entity:method"
  ],
  "text": "def add_related_update(self, model, field, value)"
}
```
