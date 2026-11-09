# Fact f12995cc

Store id: abae6172-945c-4a87-b8da-151019de447c

## Text

```text
def set_values(self, fields)
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
- posted_at: `2026-11-09T23:32:07.1324100+00:00`

## Data

```json
{
  "end_line": 2660,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2587,
  "symbol": "Query.set_values"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2587,"selector":"L2587-L2660","symbol":"Query.set_values"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.set_values](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2660,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2587,
    "symbol": "Query.set_values"
  },
  "id": "abae6172-945c-4a87-b8da-151019de447c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.1324100+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2587,
        "selector": "L2587-L2660",
        "symbol": "Query.set_values"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "190b7aa7-7efd-4aee-a305-cc48ba5d15bc",
  "subject_name": "django/db/models/sql/query::Query.set_values",
  "tags": [
    "entity:method"
  ],
  "text": "def set_values(self, fields)"
}
```
