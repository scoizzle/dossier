# Fact 55617fa2

Store id: 15dd5eeb-586f-4e3e-970e-968bf1845671

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
- posted_at: `2026-11-09T23:44:57.7103430+00:00`

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
  "id": "15dd5eeb-586f-4e3e-970e-968bf1845671",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:57.7103430+00:00"
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
  "subject_id": "769903fc-2ee0-4d8a-b975-1376e6b3802e",
  "subject_name": "django/db/models/sql/compiler::SQLDeleteCompiler._as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def _as_sql(self, query)"
}
```
