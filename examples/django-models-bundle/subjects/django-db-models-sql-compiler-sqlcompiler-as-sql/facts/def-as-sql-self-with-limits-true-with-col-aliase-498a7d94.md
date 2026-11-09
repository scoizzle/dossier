# Fact 498a7d94

Store id: db29bff8-7ff4-42b6-bc43-5e6a7055d964

## Text

```text
def as_sql(self, with_limits=True, with_col_aliases=False)
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
- posted_at: `2026-11-09T23:32:05.7615790+00:00`

## Data

```json
{
  "end_line": 1000,
  "entity_kind": "method",
  "parent": "SQLCompiler",
  "start_line": 775,
  "symbol": "SQLCompiler.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":775,"selector":"L775-L1000","symbol":"SQLCompiler.as_sql"}`

## Items

```json
[
  {
    "text": "Create the SQL for this query. Return the SQL string and list of parameters.",
    "locator": {
      "line": 776
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1000,
    "entity_kind": "method",
    "parent": "SQLCompiler",
    "start_line": 775,
    "symbol": "SQLCompiler.as_sql"
  },
  "id": "db29bff8-7ff4-42b6-bc43-5e6a7055d964",
  "items": [
    {
      "locator": {
        "line": 776
      },
      "text": "Create the SQL for this query. Return the SQL string and list of parameters."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.7615790+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 775,
        "selector": "L775-L1000",
        "symbol": "SQLCompiler.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "b56e7f1d-d966-45dd-94d5-a62677615bd0",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, with_limits=True, with_col_aliases=False)"
}
```
