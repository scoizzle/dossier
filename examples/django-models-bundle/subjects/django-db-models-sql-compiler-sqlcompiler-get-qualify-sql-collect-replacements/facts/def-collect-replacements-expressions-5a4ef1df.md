# Fact 5a4ef1df

Store id: ac660cfa-eed7-476a-aadb-7a58bae14bc3

## Text

```text
def collect_replacements(expressions)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:57.5079990+00:00`

## Data

```json
{
  "end_line": 716,
  "entity_kind": "function",
  "parent": "SQLCompiler.get_qualify_sql",
  "start_line": 699,
  "symbol": "SQLCompiler.get_qualify_sql.collect_replacements"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":699,"selector":"L699-L716","symbol":"SQLCompiler.get_qualify_sql.collect_replacements"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler.get_qualify_sql.collect_replacements](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 716,
    "entity_kind": "function",
    "parent": "SQLCompiler.get_qualify_sql",
    "start_line": 699,
    "symbol": "SQLCompiler.get_qualify_sql.collect_replacements"
  },
  "id": "ac660cfa-eed7-476a-aadb-7a58bae14bc3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:57.5079990+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 699,
        "selector": "L699-L716",
        "symbol": "SQLCompiler.get_qualify_sql.collect_replacements"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "d39f50cf-e302-424c-8b98-6f949e74fd13",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.get_qualify_sql.collect_replacements",
  "tags": [
    "entity:function"
  ],
  "text": "def collect_replacements(expressions)"
}
```
