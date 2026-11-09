# Fact 58cbb2de

Store id: f2204d48-2f6e-43db-bbad-72545dafdb42

## Text

```text
def get_qualify_sql(self)
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
- posted_at: `2026-11-09T23:44:57.5014930+00:00`

## Data

```json
{
  "end_line": 773,
  "entity_kind": "method",
  "parent": "SQLCompiler",
  "start_line": 679,
  "symbol": "SQLCompiler.get_qualify_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":679,"selector":"L679-L773","symbol":"SQLCompiler.get_qualify_sql"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler.get_qualify_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 773,
    "entity_kind": "method",
    "parent": "SQLCompiler",
    "start_line": 679,
    "symbol": "SQLCompiler.get_qualify_sql"
  },
  "id": "f2204d48-2f6e-43db-bbad-72545dafdb42",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:57.5014930+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 679,
        "selector": "L679-L773",
        "symbol": "SQLCompiler.get_qualify_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "46398146-d1d7-4a64-8258-e47dbe7d158a",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.get_qualify_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def get_qualify_sql(self)"
}
```
