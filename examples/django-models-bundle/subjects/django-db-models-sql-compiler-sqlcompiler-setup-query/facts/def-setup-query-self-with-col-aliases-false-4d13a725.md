# Fact 4d13a725

Store id: bf813975-c24e-42f4-b4ef-6b48cafe4fec

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
- posted_at: `2026-11-09T23:32:05.6662250+00:00`

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
  "id": "bf813975-c24e-42f4-b4ef-6b48cafe4fec",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.6662250+00:00"
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
  "subject_id": "f2075a66-26ad-431e-bc13-487c51b47b6c",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.setup_query",
  "tags": [
    "entity:method"
  ],
  "text": "def setup_query(self, with_col_aliases=False)"
}
```
