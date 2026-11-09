# Fact fc4b82cd

Store id: 3041c202-6c8e-45dc-89d6-14b87e82cda0

## Text

```text
def extra_select(self)
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
- posted_at: `2026-11-09T23:44:59.0493440+00:00`

## Data

```json
{
  "end_line": 2694,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2682,
  "symbol": "Query.extra_select"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2682,"selector":"L2682-L2694","symbol":"Query.extra_select"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.extra_select](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2694,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2682,
    "symbol": "Query.extra_select"
  },
  "id": "3041c202-6c8e-45dc-89d6-14b87e82cda0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:59.0493440+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2682,
        "selector": "L2682-L2694",
        "symbol": "Query.extra_select"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "2bf2f5bd-b446-48c4-9ca7-4746cc8ea723",
  "subject_name": "django/db/models/sql/query::Query.extra_select",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def extra_select(self)"
}
```
