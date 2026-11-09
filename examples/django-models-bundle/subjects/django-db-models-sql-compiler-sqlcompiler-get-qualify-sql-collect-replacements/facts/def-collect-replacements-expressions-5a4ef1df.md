# Fact 5a4ef1df

Store id: 9840f23d-cae0-47c8-b18c-347747d973a2

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
- posted_at: `2026-11-09T22:39:50.6150410+00:00`

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
  "id": "9840f23d-cae0-47c8-b18c-347747d973a2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.6150410+00:00"
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
  "subject_id": "69a48318-4362-4508-908d-cc8ad367eeb5",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.get_qualify_sql.collect_replacements",
  "tags": [
    "entity:function"
  ],
  "text": "def collect_replacements(expressions)"
}
```
