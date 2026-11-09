# Fact 29526222

Store id: d3d10a44-84e2-4c22-8109-a001567bed1a

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
- posted_at: `2026-11-09T22:39:50.7311320+00:00`

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
  "id": "d3d10a44-84e2-4c22-8109-a001567bed1a",
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
    "posted_at": "2026-11-09T22:39:50.7311320+00:00"
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
  "subject_id": "436e4b95-1a26-4e06-98c8-d83f040ac1cd",
  "subject_name": "django/db/models/sql/compiler::SQLUpdateCompiler.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self)"
}
```
