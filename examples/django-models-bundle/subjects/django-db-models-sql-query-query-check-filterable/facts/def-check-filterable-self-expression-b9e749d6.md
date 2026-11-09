# Fact b9e749d6

Store id: 06bea51b-e65f-4292-b177-8e7ea82696db

## Text

```text
def check_filterable(self, expression)
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
- posted_at: `2026-11-09T23:44:58.8309740+00:00`

## Data

```json
{
  "end_line": 1412,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 1401,
  "symbol": "Query.check_filterable"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1401,"selector":"L1401-L1412","symbol":"Query.check_filterable"}`

## Items

```json
[
  {
    "text": "Raise an error if expression cannot be used in a WHERE clause.",
    "locator": {
      "line": 1402
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.check_filterable](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1412,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 1401,
    "symbol": "Query.check_filterable"
  },
  "id": "06bea51b-e65f-4292-b177-8e7ea82696db",
  "items": [
    {
      "locator": {
        "line": 1402
      },
      "text": "Raise an error if expression cannot be used in a WHERE clause."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.8309740+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1401,
        "selector": "L1401-L1412",
        "symbol": "Query.check_filterable"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "87df124f-2b98-4aee-b03a-8c59067bc624",
  "subject_name": "django/db/models/sql/query::Query.check_filterable",
  "tags": [
    "entity:method"
  ],
  "text": "def check_filterable(self, expression)"
}
```
