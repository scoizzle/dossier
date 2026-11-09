# Fact c8a12a08

Store id: 68287640-f1ec-44b9-a79b-cc7f3a71fb3e

## Text

```text
def setup_joins( self, names, opts, alias, can_reuse=None, allow_many=True, )
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
- posted_at: `2026-11-09T22:39:51.4021860+00:00`

## Data

```json
{
  "end_line": 2005,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 1890,
  "symbol": "Query.setup_joins"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1890,"selector":"L1890-L2005","symbol":"Query.setup_joins"}`

## Items

```json
[
  {
    "text": "Compute the necessary table joins for the passage through the fields given in 'names'. 'opts' is the Options class for the current model (which gives the table we are starting from), 'alias' is the alias for the table to start the joining from.",
    "locator": {
      "line": 1898
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.setup_joins](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2005,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 1890,
    "symbol": "Query.setup_joins"
  },
  "id": "68287640-f1ec-44b9-a79b-cc7f3a71fb3e",
  "items": [
    {
      "locator": {
        "line": 1898
      },
      "text": "Compute the necessary table joins for the passage through the fields given in 'names'. 'opts' is the Options class for the current model (which gives the table we are starting from), 'alias' is the alias for the table to start the joining from."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.4021860+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1890,
        "selector": "L1890-L2005",
        "symbol": "Query.setup_joins"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "f410c25d-7603-45fd-8fa1-d4cc410effe9",
  "subject_name": "django/db/models/sql/query::Query.setup_joins",
  "tags": [
    "entity:method"
  ],
  "text": "def setup_joins( self, names, opts, alias, can_reuse=None, allow_many=True, )"
}
```
