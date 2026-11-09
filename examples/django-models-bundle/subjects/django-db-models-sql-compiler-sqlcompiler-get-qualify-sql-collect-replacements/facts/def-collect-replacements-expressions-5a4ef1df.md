# Fact 5a4ef1df

Store id: 16249cd4-dc67-4da3-99f8-28092b0e650e

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
- posted_at: `2026-11-09T23:32:05.7565240+00:00`

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
  "id": "16249cd4-dc67-4da3-99f8-28092b0e650e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.7565240+00:00"
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
  "subject_id": "521a3a70-a59c-4594-b4cc-2f4263d1cf50",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.get_qualify_sql.collect_replacements",
  "tags": [
    "entity:function"
  ],
  "text": "def collect_replacements(expressions)"
}
```
