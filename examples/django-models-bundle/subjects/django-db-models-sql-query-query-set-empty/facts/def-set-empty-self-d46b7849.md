# Fact d46b7849

Store id: 182a33a1-25e8-492e-ac1c-c0c7de04294e

## Text

```text
def set_empty(self)
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
- posted_at: `2026-11-09T23:32:07.0058030+00:00`

## Data

```json
{
  "end_line": 2184,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2181,
  "symbol": "Query.set_empty"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2181,"selector":"L2181-L2184","symbol":"Query.set_empty"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.set_empty](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2184,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2181,
    "symbol": "Query.set_empty"
  },
  "id": "182a33a1-25e8-492e-ac1c-c0c7de04294e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.0058030+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2181,
        "selector": "L2181-L2184",
        "symbol": "Query.set_empty"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "e6fd74ab-f007-4c91-9c46-11e51f69d687",
  "subject_name": "django/db/models/sql/query::Query.set_empty",
  "tags": [
    "entity:method"
  ],
  "text": "def set_empty(self)"
}
```
