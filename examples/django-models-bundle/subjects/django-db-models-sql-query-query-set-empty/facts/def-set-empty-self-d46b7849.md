# Fact d46b7849

Store id: 32e407a5-4e9c-4222-8298-f28fb0199bf2

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
- posted_at: `2026-11-09T23:44:58.9201180+00:00`

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
  "id": "32e407a5-4e9c-4222-8298-f28fb0199bf2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.9201180+00:00"
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
  "subject_id": "46e9583e-0a9e-4ec6-916d-64387942a009",
  "subject_name": "django/db/models/sql/query::Query.set_empty",
  "tags": [
    "entity:method"
  ],
  "text": "def set_empty(self)"
}
```
