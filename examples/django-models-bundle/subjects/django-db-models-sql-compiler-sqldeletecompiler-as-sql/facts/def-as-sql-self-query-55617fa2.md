# Fact 55617fa2

Store id: 92516f06-4c22-473a-9b82-313528910a9a

## Text

```text
def _as_sql(self, query)
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
- posted_at: `2026-11-09T22:39:50.7220700+00:00`

## Data

```json
{
  "end_line": 2024,
  "entity_kind": "method",
  "parent": "SQLDeleteCompiler",
  "start_line": 2018,
  "symbol": "SQLDeleteCompiler._as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2018,"selector":"L2018-L2024","symbol":"SQLDeleteCompiler._as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLDeleteCompiler._as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2024,
    "entity_kind": "method",
    "parent": "SQLDeleteCompiler",
    "start_line": 2018,
    "symbol": "SQLDeleteCompiler._as_sql"
  },
  "id": "92516f06-4c22-473a-9b82-313528910a9a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.7220700+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2018,
        "selector": "L2018-L2024",
        "symbol": "SQLDeleteCompiler._as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "99100d1e-9ffd-4f5e-9dab-385e5eeb3714",
  "subject_name": "django/db/models/sql/compiler::SQLDeleteCompiler._as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def _as_sql(self, query)"
}
```
