# Fact 7a1b7b88

Store id: 80e2116c-d5d6-49d0-bdee-a69a5f66ce2f

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
- posted_at: `2026-11-09T22:39:50.7379380+00:00`

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
  "id": "80e2116c-d5d6-49d0-bdee-a69a5f66ce2f",
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
    "posted_at": "2026-11-09T22:39:50.7379380+00:00"
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
  "subject_id": "ce1d04a8-fdc3-4c76-9426-5ed328c78517",
  "subject_name": "django/db/models/sql/compiler::SQLUpdateCompiler.execute_returning_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def execute_returning_sql(self, returning_fields)"
}
```
