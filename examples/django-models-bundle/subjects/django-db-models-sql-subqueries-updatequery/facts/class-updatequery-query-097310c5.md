# Fact 097310c5

Store id: 79b189cd-3443-45c9-9194-fbe77660ed17

## Text

```text
class UpdateQuery(Query)
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
- posted_at: `2026-11-09T23:44:59.3441030+00:00`

## Data

```json
{
  "end_line": 145,
  "entity_kind": "class",
  "parent": "subqueries",
  "start_line": 49,
  "symbol": "UpdateQuery"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/subqueries.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":49,"selector":"L49-L145","symbol":"UpdateQuery"}`

## Items

```json
[
  {
    "text": "An UPDATE SQL query.",
    "locator": {
      "line": 50
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/subqueries::UpdateQuery](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 145,
    "entity_kind": "class",
    "parent": "subqueries",
    "start_line": 49,
    "symbol": "UpdateQuery"
  },
  "id": "79b189cd-3443-45c9-9194-fbe77660ed17",
  "items": [
    {
      "locator": {
        "line": 50
      },
      "text": "An UPDATE SQL query."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:59.3441030+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 49,
        "selector": "L49-L145",
        "symbol": "UpdateQuery"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/subqueries.py"
    }
  ],
  "status": "live",
  "subject_id": "8e1327e5-1a5f-436f-bd37-d7e65b2900d8",
  "subject_name": "django/db/models/sql/subqueries::UpdateQuery",
  "tags": [
    "entity:class"
  ],
  "text": "class UpdateQuery(Query)"
}
```
