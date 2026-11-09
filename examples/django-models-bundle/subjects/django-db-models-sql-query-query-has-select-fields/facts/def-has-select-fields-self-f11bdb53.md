# Fact f11bdb53

Store id: 4f2be011-9ac1-48d1-ace4-c336ca8b09d4

## Text

```text
def has_select_fields(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:51.5363680+00:00`

## Data

```json
{
  "end_line": 2585,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2583,
  "symbol": "Query.has_select_fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2583,"selector":"L2583-L2585","symbol":"Query.has_select_fields"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.has_select_fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2585,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2583,
    "symbol": "Query.has_select_fields"
  },
  "id": "4f2be011-9ac1-48d1-ace4-c336ca8b09d4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.5363680+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2583,
        "selector": "L2583-L2585",
        "symbol": "Query.has_select_fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "d390c782-dd78-41e2-9a36-00693e341f9a",
  "subject_name": "django/db/models/sql/query::Query.has_select_fields",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def has_select_fields(self)"
}
```
