# Fact 7a1b7b88

Store id: e6669f9e-1c5c-4afe-b8b1-6d2b5f56dcac

## Text

```text
def execute_returning_sql(self, returning_fields)
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
- posted_at: `2026-11-09T23:32:06.0919970+00:00`

## Data

```json
{
  "end_line": 2183,
  "entity_kind": "method",
  "parent": "SQLUpdateCompiler",
  "start_line": 2153,
  "symbol": "SQLUpdateCompiler.execute_returning_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2153,"selector":"L2153-L2183","symbol":"SQLUpdateCompiler.execute_returning_sql"}`

## Items

```json
[
  {
    "text": "Execute the specified update and return rows of the returned columns associated with the specified returning_field if the backend supports it.",
    "locator": {
      "line": 2154
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLUpdateCompiler.execute_returning_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2183,
    "entity_kind": "method",
    "parent": "SQLUpdateCompiler",
    "start_line": 2153,
    "symbol": "SQLUpdateCompiler.execute_returning_sql"
  },
  "id": "e6669f9e-1c5c-4afe-b8b1-6d2b5f56dcac",
  "items": [
    {
      "locator": {
        "line": 2154
      },
      "text": "Execute the specified update and return rows of the returned columns associated with the specified returning_field if the backend supports it."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.0919970+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2153,
        "selector": "L2153-L2183",
        "symbol": "SQLUpdateCompiler.execute_returning_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "0079b624-978d-431d-909e-c4d0b6fc5e2a",
  "subject_name": "django/db/models/sql/compiler::SQLUpdateCompiler.execute_returning_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def execute_returning_sql(self, returning_fields)"
}
```
