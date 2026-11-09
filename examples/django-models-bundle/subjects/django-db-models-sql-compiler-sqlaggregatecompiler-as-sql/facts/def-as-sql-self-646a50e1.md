# Fact 646a50e1

Store id: d946073e-a1cb-4a48-9876-9c04911a84d7

## Text

```text
def as_sql(self)
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
- posted_at: `2026-11-09T23:44:57.7594770+00:00`

## Data

```json
{
  "end_line": 2273,
  "entity_kind": "method",
  "parent": "SQLAggregateCompiler",
  "start_line": 2252,
  "symbol": "SQLAggregateCompiler.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2252,"selector":"L2252-L2273","symbol":"SQLAggregateCompiler.as_sql"}`

## Items

```json
[
  {
    "text": "Create the SQL for this query. Return the SQL string and list of parameters.",
    "locator": {
      "line": 2253
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLAggregateCompiler.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2273,
    "entity_kind": "method",
    "parent": "SQLAggregateCompiler",
    "start_line": 2252,
    "symbol": "SQLAggregateCompiler.as_sql"
  },
  "id": "d946073e-a1cb-4a48-9876-9c04911a84d7",
  "items": [
    {
      "locator": {
        "line": 2253
      },
      "text": "Create the SQL for this query. Return the SQL string and list of parameters."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:57.7594770+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2252,
        "selector": "L2252-L2273",
        "symbol": "SQLAggregateCompiler.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "85f9fc51-3d38-48fa-8e3e-7237b89f888b",
  "subject_name": "django/db/models/sql/compiler::SQLAggregateCompiler.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self)"
}
```
