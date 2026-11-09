# Fact 646a50e1

Store id: 8ca9f736-0aee-4120-9654-2097a5f3a061

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
- posted_at: `2026-11-09T23:32:06.1066330+00:00`

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
  "id": "8ca9f736-0aee-4120-9654-2097a5f3a061",
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
    "posted_at": "2026-11-09T23:32:06.1066330+00:00"
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
  "subject_id": "1f0913d4-96bd-420e-9388-9f26b52ad29c",
  "subject_name": "django/db/models/sql/compiler::SQLAggregateCompiler.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self)"
}
```
