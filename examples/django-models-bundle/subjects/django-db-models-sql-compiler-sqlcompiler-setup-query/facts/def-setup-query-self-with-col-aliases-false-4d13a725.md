# Fact 4d13a725

Store id: 089f5925-f3b8-4f69-985e-b59e1d4dc293

## Text

```text
def setup_query(self, with_col_aliases=False)
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
- posted_at: `2026-11-09T22:39:50.5593610+00:00`

## Data

```json
{
  "end_line": 80,
  "entity_kind": "method",
  "parent": "SQLCompiler",
  "start_line": 74,
  "symbol": "SQLCompiler.setup_query"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":74,"selector":"L74-L80","symbol":"SQLCompiler.setup_query"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler.setup_query](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 80,
    "entity_kind": "method",
    "parent": "SQLCompiler",
    "start_line": 74,
    "symbol": "SQLCompiler.setup_query"
  },
  "id": "089f5925-f3b8-4f69-985e-b59e1d4dc293",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.5593610+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 74,
        "selector": "L74-L80",
        "symbol": "SQLCompiler.setup_query"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "a67f570e-758b-4566-aaed-f9d51ee15bfa",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.setup_query",
  "tags": [
    "entity:method"
  ],
  "text": "def setup_query(self, with_col_aliases=False)"
}
```
