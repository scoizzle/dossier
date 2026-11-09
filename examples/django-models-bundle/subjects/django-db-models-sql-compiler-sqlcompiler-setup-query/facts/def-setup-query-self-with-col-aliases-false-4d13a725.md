# Fact 4d13a725

Store id: a6e20b6b-e7ba-418c-8bdb-a52c4dc86a67

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
- posted_at: `2026-11-09T23:44:57.3918440+00:00`

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
  "id": "a6e20b6b-e7ba-418c-8bdb-a52c4dc86a67",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:57.3918440+00:00"
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
  "subject_id": "9ead1a14-1fec-4e70-966f-973f69bbd399",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.setup_query",
  "tags": [
    "entity:method"
  ],
  "text": "def setup_query(self, with_col_aliases=False)"
}
```
