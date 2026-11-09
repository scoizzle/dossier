# Fact 29526222

Store id: 3dedac2e-5608-47dc-aa40-1f286a6e978f

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
- posted_at: `2026-11-09T23:32:06.0709550+00:00`

## Data

```json
{
  "end_line": 2130,
  "entity_kind": "method",
  "parent": "SQLUpdateCompiler",
  "start_line": 2055,
  "symbol": "SQLUpdateCompiler.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2055,"selector":"L2055-L2130","symbol":"SQLUpdateCompiler.as_sql"}`

## Items

```json
[
  {
    "text": "Create the SQL for this query. Return the SQL string and list of parameters.",
    "locator": {
      "line": 2056
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLUpdateCompiler.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2130,
    "entity_kind": "method",
    "parent": "SQLUpdateCompiler",
    "start_line": 2055,
    "symbol": "SQLUpdateCompiler.as_sql"
  },
  "id": "3dedac2e-5608-47dc-aa40-1f286a6e978f",
  "items": [
    {
      "locator": {
        "line": 2056
      },
      "text": "Create the SQL for this query. Return the SQL string and list of parameters."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.0709550+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2055,
        "selector": "L2055-L2130",
        "symbol": "SQLUpdateCompiler.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "621a5b72-1dd9-46c5-980b-b3e1ecbe3a15",
  "subject_name": "django/db/models/sql/compiler::SQLUpdateCompiler.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self)"
}
```
