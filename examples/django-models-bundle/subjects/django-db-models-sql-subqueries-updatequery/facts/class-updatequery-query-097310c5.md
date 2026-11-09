# Fact 097310c5

Store id: 1778e443-2ee9-4910-b11c-293228eefb9b

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
- posted_at: `2026-11-09T23:32:07.3528030+00:00`

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
  "id": "1778e443-2ee9-4910-b11c-293228eefb9b",
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
    "posted_at": "2026-11-09T23:32:07.3528030+00:00"
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
  "subject_id": "82c1c08c-7d7d-421f-b0aa-41254920e833",
  "subject_name": "django/db/models/sql/subqueries::UpdateQuery",
  "tags": [
    "entity:class"
  ],
  "text": "class UpdateQuery(Query)"
}
```
