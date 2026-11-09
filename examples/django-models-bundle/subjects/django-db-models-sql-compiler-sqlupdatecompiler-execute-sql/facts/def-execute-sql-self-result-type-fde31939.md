# Fact fde31939

Store id: 0d2e61d9-40af-4fe7-901e-5b38d369d9ac

## Text

```text
def execute_sql(self, result_type)
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
- posted_at: `2026-11-09T23:44:57.7305430+00:00`

## Data

```json
{
  "end_line": 2151,
  "entity_kind": "method",
  "parent": "SQLUpdateCompiler",
  "start_line": 2132,
  "symbol": "SQLUpdateCompiler.execute_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2132,"selector":"L2132-L2151","symbol":"SQLUpdateCompiler.execute_sql"}`

## Items

```json
[
  {
    "text": "Execute the specified update. Return the number of rows affected by the primary update query. The \"primary update query\" is the first non-empty query that is executed. Row counts for any subsequent, related queries are not available.",
    "locator": {
      "line": 2133
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLUpdateCompiler.execute_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2151,
    "entity_kind": "method",
    "parent": "SQLUpdateCompiler",
    "start_line": 2132,
    "symbol": "SQLUpdateCompiler.execute_sql"
  },
  "id": "0d2e61d9-40af-4fe7-901e-5b38d369d9ac",
  "items": [
    {
      "locator": {
        "line": 2133
      },
      "text": "Execute the specified update. Return the number of rows affected by the primary update query. The \"primary update query\" is the first non-empty query that is executed. Row counts for any subsequent, related queries are not available."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:57.7305430+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2132,
        "selector": "L2132-L2151",
        "symbol": "SQLUpdateCompiler.execute_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "264c63dc-7f07-4feb-b3ea-3038cfed8621",
  "subject_name": "django/db/models/sql/compiler::SQLUpdateCompiler.execute_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def execute_sql(self, result_type)"
}
```
