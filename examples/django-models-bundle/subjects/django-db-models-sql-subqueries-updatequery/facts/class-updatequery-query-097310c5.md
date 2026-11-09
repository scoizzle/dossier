# Fact 097310c5

Store id: 98fd101c-ba6e-4eb2-93fb-2c4e66899a20

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
- posted_at: `2026-11-09T22:39:51.7176140+00:00`

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
  "id": "98fd101c-ba6e-4eb2-93fb-2c4e66899a20",
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
    "posted_at": "2026-11-09T22:39:51.7176140+00:00"
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
  "subject_id": "a1d3a754-5d94-4b92-a56a-a8f8f944d3fe",
  "subject_name": "django/db/models/sql/subqueries::UpdateQuery",
  "tags": [
    "entity:class"
  ],
  "text": "class UpdateQuery(Query)"
}
```
