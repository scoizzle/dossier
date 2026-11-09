# Fact 55617fa2

Store id: bef89e3d-b549-4108-8f4a-97112c3c744a

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
- posted_at: `2026-11-09T23:32:06.0356270+00:00`

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
  "id": "bef89e3d-b549-4108-8f4a-97112c3c744a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.0356270+00:00"
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
  "subject_id": "93b2d7ad-2930-4155-9a95-e61f832e4385",
  "subject_name": "django/db/models/sql/compiler::SQLDeleteCompiler._as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def _as_sql(self, query)"
}
```
